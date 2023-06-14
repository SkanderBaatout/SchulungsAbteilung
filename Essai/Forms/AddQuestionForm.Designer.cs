namespace Essai
{
    partial class AddQuestionForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            Set = new Label();
            textBox_question = new TextBox();
            label2 = new Label();
            textBox_option1 = new TextBox();
            label3 = new Label();
            textBox_option2 = new TextBox();
            label4 = new Label();
            textBox_option3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox_option4 = new TextBox();
            label7 = new Label();
            textBox_answer = new TextBox();
            label8 = new Label();
            questionLabel = new Label();
            btn_next = new Guna.UI2.WinForms.Guna2Button();
            btn_reset = new Guna.UI2.WinForms.Guna2Button();
            btn_finish = new Guna.UI2.WinForms.Guna2Button();
            pictureBox2 = new PictureBox();
            testsCB = new ComboBox();
            textBox_set = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(59, 26);
            label1.Name = "label1";
            label1.Size = new Size(220, 36);
            label1.TabIndex = 0;
            label1.Text = "Add Questions";
            // 
            // Set
            // 
            Set.AutoSize = true;
            Set.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Set.Location = new Point(116, 93);
            Set.Name = "Set";
            Set.Size = new Size(186, 23);
            Set.TabIndex = 1;
            Set.Text = "Choose a Test Type";
            // 
            // textBox_question
            // 
            textBox_question.Location = new Point(176, 253);
            textBox_question.Name = "textBox_question";
            textBox_question.Size = new Size(241, 27);
            textBox_question.TabIndex = 4;
            textBox_question.TextChanged += textBox_question_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(176, 229);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 3;
            label2.Text = "Question";
            // 
            // textBox_option1
            // 
            textBox_option1.Location = new Point(176, 329);
            textBox_option1.Name = "textBox_option1";
            textBox_option1.Size = new Size(241, 27);
            textBox_option1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(176, 305);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 5;
            label3.Text = "Option 1:";
            // 
            // textBox_option2
            // 
            textBox_option2.Location = new Point(176, 392);
            textBox_option2.Name = "textBox_option2";
            textBox_option2.Size = new Size(241, 27);
            textBox_option2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(176, 368);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 7;
            label4.Text = "Option 2:";
            // 
            // textBox_option3
            // 
            textBox_option3.Location = new Point(176, 460);
            textBox_option3.Name = "textBox_option3";
            textBox_option3.Size = new Size(241, 27);
            textBox_option3.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(176, 436);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 9;
            label5.Text = "Option 3:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(645, 120);
            label6.Name = "label6";
            label6.Size = new Size(132, 23);
            label6.TabIndex = 11;
            label6.Text = "Question No :";
            // 
            // textBox_option4
            // 
            textBox_option4.Location = new Point(176, 529);
            textBox_option4.Name = "textBox_option4";
            textBox_option4.Size = new Size(241, 27);
            textBox_option4.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(176, 505);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 12;
            label7.Text = "Option 4:";
            // 
            // textBox_answer
            // 
            textBox_answer.Location = new Point(575, 460);
            textBox_answer.Name = "textBox_answer";
            textBox_answer.Size = new Size(341, 27);
            textBox_answer.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(575, 436);
            label8.Name = "label8";
            label8.Size = new Size(65, 19);
            label8.TabIndex = 14;
            label8.Text = "Answer";
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            questionLabel.ForeColor = Color.Red;
            questionLabel.Location = new Point(666, 146);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(32, 23);
            questionLabel.TabIndex = 16;
            questionLabel.Text = "11";
            // 
            // btn_next
            // 
            btn_next.BorderRadius = 15;
            btn_next.CustomizableEdges = customizableEdges1;
            btn_next.DisabledState.BorderColor = Color.DarkGray;
            btn_next.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_next.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_next.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_next.FillColor = Color.Teal;
            btn_next.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_next.ForeColor = Color.White;
            btn_next.Location = new Point(575, 529);
            btn_next.Name = "btn_next";
            btn_next.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_next.Size = new Size(168, 45);
            btn_next.TabIndex = 18;
            btn_next.Text = "Next";
            btn_next.Click += btn_next_Click;
            // 
            // btn_reset
            // 
            btn_reset.BorderRadius = 15;
            btn_reset.CustomizableEdges = customizableEdges3;
            btn_reset.DisabledState.BorderColor = Color.DarkGray;
            btn_reset.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_reset.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_reset.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_reset.FillColor = Color.DarkTurquoise;
            btn_reset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reset.ForeColor = Color.White;
            btn_reset.Location = new Point(749, 529);
            btn_reset.Name = "btn_reset";
            btn_reset.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_reset.Size = new Size(167, 45);
            btn_reset.TabIndex = 19;
            btn_reset.Text = "Reset";
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_finish
            // 
            btn_finish.BorderRadius = 15;
            btn_finish.CustomizableEdges = customizableEdges5;
            btn_finish.DisabledState.BorderColor = Color.DarkGray;
            btn_finish.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_finish.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_finish.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_finish.FillColor = Color.FromArgb(255, 128, 0);
            btn_finish.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_finish.ForeColor = Color.White;
            btn_finish.Location = new Point(655, 580);
            btn_finish.Name = "btn_finish";
            btn_finish.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_finish.Size = new Size(174, 45);
            btn_finish.TabIndex = 20;
            btn_finish.Text = "Finish";
            btn_finish.Click += btn_finish_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gainsboro;
            pictureBox2.Location = new Point(575, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(341, 232);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // testsCB
            // 
            testsCB.FormattingEnabled = true;
            testsCB.Location = new Point(116, 129);
            testsCB.Name = "testsCB";
            testsCB.Size = new Size(316, 29);
            testsCB.TabIndex = 23;
            testsCB.SelectedIndexChanged += testsCB_SelectedIndexChanged;
            // 
            // textBox_set
            // 
            textBox_set.Location = new Point(119, 165);
            textBox_set.Name = "textBox_set";
            textBox_set.Size = new Size(313, 27);
            textBox_set.TabIndex = 24;
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(textBox_set);
            Controls.Add(testsCB);
            Controls.Add(pictureBox2);
            Controls.Add(btn_finish);
            Controls.Add(btn_reset);
            Controls.Add(btn_next);
            Controls.Add(questionLabel);
            Controls.Add(textBox_answer);
            Controls.Add(label8);
            Controls.Add(textBox_option4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox_option3);
            Controls.Add(label5);
            Controls.Add(textBox_option2);
            Controls.Add(label4);
            Controls.Add(textBox_option1);
            Controls.Add(label3);
            Controls.Add(textBox_question);
            Controls.Add(label2);
            Controls.Add(Set);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AddQuestionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddQuestionForm";
            Load += AddQuestionForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Set;
        private TextBox textBox_question;
        private Label label2;
        private TextBox textBox_option1;
        private Label label3;
        private TextBox textBox_option2;
        private Label label4;
        private TextBox textBox_option3;
        private Label label5;
        private Label label6;
        private TextBox textBox_option4;
        private Label label7;
        private TextBox textBox_answer;
        private Label label8;
        private Label questionLabel;
        private Guna.UI2.WinForms.Guna2Button btn_next;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
        private Guna.UI2.WinForms.Guna2Button btn_finish;
        private PictureBox pictureBox2;
        private ComboBox testsCB;
        private TextBox textBox_set;
    }
}