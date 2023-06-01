using Microsoft.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace Essai.Forms
{
    public partial class ExamResults : Form
    {
        public ExamResults()
        {
            InitializeComponent();
            GetTests();
            GetCandidate();
            DisplayResults();

            candidatecb.SelectedIndexChanged += new EventHandler(candidatecb_SelectedIndexChanged);
            TestTypecb.SelectedIndexChanged += new EventHandler(TestTypecb_SelectedIndexChanged);
        }

        SqlConnection Con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True");

        private void DisplayResults()
        {
            Con.Open();
            String Query = "select id, TestName, NumberOfQuestions, Date, Name, CIN, Score, Status from ExamResult";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            resultDGV.DataSource = ds.Tables[0];
            resultDGV.Columns[0].Visible = false; // hide the ID column
            resultDGV.Columns[1].HeaderText = "TestName";
            resultDGV.Columns[2].HeaderText = "NumberOfQuestions";
            resultDGV.Columns[3].HeaderText = "Date";
            resultDGV.Columns[4].HeaderText = "Name";
            resultDGV.Columns[5].HeaderText = "CIN";
            resultDGV.Columns[6].HeaderText = "Score";
            resultDGV.Columns[7].HeaderText = "Status";

           
            Con.Close();
        }
        private void GetCandidate()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select username from employees ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("username", typeof(string));
            dt.Load(rdr);

            // Add "All" option at index 0
            DataRow allRow = dt.NewRow();
            allRow["username"] = "All";
            dt.Rows.InsertAt(allRow, 0);

            candidatecb.ValueMember = "username";
            candidatecb.DataSource = dt;
            Con.Close();
        }

        private void GetTests()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT name FROM TestsType", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Load(rdr);

            // Add "All" option at index 0
            DataRow allRow = dt.NewRow();
            allRow["name"] = "All";
            dt.Rows.InsertAt(allRow, 0);

            TestTypecb.ValueMember = "name";
            TestTypecb.DataSource = dt;
            Con.Close();
        }

        private void ExportToExcel()
        {
            try
            {
                Con.Open();

                // Create a new Excel workbook and worksheet
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Worksheet worksheet = (Worksheet)workbook.ActiveSheet;

                // Retrieve the data from the ExamResult table
                SqlCommand cmd = new SqlCommand("SELECT TestName, NumberOfQuestions, Date, Name, CIN, Score, Status FROM ExamResult", Con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Write the data to the Excel worksheet
                int row = 1;
                int col = 1;
                foreach (DataColumn column in dataTable.Columns)
                {
                    worksheet.Cells[row, col] = column.ColumnName;
                    col++;
                }
                row++;
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    col = 1;
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        worksheet.Cells[row, col] = dataRow[column.ColumnName].ToString();
                        col++;
                    }
                    row++;
                }

                // Save the Excel workbook
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FileName = "ExamResult.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Exported successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void FilterByCandidateAndTest(string candidateName, string testName)
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            string query = "SELECT * FROM ExamResult WHERE (@Name = 'All' OR Name = @Name) AND (@TestName = 'All' OR TestName = @TestName)";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@Name", candidateName);
            cmd.Parameters.AddWithValue("@TestName", testName);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            resultDGV.DataSource = dt;
            Con.Close();
        }

        private void FilterByCandidate()
        {
            string candidateName = candidatecb.SelectedValue.ToString();
            string testName = TestTypecb.SelectedValue.ToString();
            FilterByCandidateAndTest(candidateName, testName);
        }

        private void FilterByTest()
        {
            string candidateName = candidatecb.SelectedValue?.ToString();
            string testName = TestTypecb.SelectedValue?.ToString();
            if (candidateName != null && testName != null)
            {
                FilterByCandidateAndTest(candidateName, testName);
            }
        }

        private void candidatecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByCandidate();
        }

        private void TestTypecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByTest();
        }
    }
}