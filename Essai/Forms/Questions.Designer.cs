namespace Essai
{
    partial class Questions
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            question = new MaskedTextBox();
            answer = new MaskedTextBox();
            option4 = new MaskedTextBox();
            option3 = new MaskedTextBox();
            option2 = new MaskedTextBox();
            option1 = new MaskedTextBox();
            SubjectcomboBox = new ComboBox();
            savebtn = new Guna.UI2.WinForms.Guna2Button();
            resetbtn = new Guna.UI2.WinForms.Guna2Button();
            editbtn = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            questionListDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label9 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)questionListDGV).BeginInit();
            SuspendLayout();
            // 
            // question
            // 
            question.Location = new Point(16, 89);
            question.Name = "question";
            question.Size = new Size(319, 27);
            question.TabIndex = 4;
            question.TextAlign = HorizontalAlignment.Center;
            // 
            // answer
            // 
            answer.Location = new Point(16, 142);
            answer.Name = "answer";
            answer.Size = new Size(319, 27);
            answer.TabIndex = 5;
            answer.TextAlign = HorizontalAlignment.Center;
            // 
            // option4
            // 
            option4.Location = new Point(667, 142);
            option4.Name = "option4";
            option4.Size = new Size(256, 27);
            option4.TabIndex = 6;
            option4.TextAlign = HorizontalAlignment.Center;
            // 
            // option3
            // 
            option3.Location = new Point(360, 142);
            option3.Name = "option3";
            option3.Size = new Size(256, 27);
            option3.TabIndex = 7;
            option3.TextAlign = HorizontalAlignment.Center;
            // 
            // option2
            // 
            option2.Location = new Point(667, 89);
            option2.Name = "option2";
            option2.Size = new Size(256, 27);
            option2.TabIndex = 8;
            option2.TextAlign = HorizontalAlignment.Center;
            // 
            // option1
            // 
            option1.Location = new Point(360, 89);
            option1.Name = "option1";
            option1.Size = new Size(256, 27);
            option1.TabIndex = 9;
            option1.TextAlign = HorizontalAlignment.Center;
            // 
            // SubjectcomboBox
            // 
            SubjectcomboBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SubjectcomboBox.FormattingEnabled = true;
            SubjectcomboBox.Location = new Point(667, 24);
            SubjectcomboBox.Name = "SubjectcomboBox";
            SubjectcomboBox.Size = new Size(256, 27);
            SubjectcomboBox.TabIndex = 10;
            SubjectcomboBox.Text = "Subject";
            SubjectcomboBox.SelectedIndexChanged += SubjectcomboBox_SelectedIndexChanged;
            // 
            // savebtn
            // 
            savebtn.BorderRadius = 15;
            savebtn.CustomizableEdges = customizableEdges1;
            savebtn.DisabledState.BorderColor = Color.DarkGray;
            savebtn.DisabledState.CustomBorderColor = Color.DarkGray;
            savebtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            savebtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            savebtn.FillColor = Color.Teal;
            savebtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            savebtn.ForeColor = Color.White;
            savebtn.Location = new Point(168, 191);
            savebtn.Name = "savebtn";
            savebtn.ShadowDecoration.BorderRadius = 15;
            savebtn.ShadowDecoration.Color = Color.Transparent;
            savebtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            savebtn.Size = new Size(167, 45);
            savebtn.TabIndex = 11;
            savebtn.Text = "Save";
            savebtn.Click += savebtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.BorderRadius = 15;
            resetbtn.CustomizableEdges = customizableEdges3;
            resetbtn.DisabledState.BorderColor = Color.DarkGray;
            resetbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            resetbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            resetbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            resetbtn.FillColor = Color.FromArgb(255, 128, 0);
            resetbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.ForeColor = Color.White;
            resetbtn.Location = new Point(597, 191);
            resetbtn.Name = "resetbtn";
            resetbtn.ShadowDecoration.BorderRadius = 15;
            resetbtn.ShadowDecoration.Color = Color.Transparent;
            resetbtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            resetbtn.Size = new Size(167, 45);
            resetbtn.TabIndex = 12;
            resetbtn.Text = "Reset";
            resetbtn.Click += resetbtn_Click;
            // 
            // editbtn
            // 
            editbtn.BorderRadius = 15;
            editbtn.CustomizableEdges = customizableEdges5;
            editbtn.DisabledState.BorderColor = Color.DarkGray;
            editbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            editbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            editbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            editbtn.FillColor = Color.DarkTurquoise;
            editbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            editbtn.ForeColor = Color.White;
            editbtn.Location = new Point(387, 191);
            editbtn.Name = "editbtn";
            editbtn.ShadowDecoration.BorderRadius = 15;
            editbtn.ShadowDecoration.Color = Color.Transparent;
            editbtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            editbtn.Size = new Size(167, 45);
            editbtn.TabIndex = 13;
            editbtn.Text = "Edit";
            editbtn.Click += editbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(351, 275);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(248, 28);
            label4.TabIndex = 15;
            label4.Text = "Quiz Questions Bank";
            // 
            // questionListDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            questionListDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            questionListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            questionListDGV.ColumnHeadersHeight = 25;
            questionListDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            questionListDGV.DefaultCellStyle = dataGridViewCellStyle3;
            questionListDGV.Dock = DockStyle.Bottom;
            questionListDGV.GridColor = Color.FromArgb(231, 229, 255);
            questionListDGV.Location = new Point(0, 319);
            questionListDGV.Name = "questionListDGV";
            questionListDGV.RowHeadersVisible = false;
            questionListDGV.RowTemplate.Height = 24;
            questionListDGV.Size = new Size(950, 331);
            questionListDGV.TabIndex = 32;
            questionListDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            questionListDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            questionListDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            questionListDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            questionListDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            questionListDGV.ThemeStyle.BackColor = Color.White;
            questionListDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            questionListDGV.ThemeStyle.HeaderStyle.BackColor = Color.Black;
            questionListDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            questionListDGV.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            questionListDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            questionListDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            questionListDGV.ThemeStyle.HeaderStyle.Height = 25;
            questionListDGV.ThemeStyle.ReadOnly = false;
            questionListDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            questionListDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            questionListDGV.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            questionListDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            questionListDGV.ThemeStyle.RowsStyle.Height = 24;
            questionListDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            questionListDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            questionListDGV.CellContentClick += questionListDGV_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(16, 67);
            label9.Name = "label9";
            label9.Size = new Size(76, 19);
            label9.TabIndex = 49;
            label9.Text = "Question";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(370, 67);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 50;
            label5.Text = "Option1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(677, 67);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 51;
            label6.Text = "Option2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(16, 120);
            label7.Name = "label7";
            label7.Size = new Size(65, 19);
            label7.TabIndex = 52;
            label7.Text = "Answer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(677, 120);
            label8.Name = "label8";
            label8.Size = new Size(70, 19);
            label8.TabIndex = 53;
            label8.Text = "Option4";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(360, 120);
            label10.Name = "label10";
            label10.Size = new Size(70, 19);
            label10.TabIndex = 54;
            label10.Text = "Option3";
            // 
            // Questions
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(questionListDGV);
            Controls.Add(label4);
            Controls.Add(editbtn);
            Controls.Add(resetbtn);
            Controls.Add(savebtn);
            Controls.Add(SubjectcomboBox);
            Controls.Add(option1);
            Controls.Add(option2);
            Controls.Add(option3);
            Controls.Add(option4);
            Controls.Add(answer);
            Controls.Add(question);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Questions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questions";
            Load += Questions_Load;
            ((System.ComponentModel.ISupportInitialize)questionListDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox question;
        private MaskedTextBox answer;
        private MaskedTextBox option4;
        private MaskedTextBox option3;
        private MaskedTextBox option2;
        private MaskedTextBox option1;
        private ComboBox SubjectcomboBox;
        private Guna.UI2.WinForms.Guna2Button savebtn;
        private Guna.UI2.WinForms.Guna2Button resetbtn;
        private Guna.UI2.WinForms.Guna2Button editbtn;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView questionListDGV;
        private Label label9;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
    }
}