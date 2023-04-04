namespace Essai
{
    public partial class Form1 : Form
    {
        EmployeeClass employee = new EmployeeClass();
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            employeeCount();
        }
        //create a function to display employee count
        private void employeeCount()
        {
            //Display values
            label_totalEmp.Text = "Total Employees : " + employee.totalEmployees();
            label_maleEmp.Text = "Male : " + employee.maleEmployees();
            label_femaleEmp.Text = "Female : " + employee.femaleEmployees();
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

            openChildForm(new ManageemployeeForm());

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
            employeeCount();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button_addQuestion_Click(object sender, EventArgs e)
        {
            AddQuestionForm form = new AddQuestionForm();
            form.Show();
            this.Hide();
            hideSubMenu();
        }

        private void button_updateQuestion_Click(object sender, EventArgs e)
        {
            UpdateQuestionForm form = new UpdateQuestionForm();
            form.Show();
            this.Hide();
            hideSubMenu();
        }

        private void button_consultQuestions_Click(object sender, EventArgs e)
        {
            ViewDeleteQuestionsForm form = new ViewDeleteQuestionsForm();
            form.Show();
            this.Hide();
            hideSubMenu();
        }

        private void button_plan_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_course_subMenu);
            PlanFormation form = new PlanFormation();
            form.Show();
            this.Hide();

        }
    }
}