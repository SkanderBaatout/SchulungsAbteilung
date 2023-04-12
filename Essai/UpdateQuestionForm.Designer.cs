namespace Essai
{
    partial class UpdateQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateQuestionForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            btn_reset = new Guna.UI2.WinForms.Guna2Button();
            btn_update = new Guna.UI2.WinForms.Guna2Button();
            textBox_answer = new TextBox();
            label8 = new Label();
            textBox_option4 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBox_option3 = new TextBox();
            label5 = new Label();
            textBox_option2 = new TextBox();
            label4 = new Label();
            textBox_option1 = new TextBox();
            label3 = new Label();
            textBox_question = new TextBox();
            label2 = new Label();
            Set = new Label();
            label1 = new Label();
            comboQuestion = new ComboBox();
            comboSet = new ComboBox();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // btn_reset
            // 
            btn_reset.BorderRadius = 15;
            btn_reset.CustomizableEdges = customizableEdges1;
            btn_reset.DisabledState.BorderColor = Color.DarkGray;
            btn_reset.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_reset.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_reset.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_reset.FillColor = Color.DarkTurquoise;
            btn_reset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reset.ForeColor = Color.White;
            btn_reset.Location = new Point(459, 593);
            btn_reset.Name = "btn_reset";
            btn_reset.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_reset.Size = new Size(167, 45);
            btn_reset.TabIndex = 41;
            btn_reset.Text = "Reset";
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_update
            // 
            btn_update.BorderRadius = 15;
            btn_update.CustomizableEdges = customizableEdges3;
            btn_update.DisabledState.BorderColor = Color.DarkGray;
            btn_update.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_update.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_update.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_update.FillColor = Color.Teal;
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(285, 593);
            btn_update.Name = "btn_update";
            btn_update.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_update.Size = new Size(168, 45);
            btn_update.TabIndex = 40;
            btn_update.Text = "Update";
            btn_update.Click += btn_update_Click;
            // 
            // textBox_answer
            // 
            textBox_answer.Location = new Point(92, 441);
            textBox_answer.Name = "textBox_answer";
            textBox_answer.Size = new Size(311, 27);
            textBox_answer.TabIndex = 37;
            textBox_answer.TextChanged += textBox_answer_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(92, 419);
            label8.Name = "label8";
            label8.Size = new Size(73, 19);
            label8.TabIndex = 36;
            label8.Text = "Answer :";
            // 
            // textBox_option4
            // 
            textBox_option4.Location = new Point(494, 363);
            textBox_option4.Name = "textBox_option4";
            textBox_option4.Size = new Size(311, 27);
            textBox_option4.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(494, 341);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 34;
            label7.Text = "Option 4:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(494, 113);
            label6.Name = "label6";
            label6.Size = new Size(132, 23);
            label6.TabIndex = 33;
            label6.Text = "Question No :";
            // 
            // textBox_option3
            // 
            textBox_option3.Location = new Point(494, 300);
            textBox_option3.Name = "textBox_option3";
            textBox_option3.Size = new Size(311, 27);
            textBox_option3.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(494, 276);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 31;
            label5.Text = "Option 3:";
            // 
            // textBox_option2
            // 
            textBox_option2.Location = new Point(92, 363);
            textBox_option2.Name = "textBox_option2";
            textBox_option2.Size = new Size(311, 27);
            textBox_option2.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(92, 341);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 29;
            label4.Text = "Option 2:";
            // 
            // textBox_option1
            // 
            textBox_option1.Location = new Point(92, 300);
            textBox_option1.Name = "textBox_option1";
            textBox_option1.Size = new Size(311, 27);
            textBox_option1.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(92, 276);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 27;
            label3.Text = "Option 1:";
            // 
            // textBox_question
            // 
            textBox_question.Location = new Point(92, 217);
            textBox_question.Name = "textBox_question";
            textBox_question.Size = new Size(713, 27);
            textBox_question.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(409, 186);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 25;
            label2.Text = "Question";
            // 
            // Set
            // 
            Set.AutoSize = true;
            Set.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Set.Location = new Point(92, 115);
            Set.Name = "Set";
            Set.Size = new Size(38, 23);
            Set.TabIndex = 23;
            Set.Text = "Set";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(74, 54);
            label1.Name = "label1";
            label1.Size = new Size(265, 36);
            label1.TabIndex = 22;
            label1.Text = "Update Questions";
            // 
            // comboQuestion
            // 
            comboQuestion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboQuestion.FormattingEnabled = true;
            comboQuestion.Location = new Point(494, 139);
            comboQuestion.Name = "comboQuestion";
            comboQuestion.Size = new Size(311, 27);
            comboQuestion.TabIndex = 44;
            comboQuestion.SelectedIndexChanged += comboQuestion_SelectedIndexChanged;
            // 
            // comboSet
            // 
            comboSet.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboSet.FormattingEnabled = true;
            comboSet.Location = new Point(92, 141);
            comboSet.Name = "comboSet";
            comboSet.Size = new Size(311, 27);
            comboSet.TabIndex = 45;
            comboSet.SelectedIndexChanged += comboSet_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(494, 441);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(311, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(499, 405);
            label9.Name = "label9";
            label9.Size = new Size(69, 19);
            label9.TabIndex = 47;
            label9.Text = "Picture :";
            // 
            // UpdateQuestionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 650);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(comboSet);
            Controls.Add(comboQuestion);
            Controls.Add(pictureBox1);
            Controls.Add(btn_reset);
            Controls.Add(btn_update);
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
            Name = "UpdateQuestionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateQuestionForm";
            Load += UpdateQuestionForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
        private Guna.UI2.WinForms.Guna2Button btn_update;
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
        private Label Set;
        private Label label1;
        private ComboBox comboQuestion;
        private ComboBox comboSet;
        private PictureBox pictureBox2;
        private Label label9;
    }
}