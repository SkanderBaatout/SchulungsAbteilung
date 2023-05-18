namespace Essai
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            textBox_username = new TextBox();
            textBox_password = new TextBox();
            button_login = new Button();
            label_username = new Label();
            label_password = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label5 = new Label();
            label_title = new Label();
            comboBox_selectUser = new ComboBox();
            panel_admin = new Panel();
            checkBox_showPass = new CheckBox();
            panel_Employee = new Panel();
            textBox_cin = new TextBox();
            label_cin = new Label();
            checkBox_showpassEmp = new CheckBox();
            textBox_emp_username = new TextBox();
            textBox_emp_pass = new TextBox();
            label_emp_username = new Label();
            label_emp_pass = new Label();
            button_employee_login = new Button();
            button_employee_register = new Button();
            label9 = new Label();
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_admin.SuspendLayout();
            panel_Employee.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 56);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(900, 9);
            label6.Name = "label6";
            label6.Size = new Size(35, 36);
            label6.TabIndex = 2;
            label6.Text = "X";
            label6.Click += label6_Click;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(91, 19);
            label1.Name = "label1";
            label1.Size = new Size(221, 19);
            label1.TabIndex = 1;
            label1.Text = "Draxlmaier Training Service";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(355, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 138);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(182, 27);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 2;
            label2.Text = "Admin Login";
            // 
            // textBox_username
            // 
            textBox_username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_username.Location = new Point(125, 86);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(280, 27);
            textBox_username.TabIndex = 3;
            textBox_username.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_password.Location = new Point(125, 141);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(280, 27);
            textBox_password.TabIndex = 4;
            textBox_password.TextAlign = HorizontalAlignment.Center;
            // 
            // button_login
            // 
            button_login.BackColor = Color.Teal;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(182, 201);
            button_login.Name = "button_login";
            button_login.Size = new Size(181, 41);
            button_login.TabIndex = 5;
            button_login.Text = "LOGIN";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_username.ForeColor = Color.Teal;
            label_username.Location = new Point(17, 86);
            label_username.Name = "label_username";
            label_username.Size = new Size(102, 21);
            label_username.TabIndex = 6;
            label_username.Text = "User Name :";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_password.ForeColor = Color.Teal;
            label_password.Location = new Point(29, 144);
            label_password.Name = "label_password";
            label_password.Size = new Size(90, 21);
            label_password.TabIndex = 7;
            label_password.Text = "Password :";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = button_login;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            guna2Elipse2.TargetControl = pictureBox2;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 15;
            guna2Elipse3.TargetControl = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(640, 620);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(295, 21);
            label5.TabIndex = 8;
            label5.Text = " @Copy Right Draxlmaier El Jem 2023";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_title.ForeColor = Color.Teal;
            label_title.Location = new Point(371, 215);
            label_title.Name = "label_title";
            label_title.Size = new Size(194, 25);
            label_title.TabIndex = 9;
            label_title.Text = "Select User Type  :";
            // 
            // comboBox_selectUser
            // 
            comboBox_selectUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox_selectUser.ForeColor = Color.Teal;
            comboBox_selectUser.FormattingEnabled = true;
            comboBox_selectUser.Items.AddRange(new object[] { "Admin", "Employee" });
            comboBox_selectUser.Location = new Point(329, 247);
            comboBox_selectUser.Name = "comboBox_selectUser";
            comboBox_selectUser.Size = new Size(289, 27);
            comboBox_selectUser.TabIndex = 10;
            comboBox_selectUser.SelectedIndexChanged += comboBox_selectUser_SelectedIndexChanged;
            // 
            // panel_admin
            // 
            panel_admin.Controls.Add(checkBox_showPass);
            panel_admin.Controls.Add(textBox_username);
            panel_admin.Controls.Add(textBox_password);
            panel_admin.Controls.Add(button_login);
            panel_admin.Controls.Add(label_username);
            panel_admin.Controls.Add(label2);
            panel_admin.Controls.Add(label_password);
            panel_admin.Location = new Point(213, 291);
            panel_admin.Name = "panel_admin";
            panel_admin.Size = new Size(504, 286);
            panel_admin.TabIndex = 11;
            // 
            // checkBox_showPass
            // 
            checkBox_showPass.AutoSize = true;
            checkBox_showPass.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_showPass.ForeColor = Color.Teal;
            checkBox_showPass.Location = new Point(127, 174);
            checkBox_showPass.Name = "checkBox_showPass";
            checkBox_showPass.Size = new Size(127, 21);
            checkBox_showPass.TabIndex = 8;
            checkBox_showPass.Text = "Show Password";
            checkBox_showPass.UseVisualStyleBackColor = true;
            checkBox_showPass.CheckedChanged += checkBox_showPass_CheckedChanged;
            // 
            // panel_Employee
            // 
            panel_Employee.Controls.Add(textBox_cin);
            panel_Employee.Controls.Add(label_cin);
            panel_Employee.Controls.Add(checkBox_showpassEmp);
            panel_Employee.Controls.Add(textBox_emp_username);
            panel_Employee.Controls.Add(textBox_emp_pass);
            panel_Employee.Controls.Add(label_emp_username);
            panel_Employee.Controls.Add(label_emp_pass);
            panel_Employee.Controls.Add(button_employee_login);
            panel_Employee.Controls.Add(button_employee_register);
            panel_Employee.Controls.Add(label9);
            panel_Employee.Location = new Point(216, 280);
            panel_Employee.Name = "panel_Employee";
            panel_Employee.Size = new Size(493, 323);
            panel_Employee.TabIndex = 12;
            // 
            // textBox_cin
            // 
            textBox_cin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_cin.Location = new Point(118, 177);
            textBox_cin.Name = "textBox_cin";
            textBox_cin.Size = new Size(298, 27);
            textBox_cin.TabIndex = 11;
            textBox_cin.TextAlign = HorizontalAlignment.Center;
            // 
            // label_cin
            // 
            label_cin.AutoSize = true;
            label_cin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_cin.ForeColor = Color.Teal;
            label_cin.Location = new Point(64, 175);
            label_cin.Name = "label_cin";
            label_cin.Size = new Size(48, 21);
            label_cin.TabIndex = 15;
            label_cin.Text = "CIN :";
            // 
            // checkBox_showpassEmp
            // 
            checkBox_showpassEmp.AutoSize = true;
            checkBox_showpassEmp.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_showpassEmp.ForeColor = Color.Teal;
            checkBox_showpassEmp.Location = new Point(129, 150);
            checkBox_showpassEmp.Name = "checkBox_showpassEmp";
            checkBox_showpassEmp.Size = new Size(127, 21);
            checkBox_showpassEmp.TabIndex = 13;
            checkBox_showpassEmp.Text = "Show Password";
            checkBox_showpassEmp.UseVisualStyleBackColor = true;
            checkBox_showpassEmp.CheckedChanged += checkBox_showpassEmp_CheckedChanged;
            // 
            // textBox_emp_username
            // 
            textBox_emp_username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_emp_username.Location = new Point(118, 70);
            textBox_emp_username.Name = "textBox_emp_username";
            textBox_emp_username.Size = new Size(298, 27);
            textBox_emp_username.TabIndex = 9;
            textBox_emp_username.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_emp_pass
            // 
            textBox_emp_pass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_emp_pass.Location = new Point(118, 117);
            textBox_emp_pass.Name = "textBox_emp_pass";
            textBox_emp_pass.PasswordChar = '*';
            textBox_emp_pass.Size = new Size(298, 27);
            textBox_emp_pass.TabIndex = 10;
            textBox_emp_pass.TextAlign = HorizontalAlignment.Center;
            // 
            // label_emp_username
            // 
            label_emp_username.AutoSize = true;
            label_emp_username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_emp_username.ForeColor = Color.Teal;
            label_emp_username.Location = new Point(10, 72);
            label_emp_username.Name = "label_emp_username";
            label_emp_username.Size = new Size(102, 21);
            label_emp_username.TabIndex = 11;
            label_emp_username.Text = "User Name :";
            // 
            // label_emp_pass
            // 
            label_emp_pass.AutoSize = true;
            label_emp_pass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_emp_pass.ForeColor = Color.Teal;
            label_emp_pass.Location = new Point(22, 122);
            label_emp_pass.Name = "label_emp_pass";
            label_emp_pass.Size = new Size(90, 21);
            label_emp_pass.TabIndex = 12;
            label_emp_pass.Text = "Password :";
            // 
            // button_employee_login
            // 
            button_employee_login.BackColor = Color.Teal;
            button_employee_login.FlatStyle = FlatStyle.Flat;
            button_employee_login.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_employee_login.ForeColor = Color.White;
            button_employee_login.Location = new Point(158, 225);
            button_employee_login.Name = "button_employee_login";
            button_employee_login.Size = new Size(209, 41);
            button_employee_login.TabIndex = 7;
            button_employee_login.Text = "LOGIN";
            button_employee_login.UseVisualStyleBackColor = false;
            button_employee_login.Click += button_employee_login_Click;
            // 
            // button_employee_register
            // 
            button_employee_register.BackColor = Color.Teal;
            button_employee_register.FlatStyle = FlatStyle.Flat;
            button_employee_register.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_employee_register.ForeColor = Color.White;
            button_employee_register.Location = new Point(158, 272);
            button_employee_register.Name = "button_employee_register";
            button_employee_register.Size = new Size(209, 41);
            button_employee_register.TabIndex = 5;
            button_employee_register.Text = "REGISTER";
            button_employee_register.UseVisualStyleBackColor = false;
            button_employee_register.Click += button_employee_register_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(169, 24);
            label9.Name = "label9";
            label9.Size = new Size(173, 25);
            label9.TabIndex = 2;
            label9.Text = "Employee Login";
            // 
            // guna2Elipse5
            // 
            guna2Elipse5.BorderRadius = 15;
            guna2Elipse5.TargetControl = button_employee_login;
            // 
            // guna2Elipse6
            // 
            guna2Elipse6.BorderRadius = 15;
            guna2Elipse6.TargetControl = button_employee_register;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(panel_Employee);
            Controls.Add(panel_admin);
            Controls.Add(comboBox_selectUser);
            Controls.Add(label_title);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_admin.ResumeLayout(false);
            panel_admin.PerformLayout();
            panel_Employee.ResumeLayout(false);
            panel_Employee.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private Button button_login;
        private Label label_username;
        private Label label_password;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Label label5;
        private Label label6;
        private ComboBox comboBox_selectUser;
        private Label label_title;
        private Panel panel_admin;
        private CheckBox checkBox_showPass;
        private Panel panel_Employee;
        private Button button_employee_login;
        private Button button_employee_register;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private CheckBox checkBox_showpassEmp;
        private TextBox textBox_emp_username;
        private TextBox textBox_emp_pass;
        private Label label_emp_username;
        private Label label_emp_pass;
        private TextBox textBox_cin;
        private Label label_cin;
    }
}