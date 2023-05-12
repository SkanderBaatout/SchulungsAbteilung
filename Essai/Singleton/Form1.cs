using Essai.DataAccess;
using Essai.Utils.Classes;

namespace Essai
{
    public partial class Form1 : Form
    {
        EmployeeClass employee = new EmployeeClass();
        private EmployeeDataAccess _employeeDataAccess;
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            _employeeDataAccess = new EmployeeDataAccess();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            employeeCount();
        }
        //create a function to display employee count
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
            panel_score_subMenu.Visible = false;
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
            if (panel_score_subMenu.Visible == true)
                panel_score_subMenu.Visible = false;
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
            showSubMenu(panel_score_subMenu);
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
    }
}