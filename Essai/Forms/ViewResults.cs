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

namespace Essai
{
    public partial class ViewResults : Form
    {
        public ViewResults()
        {
            InitializeComponent();
            GetSubjects();
            GetCandidate();
            DisplayResults();
            subjectcb.SelectedIndexChanged += new EventHandler(subjectcb_SelectedIndexChanged);
            candidatecb.SelectedIndexChanged += new EventHandler(candidatecb_SelectedIndexChanged);
        }

        SqlConnection Con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True");

        private void GetSubjects()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select SName from SubjectTbl  ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SName", typeof(string));
            dt.Load(rdr);
            subjectcb.ValueMember = "SName";
            subjectcb.DataSource = dt;
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
            candidatecb.ValueMember = "username";
            candidatecb.DataSource = dt;
            Con.Close();
        }

        private void DisplayResults()
        {
            Con.Open();
            String Query = "select * from ResultTbl  ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            resultDGV.DataSource = ds.Tables[0];
            resultDGV.Columns[0].HeaderText = "ID";

            resultDGV.Columns[1].HeaderText = "Training";
            resultDGV.Columns[2].HeaderText = "Candidate";
            resultDGV.Columns[3].HeaderText = "Date";
            resultDGV.Columns[4].HeaderText = "Time";
            resultDGV.Columns[5].HeaderText = "Score";
            Con.Close();
        }

        private void FilterBySub()
        {
            Con.Open();
            String Query = "SELECT RCandidate, RSubject, MAX(RScore) as RScore FROM ResultTbl WHERE RSubject = '" + subjectcb.SelectedValue.ToString() + "' GROUP BY RCandidate, RSubject";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            resultDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FilterByCandidate()
        {
            Con.Open();
            String Query = "select * from ResultTbl Where RCandidate ='" + candidatecb.SelectedValue.ToString() + "'  ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            resultDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

     

        private void subjectcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBySub();
        }

        private void candidatecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByCandidate();
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

                // Retrieve the data from the ResultTbl table
                SqlCommand cmd = new SqlCommand("SELECT RCandidate, RSubject, RScore, RDate FROM ResultTbl", Con);
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
                saveFileDialog.FileName = "ResultTbl.xlsx";
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
    }
}