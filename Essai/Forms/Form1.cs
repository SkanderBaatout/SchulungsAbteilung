using Essai.DataAccess;
using Essai.Forms;
using Essai.Utils.Classes;

namespace Essai
{
    public partial class Form1 : Form
    {
        private readonly string _connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";

        private EmployeeDataAccess _employeeDataAccess;
        private QuestionDataAccess _questionDataAccess;
        private UserDataAccess _userDataAccess;
        private SubjectDataAccess _subjectDataAccess;

        public int AdminId { get; set; }

        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            _employeeDataAccess = new EmployeeDataAccess();
            _questionDataAccess = new QuestionDataAccess(_connectionString);
            _userDataAccess = new UserDataAccess(_connectionString);
            _subjectDataAccess = new SubjectDataAccess(_connectionString);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            employeeCount();
            // Count and display the total number of questions
            int totalQuestions = _questionDataAccess.CountQuestions();
            label_questions.Text = $" {totalQuestions} Questions";
            // Count and display the total number of users
            int totalUsers = _userDataAccess.CountUsers();
            label_users.Text = $" {totalUsers} Users";
            int totalSubjects = _subjectDataAccess.CountSubjects();
            label_subjects.Text = $" {totalSubjects} Trainings";
        }

        private void employeeCount()
        {
            // Count and display the total number of employees
            int totalEmployees = _employeeDataAccess.CountEmployees();
            //Display values
            label_totalEmp.Text = $"Total Employees: {totalEmployees}";

            // Count and display the number of male employees
            int maleEmployees = _employeeDataAccess.CountMaleEmployees();
            label_maleEmp.Text = $"Male Employees: {maleEmployees}";

            // Count and display the number of female employees
            int femaleEmployees = _employeeDataAccess.CountFemaleEmployees();
            label_femaleEmp.Text = $"Female Employees: {femaleEmployees}";
        }
        private void customizeDesign()
        {
            panel_std_menu.Visible = false;
            panel_quiz_subMenu.Visible = false;
            panel_course_subMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panel_std_menu.Visible == true)
            {
                panel_std_menu.Visible = false;

            }
            if (panel_course_subMenu.Visible == true)
                panel_course_subMenu.Visible = false;
            if (panel_quiz_subMenu.Visible == true)
                panel_quiz_subMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_std_menu);
        }
        #region StdSubMenu
        private void button_registrtion_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());


            hideSubMenu();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            openChildForm(new EmployeeManagementForm());

            hideSubMenu();

        }



        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintEmployee());
            hideSubMenu();

        }
        #endregion StdSubMenu
        private void button_course_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_course_subMenu);
        }
        #region CourseSubMenu
        private void button_newcourse_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
            hideSubMenu();
        }

        private void button_manage_course_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());
            hideSubMenu();

        }

        private void button_courseprint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintCourseForm());
            hideSubMenu();

        }
        #endregion CourseSubMenu

        private void button_score_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel_quiz_subMenu);
        }
        #region ScoreSubMenu

        private void button_new_score_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ScoreForm());
            hideSubMenu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());

            hideSubMenu();
        }

        private void button_print_score_Click_1(object sender, EventArgs e)
        {
            openChildForm(new PrintScoreForm());
            hideSubMenu();
        }
        #endregion ScoreSubMenu

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

        private void button_exit_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewResults());

            hideSubMenu();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            panel_main.Controls.Add(panel_cover);
            employeeCount();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button_addQuestion_Click(object sender, EventArgs e)
        {
            openChildForm(new AddQuestionForm());

            hideSubMenu();
        }

        private void button_updateQuestion_Click(object sender, EventArgs e)
        {
            openChildForm(new UpdateQuestionForm());

            hideSubMenu();
        }

        private void button_consultQuestions_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewDeleteQuestionsForm());

            hideSubMenu();
        }

        private void button_plan_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_course_subMenu);
            PlanFormation form = new PlanFormation();
            form.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Candidats());

            hideSubMenu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Subjects());


        }

        private void button_plan_Click_1(object sender, EventArgs e)
        {
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void button_plan_formation_Click(object sender, EventArgs e)
        {
            openChildForm(new PlanFormation());

        }

        private void button_manage_trainings_Click(object sender, EventArgs e)
        {
            openChildForm(new Subjects());

        }

        private void Results_Click(object sender, EventArgs e)
        {

        }

        private void button_plan_formation_Click_1(object sender, EventArgs e)
        {
            openChildForm(new PlanFormation());
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel_quiz_subMenu);
        }

        private void button_dashboard_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            panel_main.Controls.Add(panel_cover);
            employeeCount();
        }

        private void Results_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void button_manage_trainings_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel_quiz_subMenu);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            openChildForm(new Subjects());
        }

        private void button_quizquestions_Click(object sender, EventArgs e)
        {
            openChildForm(new Questions());
        }

        private void button_subjects_Click(object sender, EventArgs e)
        {
            openChildForm(new Subjects());
        }

        private void button_quizquestions_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Questions());
        }

        private void button_results_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewResults());

            hideSubMenu();
        }

        private void button_plan_Click_2(object sender, EventArgs e)
        {
            openChildForm(new PlanFormation());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            panel_main.Controls.Add(panel_cover);
            employeeCount();
        }

        private void button_galery_Click(object sender, EventArgs e)
        {
            openChildForm(new GalleryForm("admin", this.AdminId, true));
        }

        private void btn_examResults_Click(object sender, EventArgs e)
        {
            openChildForm(new ExamResults());
        }

        private void trainingProgressionbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ProgressForm());
        }
    }
}