namespace Essai
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel_slide = new Panel();
            button_exit = new Button();
            button_dashboard = new Button();
            panel_score_subMenu = new Panel();
            button_print_score = new Button();
            button2 = new Button();
            button_new_score = new Button();
            button_score = new Button();
            panel_course_subMenu = new Panel();
            button_plan = new Button();
            button_consultQuestions = new Button();
            button_updateQuestion = new Button();
            button_addQuestion = new Button();
            button_questions = new Button();
            button_courseprint = new Button();
            button_manage_course = new Button();
            button_newcourse = new Button();
            button_course = new Button();
            panel_std_menu = new Panel();
            button_stdprint = new Button();
            button_manage_std = new Button();
            button_registrtion = new Button();
            button_std = new Button();
            panel_logo = new Panel();
            label2 = new Label();
            panel_main = new Panel();
            panel_cover = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label11 = new Label();
            comboBox1 = new ComboBox();
            label_femaleEmp = new Label();
            label_maleEmp = new Label();
            label_totalEmp = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label12 = new Label();
            panel_slide.SuspendLayout();
            panel_score_subMenu.SuspendLayout();
            panel_course_subMenu.SuspendLayout();
            panel_std_menu.SuspendLayout();
            panel_logo.SuspendLayout();
            panel_main.SuspendLayout();
            panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = Color.Teal;
            panel_slide.Controls.Add(button_exit);
            panel_slide.Controls.Add(button_dashboard);
            panel_slide.Controls.Add(panel_score_subMenu);
            panel_slide.Controls.Add(button_score);
            panel_slide.Controls.Add(panel_course_subMenu);
            panel_slide.Controls.Add(button_course);
            panel_slide.Controls.Add(panel_std_menu);
            panel_slide.Controls.Add(button_std);
            panel_slide.Controls.Add(panel_logo);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.Location = new Point(0, 0);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(200, 686);
            panel_slide.TabIndex = 0;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.Teal;
            button_exit.Dock = DockStyle.Top;
            button_exit.FlatAppearance.BorderSize = 0;
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_exit.ForeColor = Color.White;
            button_exit.Location = new Point(0, 862);
            button_exit.Name = "button_exit";
            button_exit.Padding = new Padding(10, 0, 0, 0);
            button_exit.Size = new Size(183, 37);
            button_exit.TabIndex = 8;
            button_exit.Text = "Exit";
            button_exit.TextAlign = ContentAlignment.MiddleLeft;
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // button_dashboard
            // 
            button_dashboard.BackColor = Color.Teal;
            button_dashboard.Dock = DockStyle.Top;
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_dashboard.ForeColor = Color.White;
            button_dashboard.Location = new Point(0, 825);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Padding = new Padding(10, 0, 0, 0);
            button_dashboard.Size = new Size(183, 37);
            button_dashboard.TabIndex = 7;
            button_dashboard.Text = "Dashboard";
            button_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_dashboard.UseVisualStyleBackColor = false;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // panel_score_subMenu
            // 
            panel_score_subMenu.BackColor = Color.DarkCyan;
            panel_score_subMenu.Controls.Add(button_print_score);
            panel_score_subMenu.Controls.Add(button2);
            panel_score_subMenu.Controls.Add(button_new_score);
            panel_score_subMenu.Dock = DockStyle.Top;
            panel_score_subMenu.Location = new Point(0, 686);
            panel_score_subMenu.Name = "panel_score_subMenu";
            panel_score_subMenu.Size = new Size(183, 139);
            panel_score_subMenu.TabIndex = 6;
            // 
            // button_print_score
            // 
            button_print_score.Dock = DockStyle.Top;
            button_print_score.FlatAppearance.BorderSize = 0;
            button_print_score.FlatStyle = FlatStyle.Flat;
            button_print_score.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_print_score.ForeColor = Color.White;
            button_print_score.Location = new Point(0, 88);
            button_print_score.Name = "button_print_score";
            button_print_score.Padding = new Padding(35, 0, 0, 0);
            button_print_score.Size = new Size(183, 38);
            button_print_score.TabIndex = 3;
            button_print_score.Text = "Print";
            button_print_score.TextAlign = ContentAlignment.MiddleLeft;
            button_print_score.UseVisualStyleBackColor = true;
            button_print_score.Click += button_print_score_Click_1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 44);
            button2.Name = "button2";
            button2.Padding = new Padding(35, 0, 0, 0);
            button2.Size = new Size(183, 44);
            button2.TabIndex = 1;
            button2.Text = "Manage Score";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button_new_score
            // 
            button_new_score.Dock = DockStyle.Top;
            button_new_score.FlatAppearance.BorderSize = 0;
            button_new_score.FlatStyle = FlatStyle.Flat;
            button_new_score.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_new_score.ForeColor = Color.White;
            button_new_score.Location = new Point(0, 0);
            button_new_score.Name = "button_new_score";
            button_new_score.Padding = new Padding(35, 0, 0, 0);
            button_new_score.Size = new Size(183, 44);
            button_new_score.TabIndex = 0;
            button_new_score.Text = "New Score";
            button_new_score.TextAlign = ContentAlignment.MiddleLeft;
            button_new_score.UseVisualStyleBackColor = true;
            button_new_score.Click += button_new_score_Click_1;
            // 
            // button_score
            // 
            button_score.BackColor = Color.Teal;
            button_score.Dock = DockStyle.Top;
            button_score.FlatAppearance.BorderSize = 0;
            button_score.FlatStyle = FlatStyle.Flat;
            button_score.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_score.ForeColor = Color.White;
            button_score.Location = new Point(0, 649);
            button_score.Name = "button_score";
            button_score.Padding = new Padding(10, 0, 0, 0);
            button_score.Size = new Size(183, 37);
            button_score.TabIndex = 5;
            button_score.Text = "Score";
            button_score.TextAlign = ContentAlignment.MiddleLeft;
            button_score.UseVisualStyleBackColor = false;
            button_score.Click += button_score_Click_1;
            // 
            // panel_course_subMenu
            // 
            panel_course_subMenu.BackColor = Color.DarkCyan;
            panel_course_subMenu.Controls.Add(button_plan);
            panel_course_subMenu.Controls.Add(button_consultQuestions);
            panel_course_subMenu.Controls.Add(button_updateQuestion);
            panel_course_subMenu.Controls.Add(button_addQuestion);
            panel_course_subMenu.Controls.Add(button_questions);
            panel_course_subMenu.Controls.Add(button_courseprint);
            panel_course_subMenu.Controls.Add(button_manage_course);
            panel_course_subMenu.Controls.Add(button_newcourse);
            panel_course_subMenu.Dock = DockStyle.Top;
            panel_course_subMenu.Location = new Point(0, 309);
            panel_course_subMenu.Name = "panel_course_subMenu";
            panel_course_subMenu.Size = new Size(183, 340);
            panel_course_subMenu.TabIndex = 4;
            // 
            // button_plan
            // 
            button_plan.BackColor = Color.Teal;
            button_plan.Dock = DockStyle.Top;
            button_plan.FlatAppearance.BorderSize = 0;
            button_plan.FlatStyle = FlatStyle.Flat;
            button_plan.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_plan.ForeColor = Color.White;
            button_plan.Location = new Point(0, 303);
            button_plan.Name = "button_plan";
            button_plan.Padding = new Padding(10, 0, 0, 0);
            button_plan.Size = new Size(183, 37);
            button_plan.TabIndex = 12;
            button_plan.Text = "Plan de Formation";
            button_plan.TextAlign = ContentAlignment.MiddleLeft;
            button_plan.UseVisualStyleBackColor = false;
            button_plan.Click += button_plan_Click;
            // 
            // button_consultQuestions
            // 
            button_consultQuestions.Dock = DockStyle.Top;
            button_consultQuestions.FlatAppearance.BorderSize = 0;
            button_consultQuestions.FlatStyle = FlatStyle.Flat;
            button_consultQuestions.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_consultQuestions.ForeColor = Color.White;
            button_consultQuestions.Location = new Point(0, 259);
            button_consultQuestions.Name = "button_consultQuestions";
            button_consultQuestions.Padding = new Padding(35, 0, 0, 0);
            button_consultQuestions.Size = new Size(183, 44);
            button_consultQuestions.TabIndex = 11;
            button_consultQuestions.Text = "View and Delete Questions";
            button_consultQuestions.TextAlign = ContentAlignment.MiddleLeft;
            button_consultQuestions.UseVisualStyleBackColor = true;
            button_consultQuestions.Click += button_consultQuestions_Click;
            // 
            // button_updateQuestion
            // 
            button_updateQuestion.Dock = DockStyle.Top;
            button_updateQuestion.FlatAppearance.BorderSize = 0;
            button_updateQuestion.FlatStyle = FlatStyle.Flat;
            button_updateQuestion.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_updateQuestion.ForeColor = Color.White;
            button_updateQuestion.Location = new Point(0, 215);
            button_updateQuestion.Name = "button_updateQuestion";
            button_updateQuestion.Padding = new Padding(35, 0, 0, 0);
            button_updateQuestion.Size = new Size(183, 44);
            button_updateQuestion.TabIndex = 9;
            button_updateQuestion.Text = "Update Question";
            button_updateQuestion.TextAlign = ContentAlignment.MiddleLeft;
            button_updateQuestion.UseVisualStyleBackColor = true;
            button_updateQuestion.Click += button_updateQuestion_Click;
            // 
            // button_addQuestion
            // 
            button_addQuestion.Dock = DockStyle.Top;
            button_addQuestion.FlatAppearance.BorderSize = 0;
            button_addQuestion.FlatStyle = FlatStyle.Flat;
            button_addQuestion.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_addQuestion.ForeColor = Color.White;
            button_addQuestion.Location = new Point(0, 171);
            button_addQuestion.Name = "button_addQuestion";
            button_addQuestion.Padding = new Padding(35, 0, 0, 0);
            button_addQuestion.Size = new Size(183, 44);
            button_addQuestion.TabIndex = 8;
            button_addQuestion.Text = "Add New Question";
            button_addQuestion.TextAlign = ContentAlignment.MiddleLeft;
            button_addQuestion.UseVisualStyleBackColor = true;
            button_addQuestion.Click += button_addQuestion_Click;
            // 
            // button_questions
            // 
            button_questions.BackColor = Color.Teal;
            button_questions.Dock = DockStyle.Top;
            button_questions.FlatAppearance.BorderSize = 0;
            button_questions.FlatStyle = FlatStyle.Flat;
            button_questions.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_questions.ForeColor = Color.White;
            button_questions.Location = new Point(0, 134);
            button_questions.Name = "button_questions";
            button_questions.Padding = new Padding(10, 0, 0, 0);
            button_questions.Size = new Size(183, 37);
            button_questions.TabIndex = 10;
            button_questions.Text = "Questions";
            button_questions.TextAlign = ContentAlignment.MiddleLeft;
            button_questions.UseVisualStyleBackColor = false;
            button_questions.Click += button4_Click_1;
            // 
            // button_courseprint
            // 
            button_courseprint.Dock = DockStyle.Top;
            button_courseprint.FlatAppearance.BorderSize = 0;
            button_courseprint.FlatStyle = FlatStyle.Flat;
            button_courseprint.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_courseprint.ForeColor = Color.White;
            button_courseprint.Location = new Point(0, 88);
            button_courseprint.Name = "button_courseprint";
            button_courseprint.Padding = new Padding(35, 0, 0, 0);
            button_courseprint.Size = new Size(183, 46);
            button_courseprint.TabIndex = 3;
            button_courseprint.Text = "Print";
            button_courseprint.TextAlign = ContentAlignment.MiddleLeft;
            button_courseprint.UseVisualStyleBackColor = true;
            button_courseprint.Click += button_courseprint_Click;
            // 
            // button_manage_course
            // 
            button_manage_course.Dock = DockStyle.Top;
            button_manage_course.FlatAppearance.BorderSize = 0;
            button_manage_course.FlatStyle = FlatStyle.Flat;
            button_manage_course.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_manage_course.ForeColor = Color.White;
            button_manage_course.Location = new Point(0, 44);
            button_manage_course.Name = "button_manage_course";
            button_manage_course.Padding = new Padding(35, 0, 0, 0);
            button_manage_course.Size = new Size(183, 44);
            button_manage_course.TabIndex = 1;
            button_manage_course.Text = "Manage Course";
            button_manage_course.TextAlign = ContentAlignment.MiddleLeft;
            button_manage_course.UseVisualStyleBackColor = true;
            button_manage_course.Click += button_manage_course_Click;
            // 
            // button_newcourse
            // 
            button_newcourse.Dock = DockStyle.Top;
            button_newcourse.FlatAppearance.BorderSize = 0;
            button_newcourse.FlatStyle = FlatStyle.Flat;
            button_newcourse.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_newcourse.ForeColor = Color.White;
            button_newcourse.Location = new Point(0, 0);
            button_newcourse.Name = "button_newcourse";
            button_newcourse.Padding = new Padding(35, 0, 0, 0);
            button_newcourse.Size = new Size(183, 44);
            button_newcourse.TabIndex = 0;
            button_newcourse.Text = "New Course";
            button_newcourse.TextAlign = ContentAlignment.MiddleLeft;
            button_newcourse.UseVisualStyleBackColor = true;
            button_newcourse.Click += button_newcourse_Click;
            // 
            // button_course
            // 
            button_course.BackColor = Color.Teal;
            button_course.Dock = DockStyle.Top;
            button_course.FlatAppearance.BorderSize = 0;
            button_course.FlatStyle = FlatStyle.Flat;
            button_course.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_course.ForeColor = Color.White;
            button_course.Location = new Point(0, 272);
            button_course.Name = "button_course";
            button_course.Padding = new Padding(10, 0, 0, 0);
            button_course.Size = new Size(183, 37);
            button_course.TabIndex = 3;
            button_course.Text = "Formation";
            button_course.TextAlign = ContentAlignment.MiddleLeft;
            button_course.UseVisualStyleBackColor = false;
            button_course.Click += button_course_Click;
            // 
            // panel_std_menu
            // 
            panel_std_menu.BackColor = Color.DarkCyan;
            panel_std_menu.Controls.Add(button_stdprint);
            panel_std_menu.Controls.Add(button_manage_std);
            panel_std_menu.Controls.Add(button_registrtion);
            panel_std_menu.Dock = DockStyle.Top;
            panel_std_menu.Location = new Point(0, 139);
            panel_std_menu.Name = "panel_std_menu";
            panel_std_menu.Size = new Size(183, 133);
            panel_std_menu.TabIndex = 2;
            // 
            // button_stdprint
            // 
            button_stdprint.Dock = DockStyle.Top;
            button_stdprint.FlatAppearance.BorderSize = 0;
            button_stdprint.FlatStyle = FlatStyle.Flat;
            button_stdprint.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_stdprint.ForeColor = Color.White;
            button_stdprint.Location = new Point(0, 88);
            button_stdprint.Name = "button_stdprint";
            button_stdprint.Padding = new Padding(35, 0, 0, 0);
            button_stdprint.Size = new Size(183, 45);
            button_stdprint.TabIndex = 3;
            button_stdprint.Text = "Print";
            button_stdprint.TextAlign = ContentAlignment.MiddleLeft;
            button_stdprint.UseVisualStyleBackColor = true;
            button_stdprint.Click += button4_Click;
            // 
            // button_manage_std
            // 
            button_manage_std.Dock = DockStyle.Top;
            button_manage_std.FlatAppearance.BorderSize = 0;
            button_manage_std.FlatStyle = FlatStyle.Flat;
            button_manage_std.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_manage_std.ForeColor = Color.White;
            button_manage_std.Location = new Point(0, 44);
            button_manage_std.Name = "button_manage_std";
            button_manage_std.Padding = new Padding(35, 0, 0, 0);
            button_manage_std.Size = new Size(183, 44);
            button_manage_std.TabIndex = 1;
            button_manage_std.Text = "Manage Employee";
            button_manage_std.TextAlign = ContentAlignment.MiddleLeft;
            button_manage_std.UseVisualStyleBackColor = true;
            button_manage_std.Click += button2_Click;
            // 
            // button_registrtion
            // 
            button_registrtion.Dock = DockStyle.Top;
            button_registrtion.FlatAppearance.BorderSize = 0;
            button_registrtion.FlatStyle = FlatStyle.Flat;
            button_registrtion.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_registrtion.ForeColor = Color.White;
            button_registrtion.Location = new Point(0, 0);
            button_registrtion.Name = "button_registrtion";
            button_registrtion.Padding = new Padding(35, 0, 0, 0);
            button_registrtion.Size = new Size(183, 44);
            button_registrtion.TabIndex = 0;
            button_registrtion.Text = "Registration";
            button_registrtion.TextAlign = ContentAlignment.MiddleLeft;
            button_registrtion.UseVisualStyleBackColor = true;
            button_registrtion.Click += button_registrtion_Click;
            // 
            // button_std
            // 
            button_std.BackColor = Color.Teal;
            button_std.Dock = DockStyle.Top;
            button_std.FlatAppearance.BorderSize = 0;
            button_std.FlatStyle = FlatStyle.Flat;
            button_std.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_std.ForeColor = Color.White;
            button_std.Location = new Point(0, 102);
            button_std.Name = "button_std";
            button_std.Padding = new Padding(10, 0, 0, 0);
            button_std.Size = new Size(183, 37);
            button_std.TabIndex = 1;
            button_std.Text = "Employee";
            button_std.TextAlign = ContentAlignment.MiddleLeft;
            button_std.UseVisualStyleBackColor = false;
            button_std.Click += button_std_Click;
            // 
            // panel_logo
            // 
            panel_logo.BackColor = Color.Teal;
            panel_logo.Controls.Add(label2);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(183, 102);
            panel_logo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(156, 24);
            label2.TabIndex = 1;
            label2.Text = "Draxlmaier";
            // 
            // panel_main
            // 
            panel_main.Controls.Add(panel_cover);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(200, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(934, 686);
            panel_main.TabIndex = 1;
            // 
            // panel_cover
            // 
            panel_cover.Controls.Add(pictureBox2);
            panel_cover.Controls.Add(panel3);
            panel_cover.Controls.Add(panel2);
            panel_cover.Controls.Add(panel1);
            panel_cover.Dock = DockStyle.Fill;
            panel_cover.Location = new Point(0, 0);
            panel_cover.Name = "panel_cover";
            panel_cover.Size = new Size(934, 686);
            panel_cover.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(194, 201);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(560, 186);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label_femaleEmp);
            panel3.Controls.Add(label_maleEmp);
            panel3.Controls.Add(label_totalEmp);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 583);
            panel3.Name = "panel3";
            panel3.Size = new Size(934, 103);
            panel3.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(543, 32);
            label11.Name = "label11";
            label11.Size = new Size(131, 21);
            label11.TabIndex = 7;
            label11.Text = "Select Training :";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(680, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 23);
            comboBox1.TabIndex = 4;
            // 
            // label_femaleEmp
            // 
            label_femaleEmp.AutoSize = true;
            label_femaleEmp.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_femaleEmp.ForeColor = Color.White;
            label_femaleEmp.Location = new Point(164, 55);
            label_femaleEmp.Name = "label_femaleEmp";
            label_femaleEmp.Size = new Size(75, 21);
            label_femaleEmp.TabIndex = 3;
            label_femaleEmp.Text = "Female :";
            // 
            // label_maleEmp
            // 
            label_maleEmp.AutoSize = true;
            label_maleEmp.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_maleEmp.ForeColor = Color.White;
            label_maleEmp.Location = new Point(75, 55);
            label_maleEmp.Name = "label_maleEmp";
            label_maleEmp.Size = new Size(57, 21);
            label_maleEmp.TabIndex = 2;
            label_maleEmp.Text = "Male :";
            // 
            // label_totalEmp
            // 
            label_totalEmp.AutoSize = true;
            label_totalEmp.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_totalEmp.ForeColor = Color.White;
            label_totalEmp.Location = new Point(51, 18);
            label_totalEmp.Name = "label_totalEmp";
            label_totalEmp.Size = new Size(139, 21);
            label_totalEmp.TabIndex = 1;
            label_totalEmp.Text = "Total Employees:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 73);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(802, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(164, 46);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 3;
            label5.Text = "Admin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(164, 15);
            label4.Name = "label4";
            label4.Size = new Size(141, 21);
            label4.TabIndex = 2;
            label4.Text = "Lokmen ELHadhri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(75, 46);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 1;
            label3.Text = "Role:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 15);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 0;
            label1.Text = "Welcome :";
            // 
            // panel1
            // 
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 66);
            panel1.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(17, 29);
            label12.Name = "label12";
            label12.Size = new Size(312, 19);
            label12.TabIndex = 1;
            label12.Text = "SATE ElJEM Training Service Department";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 686);
            Controls.Add(panel_main);
            Controls.Add(panel_slide);
            MinimumSize = new Size(1150, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel_slide.ResumeLayout(false);
            panel_score_subMenu.ResumeLayout(false);
            panel_course_subMenu.ResumeLayout(false);
            panel_std_menu.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            panel_main.ResumeLayout(false);
            panel_cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_slide;
        private Button button_std;
        private Panel panel_logo;
        private Button button_course;
        private Panel panel_course_subMenu;
        private Button button_courseprint;
        private Button button_manage_course;
        private Button button_newcourse;
        private Panel panel_std_menu;
        private Button button_stdprint;
        private Button button_manage_std;
        private Button button_registrtion;
        private Button button_dashboard;
        private Panel panel_score_subMenu;
        private Button button_print_score;
        private Button button2;
        private Button button_new_score;
        private Button button_score;
        private Label label2;
        private Panel panel_main;
        private Panel panel_cover;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label_femaleEmp;
        private Label label_maleEmp;
        private Label label_totalEmp;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label11;
        private PictureBox pictureBox1;
        private Label label12;
        private Button button_exit;
        private Button button_consultQuestions;
        private Button button_updateQuestion;
        private Button button_addQuestion;
        private Button button_questions;
        private Button button_plan;
    }
}