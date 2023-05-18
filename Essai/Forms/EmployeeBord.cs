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

namespace Essai
{
    public partial class EmployeeBord : Form
    {
        public static string trainingName = "";
        public static string testName = "";
        public EmployeeBord()
        {
            InitializeComponent();
            GetSubjects();
            GetTests();
            Trainingscb.SelectedIndexChanged += Trainingscb_SelectedIndexChanged;
            comboBox_Tests.SelectedIndexChanged += comboBox_Tests_SelectedIndexChanged;



        }
        //to show register form in mainForm
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            { activeForm.Close(); }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
        private void GetTests()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select name from TestsType  ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Load(rdr);
            comboBox_Tests.ValueMember = "name";
            comboBox_Tests.DataSource = dt;
            Con.Close();
        }

        private void EmployeeBord_Load(object sender, EventArgs e)
        {
            username.Text = LoginForm.username;
            trainingName = Trainingscb.SelectedValue.ToString();
            testName = comboBox_Tests.SelectedValue.ToString();
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
            openChildForm(new ProfileModificationForm(LoginForm.username, LoginForm.cin));
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            panel_main.Controls.Add(panel_cover);
        }

        private void button_followTraining_Click(object sender, EventArgs e)
        {
            openChildForm(new FollowSubjectForm());
        }

        private void button_exit_Click_2(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void Trainingscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            trainingName = Trainingscb.SelectedValue.ToString();
        }

        private void comboBox_Tests_SelectedIndexChanged(object sender, EventArgs e)
        {
            testName = comboBox_Tests.SelectedValue.ToString();

        }
    }
}
