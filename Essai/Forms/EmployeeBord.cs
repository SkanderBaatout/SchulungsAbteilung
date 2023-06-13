using Essai.Forms;
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
        private List<string> quotes;
        public int EmployeeId { get; set; }

        public EmployeeBord()
        {
            InitializeComponent();
            LoadQuotes();
            GetSubjects();
            GetTests();
            Trainingscb.SelectedIndexChanged += Trainingscb_SelectedIndexChanged;
            comboBox_Tests.SelectedIndexChanged += comboBox_Tests_SelectedIndexChanged;
            button_planformation.Click += button_planformation_Click;

            // Display a random quote
            Random rnd = new Random();
            int quoteIndex = rnd.Next(quotes.Count);
            label_quote.Text = quotes[quoteIndex];


        }
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
        private void LoadQuotes()
        {
            string[] lines = File.ReadAllLines("quotes.txt");
            quotes = new List<string>(lines);
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
        private void Trainingscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            trainingName = Trainingscb.SelectedValue.ToString();

        }
        private void button_course_Click(object sender, EventArgs e)
        {
            // Check if there are questions for the selected training
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM QuestionTbl WHERE QS=@trainingName", Con);
            cmd.Parameters.AddWithValue("@trainingName", trainingName);
            Con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            Con.Close();

            if (count > 0)
            {
                Exams ex = new Exams();
                this.Hide();
                ex.Show();
            }
            else
            {
                MessageBox.Show("There are no questions available for the selected training.");
            }
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



        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            panel_main.Controls.Add(panel_cover);
        }


        private void comboBox_Tests_SelectedIndexChanged(object sender, EventArgs e)
        {
            testName = comboBox_Tests.SelectedValue.ToString();

        }
        private void button_planformation_Click(object sender, EventArgs e)
        {
            string selectedTestType = comboBox_Tests.SelectedValue.ToString();

            Con.Open();
            SqlCommand cmd = new SqlCommand("select PlanData, PlanName from Plans where TestTypeId = (select TestTypeId from TestsType where name = @testType) and PlanData is not null", Con);
            cmd.Parameters.AddWithValue("@testType", selectedTestType);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Tuple<byte[], string>> planList = new List<Tuple<byte[], string>>();
            while (reader.Read())
            {
                byte[] planData = (byte[])reader["PlanData"];
                string planName = (string)reader["PlanName"];
                planList.Add(new Tuple<byte[], string>(planData, planName));
            }
            Con.Close();

            if (planList.Any())
            {
                string selectedPlanName = "Plan de formation " + selectedTestType;
                var matchingPlans = planList.Where(p => p.Item2 == selectedPlanName).ToList();
                if (matchingPlans.Any())
                {
                    Console.WriteLine("Plan data retrieved for test type {0} and plan name {1}", selectedTestType, selectedPlanName);

                    openChildForm(new SuivrePlanFormation(matchingPlans.First().Item1));
                }
                else
                {
                    MessageBox.Show("There is no plan available with the selected plan name for the selected test type.", "No PlanFound", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("There is no plan available for the selected test type.", "No PlanFound", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_exit_Click_3(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void button_followTraining_Click(object sender, EventArgs e)
        {
            openChildForm(new GalleryForm("employee",this.EmployeeId,false));
        }
    }
}
