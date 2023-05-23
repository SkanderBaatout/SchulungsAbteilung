using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ClosedXML.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using Syncfusion.PdfViewer.Windows;
using Syncfusion.Windows.Forms.PdfViewer;
using Syncfusion.Pdf.Parsing;
using Syncfusion.XlsIO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.InteropServices;
using Essai.Models;

namespace Essai
{
    public partial class PlanFormation : Form
    {
        private readonly string _connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";
        private DataTable _dataTable;
        private int _selectedTestTypeId;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;

        public PlanFormation()
        {
            InitializeComponent();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            LoadTestTypes();
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();


            // Add Edit and Delete buttons and PlanName columns to the dataGridView
            var editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "Edit";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            editButton.DefaultCellStyle.BackColor = Color.Teal; // set button color
            dataGridView.Columns.Add(editButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.DefaultCellStyle.BackColor = Color.Teal; // set button color;
            dataGridView.Columns.Add(deleteButton);

        }

        private void LoadTestTypes()
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("SELECT id, name FROM TestsType", connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    var testTypes = new List<TestsType>();
                    testTypes.Add(new TestsType { Id = -1, Name = "All" }); // Add "All" option
                    while (reader.Read())
                    {
                        var testType = new TestsType
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        };
                        testTypes.Add(testType);
                    }
                    comboBox1.DataSource = testTypes;
                }
            }
        }
        private void loadDataButton_Click(object sender, EventArgs e)
        {
            LoadPlans();
            if (dataGridView.Rows.Count == 11 && comboBox1.SelectedValue != null)
            {
                button1.Enabled = false;
                saveButton.Enabled = false;
                loadDataButton.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                saveButton.Enabled = true;
                loadDataButton.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a test type first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var testTypeName = comboBox1.Text;
            _selectedTestTypeId = (int)comboBox1.SelectedValue;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] fileData;
                    using (var stream = new MemoryStream())
                    using (var fileStream = openFileDialog1.OpenFile())
                    {
                        fileStream.CopyTo(stream);
                        fileData = stream.ToArray();
                    }
                    using (var connection = new SqlConnection(_connectionString))
                    using (var command = new SqlCommand("INSERT INTO Plans (TestTypeId, PlanData, PlanName) VALUES (@testTypeId, @planData, @planName)", connection))
                    {
                        command.Parameters.AddWithValue("@testTypeId", _selectedTestTypeId);
                        command.Parameters.AddWithValue("@planData", fileData);
                        command.Parameters.AddWithValue("@planName", "Plan de formation " + testTypeName);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPlans();
                    if (dataGridView.Rows.Count == 11 && comboBox1.SelectedValue != null)
                    {
                        saveButton.Text = "Update";
                        MessageBox.Show("All plans have been added for this test type.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a test type first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _selectedTestTypeId = (int)comboBox1.SelectedValue;
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedRow = dataGridView.SelectedRows[0];
            byte[] fileData = (byte[])selectedRow.Cells["PlanData"].Value;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, fileData);
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlans();
        }

        private void LoadPlans()
        {
            int selectedTestId = (int)comboBox1.SelectedValue;
            string sqlQuery;

            if (selectedTestId == -1) // "All" option selected
            {
                sqlQuery = "SELECT PlanId, TestTypeId, PlanData FROM Plans";
            }
            else // specific test type selected
            {
                sqlQuery = "SELECT PlanId, TestTypeId, PlanData, PlanName FROM Plans WHERE TestTypeId = @testTypeId";
            }

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    if (selectedTestId != -1) // specific test type selected
                    {
                        command.Parameters.AddWithValue("@testTypeId", selectedTestId);
                    }

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {

                        _dataTable = new DataTable();
                        _dataTable.Load(reader);
                        dataGridView.DataSource = _dataTable;
                        dataGridView.Columns["PlanData"].Visible = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView.Rows[e.RowIndex];
                byte[] fileData = (byte[])selectedRow.Cells["PlanData"].Value;
                try
                {
                    string tempFilePath = Path.GetTempFileName();
                    File.WriteAllBytes(tempFilePath, fileData);
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Visible = true;
                    Excel.Workbook workbook = excelApp.Workbooks.Open(tempFilePath, false, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.Item[1];
                    worksheet.Activate();
                    Marshal.ReleaseComObject(worksheet);
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(excelApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while opening the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void PlanFormation_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(this);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            var selectedRow = dataGridView.Rows[e.RowIndex];
            var planId = (int)selectedRow.Cells["PlanId"].Value;

            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                // Hide the "Load Data" and "Save" buttons and disable the DataGridView while editing
                loadDataButton.Enabled = false;
                saveButton.Enabled = false;
                dataGridView.Enabled = false;

                // Show the "Select File" button and hide the "Edit" button
                button1.Visible = true;

                // Store the selected plan ID in the Tag property of the "Select File" button
                button1.Tag = planId;
            }
            else if (dataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                // Show a confirmation dialog before deleting the plan
                var result = MessageBox.Show("Are you sure you want to delete this plan?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Delete the plan from the database and the DataGridView
                    DeletePlan(planId);
                    dataGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
        private void DeletePlan(int planId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("DELETE FROM Plans WHERE PlanId = @PlanId", connection))
                {
                    command.Parameters.AddWithValue("@PlanId", planId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}


