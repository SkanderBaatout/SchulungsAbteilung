namespace Essai
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            button_goBack = new Button();
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel_admin = new Panel();
            textBox_cin = new TextBox();
            label3 = new Label();
            label_error = new Label();
            dateTimePicker = new DateTimePicker();
            comboBox_gender = new ComboBox();
            textBox_password = new TextBox();
            textBox_confirmPass = new TextBox();
            label11 = new Label();
            label12 = new Label();
            textBox_email = new TextBox();
            textBox_username = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox_mobile = new TextBox();
            button_register = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label6 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            label13 = new Label();
            panel_admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Elipse6
            // 
            guna2Elipse6.BorderRadius = 15;
            guna2Elipse6.TargetControl = button_goBack;
            // 
            // button_goBack
            // 
            button_goBack.BackColor = Color.Teal;
            button_goBack.FlatStyle = FlatStyle.Flat;
            button_goBack.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button_goBack.ForeColor = Color.White;
            button_goBack.Location = new Point(195, 444);
            button_goBack.Name = "button_goBack";
            button_goBack.Size = new Size(289, 44);
            button_goBack.TabIndex = 22;
            button_goBack.Text = "Go Back To Login Page";
            button_goBack.UseVisualStyleBackColor = false;
            button_goBack.Click += button_goBack_Click;
            // 
            // panel_admin
            // 
            panel_admin.Controls.Add(textBox_cin);
            panel_admin.Controls.Add(label3);
            panel_admin.Controls.Add(label_error);
            panel_admin.Controls.Add(button_goBack);
            panel_admin.Controls.Add(dateTimePicker);
            panel_admin.Controls.Add(comboBox_gender);
            panel_admin.Controls.Add(textBox_password);
            panel_admin.Controls.Add(textBox_confirmPass);
            panel_admin.Controls.Add(label11);
            panel_admin.Controls.Add(label12);
            panel_admin.Controls.Add(textBox_email);
            panel_admin.Controls.Add(textBox_username);
            panel_admin.Controls.Add(label9);
            panel_admin.Controls.Add(label10);
            panel_admin.Controls.Add(label7);
            panel_admin.Controls.Add(label8);
            panel_admin.Controls.Add(textBox_mobile);
            panel_admin.Controls.Add(button_register);
            panel_admin.Controls.Add(label2);
            panel_admin.Controls.Add(label4);
            panel_admin.Location = new Point(137, 131);
            panel_admin.Name = "panel_admin";
            panel_admin.Size = new Size(649, 491);
            panel_admin.TabIndex = 18;
            // 
            // textBox_cin
            // 
            textBox_cin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_cin.Location = new Point(195, 364);
            textBox_cin.Name = "textBox_cin";
            textBox_cin.Size = new Size(289, 27);
            textBox_cin.TabIndex = 8;
            textBox_cin.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(129, 364);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 25;
            label3.Text = "CIN :";
            // 
            // label_error
            // 
            label_error.AutoSize = true;
            label_error.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_error.ForeColor = Color.Red;
            label_error.Location = new Point(195, 160);
            label_error.Name = "label_error";
            label_error.Size = new Size(219, 21);
            label_error.TabIndex = 23;
            label_error.Text = "Password does not Match!!";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(195, 275);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(289, 27);
            dateTimePicker.TabIndex = 6;
            // 
            // comboBox_gender
            // 
            comboBox_gender.FormattingEnabled = true;
            comboBox_gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBox_gender.Location = new Point(195, 230);
            comboBox_gender.Name = "comboBox_gender";
            comboBox_gender.Size = new Size(197, 29);
            comboBox_gender.TabIndex = 5;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_password.Location = new Point(191, 88);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(288, 27);
            textBox_password.TabIndex = 2;
            textBox_password.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_confirmPass
            // 
            textBox_confirmPass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_confirmPass.Location = new Point(191, 130);
            textBox_confirmPass.Name = "textBox_confirmPass";
            textBox_confirmPass.PasswordChar = '*';
            textBox_confirmPass.Size = new Size(289, 27);
            textBox_confirmPass.TabIndex = 3;
            textBox_confirmPass.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(82, 88);
            label11.Name = "label11";
            label11.Size = new Size(90, 21);
            label11.TabIndex = 18;
            label11.Text = "Password :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(21, 133);
            label12.Name = "label12";
            label12.Size = new Size(155, 21);
            label12.TabIndex = 19;
            label12.Text = "Confirm Password :";
            // 
            // textBox_email
            // 
            textBox_email.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_email.Location = new Point(195, 318);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(289, 27);
            textBox_email.TabIndex = 7;
            textBox_email.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_username
            // 
            textBox_username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_username.Location = new Point(191, 45);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(289, 27);
            textBox_username.TabIndex = 1;
            textBox_username.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(113, 321);
            label9.Name = "label9";
            label9.Size = new Size(63, 21);
            label9.TabIndex = 14;
            label9.Text = "Email  :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(70, 48);
            label10.Name = "label10";
            label10.Size = new Size(102, 21);
            label10.TabIndex = 15;
            label10.Text = "User Name :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(95, 238);
            label7.Name = "label7";
            label7.Size = new Size(82, 21);
            label7.TabIndex = 10;
            label7.Text = "Gender  :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(90, 275);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 11;
            label8.Text = "Birthday  :";
            // 
            // textBox_mobile
            // 
            textBox_mobile.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_mobile.Location = new Point(195, 184);
            textBox_mobile.Name = "textBox_mobile";
            textBox_mobile.Size = new Size(289, 27);
            textBox_mobile.TabIndex = 4;
            textBox_mobile.TextAlign = HorizontalAlignment.Center;
            // 
            // button_register
            // 
            button_register.BackColor = Color.Teal;
            button_register.FlatStyle = FlatStyle.Flat;
            button_register.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_register.ForeColor = Color.White;
            button_register.Location = new Point(195, 397);
            button_register.Name = "button_register";
            button_register.Size = new Size(289, 41);
            button_register.TabIndex = 5;
            button_register.Text = "Create Account";
            button_register.UseVisualStyleBackColor = false;
            button_register.Click += button_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(223, 4);
            label2.Name = "label2";
            label2.Size = new Size(209, 25);
            label2.TabIndex = 2;
            label2.Text = "Create An Account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(105, 187);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 7;
            label4.Text = "Mobile :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(640, 625);
            label5.Name = "label5";
            label5.Size = new Size(295, 21);
            label5.TabIndex = 15;
            label5.Text = " @Copy Right Draxlmaier El Jem 2023";
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 15;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = button_register;
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
            // guna2Elipse5
            // 
            guna2Elipse5.BorderRadius = 15;
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
            panel1.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Enabled = false;
            label13.Font = new Font("Century Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonShadow;
            label13.Location = new Point(198, 71);
            label13.Name = "label13";
            label13.Size = new Size(585, 57);
            label13.TabIndex = 19;
            label13.Text = "WE CREATE CHARACTER";
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(label13);
            Controls.Add(panel_admin);
            Controls.Add(label5);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccount";
            Load += CreateAccount_Load;
            panel_admin.ResumeLayout(false);
            panel_admin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Panel panel_admin;
        private TextBox textBox_mobile;
        private Button button_register;
        private Label label2;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label6;
        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Panel panel1;
        private TextBox textBox_email;
        private TextBox textBox_username;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label8;
        private TextBox textBox_password;
        private TextBox textBox_confirmPass;
        private Label label11;
        private Label label12;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBox_gender;
        private Button button_goBack;
        private Label label13;
        private Label label_error;
        private TextBox textBox_cin;
        private Label label3;
    }
}