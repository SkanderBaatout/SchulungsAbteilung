namespace Essai
{
    partial class ScoreForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel3 = new Panel();
            panel1 = new Panel();
            button_sScore = new Button();
            button_sStudent = new Button();
            button_clear = new Button();
            button_add = new Button();
            textBox_description = new TextBox();
            label5 = new Label();
            textBox_score = new TextBox();
            label2 = new Label();
            textBox_studentId = new TextBox();
            label1 = new Label();
            DataGridViewEmployeeList = new Guna.UI2.WinForms.Guna2DataGridView();
            label3 = new Label();
            comboBox_selectCourse = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEmployeeList).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Teal;
            panel3.Location = new Point(12, 357);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 8);
            panel3.TabIndex = 55;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(button_sScore);
            panel1.Controls.Add(button_sStudent);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 58);
            panel1.TabIndex = 54;
            // 
            // button_sScore
            // 
            button_sScore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_sScore.BackColor = Color.White;
            button_sScore.FlatStyle = FlatStyle.Flat;
            button_sScore.ForeColor = Color.Teal;
            button_sScore.Location = new Point(764, 12);
            button_sScore.Name = "button_sScore";
            button_sScore.Size = new Size(138, 36);
            button_sScore.TabIndex = 1;
            button_sScore.Text = "Show Score";
            button_sScore.UseVisualStyleBackColor = false;
            button_sScore.Click += button_sScore_Click;
            // 
            // button_sStudent
            // 
            button_sStudent.BackColor = Color.White;
            button_sStudent.FlatStyle = FlatStyle.Flat;
            button_sStudent.ForeColor = Color.Teal;
            button_sStudent.Location = new Point(24, 12);
            button_sStudent.Name = "button_sStudent";
            button_sStudent.Size = new Size(142, 36);
            button_sStudent.TabIndex = 0;
            button_sStudent.Text = "Show Employee";
            button_sStudent.UseVisualStyleBackColor = false;
            button_sStudent.Click += button_sStudent_Click;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(724, 572);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(96, 33);
            button_clear.TabIndex = 63;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.SteelBlue;
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(826, 572);
            button_add.Name = "button_add";
            button_add.Size = new Size(96, 33);
            button_add.TabIndex = 62;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Location = new Point(153, 509);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(500, 60);
            textBox_description.TabIndex = 61;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(24, 513);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 60;
            label5.Text = "Description :";
            // 
            // textBox_score
            // 
            textBox_score.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_score.Location = new Point(153, 457);
            textBox_score.Name = "textBox_score";
            textBox_score.Size = new Size(151, 27);
            textBox_score.TabIndex = 59;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(73, 461);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 58;
            label2.Text = "Score :";
            // 
            // textBox_studentId
            // 
            textBox_studentId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_studentId.Location = new Point(153, 371);
            textBox_studentId.Name = "textBox_studentId";
            textBox_studentId.Size = new Size(151, 27);
            textBox_studentId.TabIndex = 57;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(24, 371);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 56;
            label1.Text = "Student ID:";
            // 
            // DataGridViewEmployeeList
            // 
            DataGridViewEmployeeList.AllowUserToAddRows = false;
            DataGridViewEmployeeList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewEmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewEmployeeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewEmployeeList.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewEmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewEmployeeList.ColumnHeadersHeight = 24;
            DataGridViewEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewEmployeeList.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewEmployeeList.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewEmployeeList.Location = new Point(12, 64);
            DataGridViewEmployeeList.Name = "DataGridViewEmployeeList";
            DataGridViewEmployeeList.RowHeadersVisible = false;
            DataGridViewEmployeeList.RowTemplate.Height = 80;
            DataGridViewEmployeeList.Size = new Size(910, 287);
            DataGridViewEmployeeList.TabIndex = 53;
            DataGridViewEmployeeList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridViewEmployeeList.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridViewEmployeeList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridViewEmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridViewEmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridViewEmployeeList.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridViewEmployeeList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewEmployeeList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridViewEmployeeList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewEmployeeList.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridViewEmployeeList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridViewEmployeeList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridViewEmployeeList.ThemeStyle.HeaderStyle.Height = 24;
            DataGridViewEmployeeList.ThemeStyle.ReadOnly = false;
            DataGridViewEmployeeList.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridViewEmployeeList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewEmployeeList.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridViewEmployeeList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewEmployeeList.ThemeStyle.RowsStyle.Height = 80;
            DataGridViewEmployeeList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridViewEmployeeList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewEmployeeList.Click += DataGridViewEmployeeList_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(24, 416);
            label3.Name = "label3";
            label3.Size = new Size(120, 19);
            label3.TabIndex = 64;
            label3.Text = "Select Course :";
            // 
            // comboBox_selectCourse
            // 
            comboBox_selectCourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox_selectCourse.FormattingEnabled = true;
            comboBox_selectCourse.Location = new Point(153, 412);
            comboBox_selectCourse.Name = "comboBox_selectCourse";
            comboBox_selectCourse.Size = new Size(500, 29);
            comboBox_selectCourse.TabIndex = 65;
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(comboBox_selectCourse);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(button_clear);
            Controls.Add(button_add);
            Controls.Add(textBox_description);
            Controls.Add(label5);
            Controls.Add(textBox_score);
            Controls.Add(label2);
            Controls.Add(textBox_studentId);
            Controls.Add(label1);
            Controls.Add(DataGridViewEmployeeList);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ScoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScoreForm";
            Load += ScoreForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewEmployeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Button button_clear;
        private Button button_add;
        private TextBox textBox_description;
        private Label label5;
        private TextBox textBox_score;
        private Label label2;
        private TextBox textBox_studentId;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewEmployeeList;
        private Label label3;
        private ComboBox comboBox_selectCourse;
        private Button button_sScore;
        private Button button_sStudent;
    }
}