namespace Essai
{
    partial class Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            btn_next = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label_nameEmp = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            label_question = new Label();
            label_totalQuestions = new Label();
            label_questionNo = new Label();
            label_idEmp = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_next
            // 
            btn_next.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_next.BorderRadius = 15;
            btn_next.CustomizableEdges = customizableEdges1;
            btn_next.DisabledState.BorderColor = Color.DarkGray;
            btn_next.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_next.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_next.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_next.FillColor = Color.Teal;
            btn_next.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_next.ForeColor = Color.White;
            btn_next.Location = new Point(738, 566);
            btn_next.Name = "btn_next";
            btn_next.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_next.Size = new Size(168, 45);
            btn_next.TabIndex = 40;
            btn_next.Text = "Next";
            btn_next.Click += btn_next_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(39, 64);
            label1.Name = "label1";
            label1.Size = new Size(158, 23);
            label1.TabIndex = 22;
            label1.Text = "Total Questions :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(39, 110);
            label9.Name = "label9";
            label9.Size = new Size(177, 23);
            label9.TabIndex = 44;
            label9.Text = "Question number :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(293, 110);
            label10.Name = "label10";
            label10.Size = new Size(33, 23);
            label10.TabIndex = 45;
            label10.Text = "ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(434, 110);
            label11.Name = "label11";
            label11.Size = new Size(72, 23);
            label11.TabIndex = 46;
            label11.Text = "Name:";
            // 
            // label_nameEmp
            // 
            label_nameEmp.AutoSize = true;
            label_nameEmp.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_nameEmp.ForeColor = Color.Black;
            label_nameEmp.Location = new Point(512, 110);
            label_nameEmp.Name = "label_nameEmp";
            label_nameEmp.Size = new Size(32, 23);
            label_nameEmp.TabIndex = 50;
            label_nameEmp.Text = "11";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Teal;
            label16.Location = new Point(599, 19);
            label16.Name = "label16";
            label16.Size = new Size(121, 23);
            label16.TabIndex = 51;
            label16.Text = "Exam Date :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Teal;
            label17.Location = new Point(608, 57);
            label17.Name = "label17";
            label17.Size = new Size(112, 23);
            label17.TabIndex = 52;
            label17.Text = "Total Time :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Teal;
            label18.Location = new Point(608, 110);
            label18.Name = "label18";
            label18.Size = new Size(167, 23);
            label18.TabIndex = 53;
            label18.Text = "Remaining Time :";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(187, 299);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(95, 25);
            radioButton1.TabIndex = 54;
            radioButton1.TabStop = true;
            radioButton1.Text = "Answer1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(187, 353);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 25);
            radioButton2.TabIndex = 55;
            radioButton2.TabStop = true;
            radioButton2.Text = "Answer2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(187, 403);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(95, 25);
            radioButton3.TabIndex = 56;
            radioButton3.TabStop = true;
            radioButton3.Text = "Answer3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(187, 454);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(95, 25);
            radioButton4.TabIndex = 57;
            radioButton4.TabStop = true;
            radioButton4.Text = "Answer4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(738, 16);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 58;
            // 
            // label_question
            // 
            label_question.AutoSize = true;
            label_question.Location = new Point(118, 240);
            label_question.Name = "label_question";
            label_question.Size = new Size(80, 21);
            label_question.TabIndex = 59;
            label_question.Text = "Question";
            // 
            // label_totalQuestions
            // 
            label_totalQuestions.AutoSize = true;
            label_totalQuestions.Location = new Point(218, 68);
            label_totalQuestions.Name = "label_totalQuestions";
            label_totalQuestions.Size = new Size(66, 21);
            label_totalQuestions.TabIndex = 60;
            label_totalQuestions.Text = "label15";
            // 
            // label_questionNo
            // 
            label_questionNo.AutoSize = true;
            label_questionNo.Location = new Point(222, 112);
            label_questionNo.Name = "label_questionNo";
            label_questionNo.Size = new Size(19, 21);
            label_questionNo.TabIndex = 61;
            label_questionNo.Text = "1";
            // 
            // label_idEmp
            // 
            label_idEmp.AutoSize = true;
            label_idEmp.Location = new Point(332, 112);
            label_idEmp.Name = "label_idEmp";
            label_idEmp.Size = new Size(66, 21);
            label_idEmp.TabIndex = 62;
            label_idEmp.Text = "label20";
            // 
            // Quiz
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 650);
            Controls.Add(label_idEmp);
            Controls.Add(label_questionNo);
            Controls.Add(label_totalQuestions);
            Controls.Add(label_question);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label_nameEmp);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(btn_next);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Quiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz";
            Load += Quiz_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_finish;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
        private Guna.UI2.WinForms.Guna2Button btn_next;
        private Label label_NoSet;
        private Label questionLabel;
        private TextBox textBox_answer;
        private Label label8;
        private TextBox textBox_option4;
        private Label label7;
        private Label label6;
        private TextBox textBox_option3;
        private Label label5;
        private TextBox textBox_option2;
        private Label label4;
        private TextBox textBox_option1;
        private Label label3;
        private TextBox textBox_question;
        private Label label2;
        private TextBox textBox_set;
        private Label Set;
        private Label label1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label_nameEmp;
        private Label label16;
        private Label label17;
        private Label label18;
        private System.Windows.Forms.Timer timer1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private DateTimePicker dateTimePicker1;
        private Label label_question;
        private Label label_totalQuestions;
        private Label label_questionNo;
        private Label label_idEmp;
    }
}