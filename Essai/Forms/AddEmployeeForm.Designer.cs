namespace Essai
{
    partial class AddEmployeeForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            dtpBirthday = new DateTimePicker();
            label4 = new Label();
            panel_admin = new Panel();
            cbGender = new ComboBox();
            label1 = new Label();
            btnDeleteEmployee = new Guna.UI2.WinForms.Guna2Button();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            txtCin = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label11 = new Label();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            txtMobile = new TextBox();
            label2 = new Label();
            label13 = new Label();
            guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            pictureBox1 = new PictureBox();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel_admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse6
            // 
            guna2Elipse6.BorderRadius = 15;
            // 
            // dtpBirthday
            // 
            dtpBirthday.AllowDrop = true;
            dtpBirthday.CustomFormat = "yyyy-MM-dd";
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.Location = new Point(207, 291);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(289, 27);
            dtpBirthday.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(119, 243);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 7;
            label4.Text = "Mobile :";
            // 
            // panel_admin
            // 
            panel_admin.Controls.Add(cbGender);
            panel_admin.Controls.Add(label1);
            panel_admin.Controls.Add(btnDeleteEmployee);
            panel_admin.Controls.Add(btnAdd);
            panel_admin.Controls.Add(dtpBirthday);
            panel_admin.Controls.Add(txtCin);
            panel_admin.Controls.Add(label3);
            panel_admin.Controls.Add(txtPassword);
            panel_admin.Controls.Add(label11);
            panel_admin.Controls.Add(txtEmail);
            panel_admin.Controls.Add(txtUsername);
            panel_admin.Controls.Add(label9);
            panel_admin.Controls.Add(label10);
            panel_admin.Controls.Add(label8);
            panel_admin.Controls.Add(txtMobile);
            panel_admin.Controls.Add(label2);
            panel_admin.Controls.Add(label4);
            panel_admin.Location = new Point(134, 112);
            panel_admin.Name = "panel_admin";
            panel_admin.Size = new Size(649, 507);
            panel_admin.TabIndex = 45;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(208, 392);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(289, 29);
            cbGender.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(111, 400);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 70;
            label1.Text = "Gender :";
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BorderRadius = 15;
            btnDeleteEmployee.CustomizableEdges = customizableEdges1;
            btnDeleteEmployee.DialogResult = DialogResult.Cancel;
            btnDeleteEmployee.DisabledState.BorderColor = Color.DarkGray;
            btnDeleteEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeleteEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeleteEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeleteEmployee.Enabled = false;
            btnDeleteEmployee.FillColor = Color.OrangeRed;
            btnDeleteEmployee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteEmployee.ForeColor = Color.White;
            btnDeleteEmployee.Location = new Point(356, 445);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.PressedColor = Color.AntiqueWhite;
            btnDeleteEmployee.ShadowDecoration.BorderRadius = 15;
            btnDeleteEmployee.ShadowDecoration.Color = Color.Transparent;
            btnDeleteEmployee.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDeleteEmployee.Size = new Size(196, 45);
            btnDeleteEmployee.TabIndex = 69;
            btnDeleteEmployee.Text = "Cancel";
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 15;
            btnAdd.CustomizableEdges = customizableEdges3;
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.Teal;
            btnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(155, 445);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.BorderRadius = 15;
            btnAdd.ShadowDecoration.Color = Color.Transparent;
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdd.Size = new Size(195, 45);
            btnAdd.TabIndex = 68;
            btnAdd.Text = "Add Employee";
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCin
            // 
            txtCin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCin.Location = new Point(207, 342);
            txtCin.Name = "txtCin";
            txtCin.Size = new Size(289, 27);
            txtCin.TabIndex = 8;
            txtCin.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(141, 342);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 25;
            label3.Text = "CIN :";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(208, 132);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(288, 27);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(99, 132);
            label11.Name = "label11";
            label11.Size = new Size(90, 21);
            label11.TabIndex = 18;
            label11.Text = "Password :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(207, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(289, 27);
            txtEmail.TabIndex = 7;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(208, 82);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(289, 27);
            txtUsername.TabIndex = 1;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(125, 192);
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
            label10.Location = new Point(87, 85);
            label10.Name = "label10";
            label10.Size = new Size(102, 21);
            label10.TabIndex = 15;
            label10.Text = "User Name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(103, 290);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 11;
            label8.Text = "Birthday  :";
            // 
            // txtMobile
            // 
            txtMobile.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMobile.Location = new Point(207, 240);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(289, 27);
            txtMobile.TabIndex = 4;
            txtMobile.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(221, 13);
            label2.Name = "label2";
            label2.Size = new Size(247, 38);
            label2.TabIndex = 2;
            label2.Text = "Add Employee";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Enabled = false;
            label13.Font = new Font("Century Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonShadow;
            label13.Location = new Point(160, 21);
            label13.Name = "label13";
            label13.Size = new Size(585, 57);
            label13.TabIndex = 46;
            label13.Text = "WE CREATE CHARACTER";
            // 
            // guna2Elipse5
            // 
            guna2Elipse5.BorderRadius = 15;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 15;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(867, 650);
            Controls.Add(panel_admin);
            Controls.Add(label13);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AddEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEmployeeForm";
            panel_admin.ResumeLayout(false);
            panel_admin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private DateTimePicker dtpBirthday;
        private Label label4;
        private Panel panel_admin;
        private TextBox txtCin;
        private Label label3;
        private TextBox txtPassword;
        private Label label11;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private Label label9;
        private Label label10;
        private Label label8;
        private TextBox txtMobile;
        private Label label2;
        private Label label13;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnDeleteEmployee;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private ComboBox cbGender;
        private Label label1;
    }
}