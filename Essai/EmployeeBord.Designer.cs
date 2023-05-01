namespace Essai
{
    partial class EmployeeBord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeBord));
            panel_logo = new Panel();
            label2 = new Label();
            panel_main = new Panel();
            panel_cover = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label_femaleEmp = new Label();
            label_maleEmp = new Label();
            label_totalEmp = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            username = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label12 = new Label();
            panel_slide = new Panel();
            button_exit = new Button();
            button_dashboard = new Button();
            button_score = new Button();
            panel_course_subMenu = new Panel();
            button_questions = new Button();
            button_course = new Button();
            panel_logo.SuspendLayout();
            panel_main.SuspendLayout();
            panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel_slide.SuspendLayout();
            panel_course_subMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel_logo
            // 
            panel_logo.BackColor = Color.Teal;
            panel_logo.Controls.Add(label2);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(200, 102);
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
            panel_main.TabIndex = 3;
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
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(802, 67);
            label9.Name = "label9";
            label9.Size = new Size(75, 21);
            label9.TabIndex = 6;
            label9.Text = "Female :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(713, 67);
            label10.Name = "label10";
            label10.Size = new Size(57, 21);
            label10.TabIndex = 5;
            label10.Text = "Male :";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1414, 35);
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
            panel2.Controls.Add(username);
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
            pictureBox1.Location = new Point(1169, -16);
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
            label5.Size = new Size(86, 21);
            label5.TabIndex = 3;
            label5.Text = "Employee";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = Color.White;
            username.Location = new Point(164, 15);
            username.Name = "username";
            username.Size = new Size(138, 21);
            username.TabIndex = 2;
            username.Text = "Employee Name";
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
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = Color.Teal;
            panel_slide.Controls.Add(button_exit);
            panel_slide.Controls.Add(button_dashboard);
            panel_slide.Controls.Add(button_score);
            panel_slide.Controls.Add(panel_course_subMenu);
            panel_slide.Controls.Add(button_course);
            panel_slide.Controls.Add(panel_logo);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.Location = new Point(0, 0);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(200, 686);
            panel_slide.TabIndex = 2;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.Teal;
            button_exit.Dock = DockStyle.Top;
            button_exit.FlatAppearance.BorderSize = 0;
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_exit.ForeColor = Color.White;
            button_exit.Location = new Point(0, 253);
            button_exit.Name = "button_exit";
            button_exit.Padding = new Padding(10, 0, 0, 0);
            button_exit.Size = new Size(200, 37);
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
            button_dashboard.Location = new Point(0, 216);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Padding = new Padding(10, 0, 0, 0);
            button_dashboard.Size = new Size(200, 37);
            button_dashboard.TabIndex = 7;
            button_dashboard.Text = "Dashboard";
            button_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_dashboard.UseVisualStyleBackColor = false;
            // 
            // button_score
            // 
            button_score.BackColor = Color.Teal;
            button_score.Dock = DockStyle.Top;
            button_score.FlatAppearance.BorderSize = 0;
            button_score.FlatStyle = FlatStyle.Flat;
            button_score.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_score.ForeColor = Color.White;
            button_score.Location = new Point(0, 179);
            button_score.Name = "button_score";
            button_score.Padding = new Padding(10, 0, 0, 0);
            button_score.Size = new Size(200, 37);
            button_score.TabIndex = 5;
            button_score.Text = "Score";
            button_score.TextAlign = ContentAlignment.MiddleLeft;
            button_score.UseVisualStyleBackColor = false;
            button_score.Click += button_score_Click;
            // 
            // panel_course_subMenu
            // 
            panel_course_subMenu.BackColor = Color.DarkCyan;
            panel_course_subMenu.Controls.Add(button_questions);
            panel_course_subMenu.Dock = DockStyle.Top;
            panel_course_subMenu.Location = new Point(0, 139);
            panel_course_subMenu.Name = "panel_course_subMenu";
            panel_course_subMenu.Size = new Size(200, 40);
            panel_course_subMenu.TabIndex = 4;
            // 
            // button_questions
            // 
            button_questions.BackColor = Color.Teal;
            button_questions.Dock = DockStyle.Top;
            button_questions.FlatAppearance.BorderSize = 0;
            button_questions.FlatStyle = FlatStyle.Flat;
            button_questions.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_questions.ForeColor = Color.White;
            button_questions.Location = new Point(0, 0);
            button_questions.Name = "button_questions";
            button_questions.Padding = new Padding(10, 0, 0, 0);
            button_questions.Size = new Size(200, 37);
            button_questions.TabIndex = 10;
            button_questions.Text = "Exams";
            button_questions.TextAlign = ContentAlignment.MiddleLeft;
            button_questions.UseVisualStyleBackColor = false;
            button_questions.Click += button_questions_Click;
            // 
            // button_course
            // 
            button_course.BackColor = Color.Teal;
            button_course.Dock = DockStyle.Top;
            button_course.FlatAppearance.BorderSize = 0;
            button_course.FlatStyle = FlatStyle.Flat;
            button_course.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_course.ForeColor = Color.White;
            button_course.Location = new Point(0, 102);
            button_course.Name = "button_course";
            button_course.Padding = new Padding(10, 0, 0, 0);
            button_course.Size = new Size(200, 37);
            button_course.TabIndex = 3;
            button_course.Text = "Formations";
            button_course.TextAlign = ContentAlignment.MiddleLeft;
            button_course.UseVisualStyleBackColor = false;
            button_course.Click += button_course_Click;
            // 
            // EmployeeBord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 686);
            Controls.Add(panel_main);
            Controls.Add(panel_slide);
            MinimumSize = new Size(1150, 650);
            Name = "EmployeeBord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeBord";
            Load += EmployeeBord_Load;
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
            panel_slide.ResumeLayout(false);
            panel_course_subMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_logo;
        private Label label2;
        private Panel panel_main;
        private Panel panel_cover;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label11;
        private Label label9;
        private Label label10;
        private ComboBox comboBox1;
        private Label label_femaleEmp;
        private Label label_maleEmp;
        private Label label_totalEmp;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label username;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label12;
        private Panel panel_slide;
        private Button button_exit;
        private Button button_dashboard;
        private Button button_score;
        private Button button_course;
        private Panel panel_course_subMenu;
        private Button button_questions;
    }
}