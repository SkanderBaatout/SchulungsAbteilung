﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai
{
    public partial class EmployeeBord : Form
    {
        public static string trainingName = "";

        public EmployeeBord()
        {
            InitializeComponent();
            GetSubjects();

            

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
            Trainingscb.ValueMember = "SName";
            Trainingscb.DataSource = dt;
            Con.Close();
        }

        private void EmployeeBord_Load(object sender, EventArgs e)
        {
            username.Text = LoginForm.username;
            trainingName = Trainingscb.SelectedValue.ToString();
        }

        private void button_questions_Click(object sender, EventArgs e)
        {
            Quiz form = new Quiz();
            form.Show();
            this.Hide();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void button_plan_Click(object sender, EventArgs e)
        {

        }

        private void button_course_Click(object sender, EventArgs e)
        {
            Exams ex = new Exams();
            this.Hide();
            ex.Show();
        }

        private void button_score_Click(object sender, EventArgs e)
        {
            Subjects sub = new Subjects();
            this.Hide();
            sub.Show();
        }

        private void my_profile_Click(object sender, EventArgs e)
        {
            ProfileModificationForm profileModificationForm = new ProfileModificationForm(LoginForm.username, LoginForm.cin);
            profileModificationForm.ShowDialog();
        }
    }
}
