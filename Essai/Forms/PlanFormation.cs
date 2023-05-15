using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Essai
{
    public partial class PlanFormation : Form
    {
        private readonly string _connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";
        private DataTable _dataTable;

        public PlanFormation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers Excel (*.xlsx)|*.xlsx|Tous les fichiers (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the workbook
                    using (var workbook = new ClosedXML.Excel.XLWorkbook(openFileDialog.FileName))
                    {
                        // Get the first worksheet
                        var worksheet = workbook.Worksheet(1);

                        // Find the first row with data
                        var firstRow = worksheet.RowsUsed().FirstOrDefault();

                        if (firstRow != null)
                        {
                            // Load the data into a DataTable
                            var dataTable = new DataTable();

                            foreach (var cell in firstRow.Cells())
                            {
                                dataTable.Columns.Add(cell.Value.ToString());
                            }

                            foreach (var row in worksheet.RowsUsed().Skip(1))
                            {
                                var dataRow = dataTable.NewRow();

                                for (int i = 0; i < dataTable.Columns.Count; i++)
                                {
                                    dataRow[i] = row.Cell(i + 1).Value.ToString();
                                }

                                dataTable.Rows.Add(dataRow);
                            }

                            _dataTable = dataTable;
                            dataGridView.DataSource = _dataTable;
                        }
                        else
                        {
                            MessageBox.Show("The file does not contain any data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            try
            {
                // Create a new SQL Server connection
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Generate the SQL query to create the table based on the columns in the DataTable
                    string createTableQuery = "CREATE TABLE ExcelData (";
                    foreach (DataColumn column in _dataTable.Columns)
                    {
                        createTableQuery += "[" + column.ColumnName + "] NVARCHAR(MAX),";
                    }
                    createTableQuery = createTableQuery.TrimEnd(',') + ")";

                    // Create the SQL Server table
                    using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Generate the SQL query to insert the data into the table
                    string insertQuery = $"INSERT INTO ExcelData VALUES ({string.Join(",", _dataTable.Columns.Cast<DataColumn>().Select(c => "@p" + c.Ordinal.ToString()))})";

                    // Insert the data into the SQL Server table
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        foreach (DataRow row in _dataTable.Rows)
                        {
                            for (int i = 0; i < _dataTable.Columns.Count; i++)
                            {
                                command.Parameters.AddWithValue("@p" + i.ToString(), row[i].ToString());
                            }

                            command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                    }

                    MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new DataTable object to hold the data
                DataTable dataTable = new DataTable();

                // Create a new SQL Server connection
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Generate the SQLquery to retrieve the data from the table
                    string selectQuery = "SELECT * FROM ExcelData";

                    // Create a new SqlDataAdapter object to fill the DataTable with the data from the SQL Server table
                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Set the DataSource property of the DataGridView control to the DataTable object
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}