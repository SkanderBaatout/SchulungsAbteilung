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
            label3 = new Label();
            label4 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            pictureBox2.Location = new Point(355, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 153);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(381, 263);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 2;
            label2.Text = "Please Login First";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(324, 342);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(289, 23);
            textBox_username.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(324, 403);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(289, 23);
            textBox_password.TabIndex = 4;
            // 
            // button_login
            // 
            button_login.BackColor = Color.Teal;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_login.Location = new Point(324, 451);
            button_login.Name = "button_login";
            button_login.Size = new Size(289, 41);
            button_login.TabIndex = 5;
            button_login.Text = "LOGIN";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(324, 318);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 6;
            label3.Text = "User Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(324, 379);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 7;
            label4.Text = "Password :";
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
            label5.Size = new Size(295, 21);
            label5.TabIndex = 8;
            label5.Text = " @Copy Right Draxlmaier El Jem 2023";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button_login);
            Controls.Add(textBox_password);
            Controls.Add(textBox_username);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Label label5;
        private Label label6;
    }
}