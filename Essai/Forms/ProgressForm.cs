using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai.Forms
{
    public partial class ProgressForm : Form
    {
        private DataTable progressionTable; // store the original table

        public ProgressForm()
        {
            InitializeComponent();
            GetSubjects();
            GetCandidate();
            DisplayProgression();
            subjectcb.SelectedIndexChanged += new EventHandler(subjectcb_SelectedIndexChanged);
            candidatecb.SelectedIndexChanged += new EventHandler(candidatecb_SelectedIndexChanged);
        }

        SqlConnection Con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True");

        private void GetSubjects()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select SName from SubjectTbl", Con);
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
            SqlCommand cmd = new SqlCommand("select username from employees", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("username", typeof(string));
            dt.Load(rdr);
            candidatecb.ValueMember = "username";
            candidatecb.DataSource = dt;
            Con.Close();
        }

        private void DisplayProgression()
        {
            Con.Open();
            String Query = "SELECT e.username, ep.SubjectId, s.SName, c.ContentTitle " +
                           "FROM EmployeeProgression ep " +
                           "INNER JOIN employees e ON ep.EmployeeId = e.id " +
                           "INNER JOIN SubjectTbl s ON ep.SubjectId = s.SId " +
                           "LEFT JOIN (" +
                           "  SELECT ContentId, ContentTitle " +
                           "  FROM ContentTbl " +
                           ") AS c ON c.ContentId IN (SELECT value FROM STRING_SPLIT(NULLIF(ep.ViewedContents, ''), ','))";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            progressionTable = ds.Tables[0]; // store the original table
            progressionDGV.DataSource = progressionTable;
            progressionDGV.Columns[0].HeaderText = "Employee Username";
            progressionDGV.Columns[2].HeaderText = "Subject Name";
            progressionDGV.Columns[3].HeaderText = "Viewed Content";
            progressionDGV.Columns["SubjectId"].Visible = false; // hide the "Subject ID" column
            Con.Close();
        }

        private void FilterBySub()
        {
            if (progressionTable == null)
            {
                // If the table is null, do nothing
                return;
            }

            DataView dv = progressionTable.DefaultView;
            dv.RowFilter = string.Format("SName LIKE '%{0}%'", subjectcb.Text);
            progressionDGV.DataSource = dv.ToTable();
        }

        private void FilterByCandidate()
        {
            if (progressionTable == null)
            {
                // If the table is null, do nothing
                return;
            }

            DataView dv = progressionTable.DefaultView;
            dv.RowFilter = string.Format("username LIKE '%{0}%'", candidatecb.Text);
            progressionDGV.DataSource = dv.ToTable();
        }

        private void subjectcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBySub();
        }

        private void candidatecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByCandidate();
        }
        private void viewProgressButton_Click(object sender, EventArgs e)
        {

        }
    }
}