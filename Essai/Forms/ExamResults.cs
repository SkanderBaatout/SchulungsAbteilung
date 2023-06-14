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
            // Set CurrentCell to null to avoid selecting the first row by default
            resultDGV.CurrentCell = null;
        }

        SqlConnection Con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True");

        private void DisplayResults()
        {
            Con.Open();
            string Query = "select id, TestName, NumberOfQuestions, Date, Name, CIN, Score, Status from ExamResult";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            resultDGV.DataSource = ds.Tables[0];
            resultDGV.Columns[0].Visible = false;
            resultDGV.Columns[1].HeaderText = "Test Name";
            resultDGV.Columns[2].HeaderText = "Number of questions";
            resultDGV.Columns[3].HeaderText = "Date";
            resultDGV.Columns[4].HeaderText = "Name";
            resultDGV.Columns[5].HeaderText = "CIN";
            resultDGV.Columns[6].HeaderText = "Score";
            resultDGV.Columns[7].HeaderText = "Status";

            /*  foreach (DataGridViewRow row in resultDGV.Rows)
              {
                  bool status = Convert.ToBoolean(row.Cells["Status"].Value);
                  string statusText = status ? "Accepté" : "Rejeté";
                  Color statusColor = status ? Color.Green : Color.Red;

                  row.Cells["Status"].Value = statusText; // Remplacer la valeur booléenne par le texte du statut
                  row.Cells["Status"].Style.ForeColor = statusColor;
              }
            */
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

                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Worksheet worksheet = (Worksheet)workbook.ActiveSheet;

                SqlCommand cmd = new SqlCommand("SELECT TestName, NumberOfQuestions, Date, Name, CIN, Score, Status FROM ExamResult", Con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

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

            if (candidateName != null && testName != null)
            {
                FilterByCandidateAndTest(candidateName, testName);
            }
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

        private void resultDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in resultDGV.Rows)
            {
                if (!row.IsNewRow)
                {
                    object cellValue = row.Cells[7].Value;
                    if (cellValue != DBNull.Value)
                    {
                        bool isApproved = Convert.ToBoolean(cellValue);
                        if (isApproved == false)
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                            row.DefaultCellStyle.ForeColor = Color.White;
                        }
                        else if (isApproved == true)
                        {
                            row.DefaultCellStyle.BackColor = Color.Green;
                            row.DefaultCellStyle.ForeColor = Color.Yellow;
                        }
                    }

                }
            }

        }
    }
}