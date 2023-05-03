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
            Con.Close();
        }
        private void FilterBySub()
        {
            Con.Open();
            String Query = "select * from ResultTbl Where RSubject ='" + subjectcb.SelectedValue.ToString() + "'  ";
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
        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }

        private void subjectcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterBySub();
        }

        private void candidatecb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCandidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
