namespace Essai
{
    partial class ManageScoreForm
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
            textBox_search = new TextBox();
            button_search = new Button();
            button_clear = new Button();
            button_delete = new Button();
            button_update = new Button();
            DataGridViewScores = new Guna.UI2.WinForms.Guna2DataGridView();
            label7 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            comboBox_selectCourse = new ComboBox();
            label3 = new Label();
            textBox_description = new TextBox();
            label5 = new Label();
            textBox_score = new TextBox();
            label2 = new Label();
            textBox_studentId = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewScores).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(588, 70);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(204, 27);
            textBox_search.TabIndex = 84;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.Orange;
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(798, 67);
            button_search.Name = "button_search";
            button_search.Size = new Size(98, 31);
            button_search.TabIndex = 83;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(622, 575);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(96, 33);
            button_clear.TabIndex = 82;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(826, 575);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(96, 33);
            button_delete.TabIndex = 78;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.OrangeRed;
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(724, 575);
            button_update.Name = "button_update";
            button_update.Size = new Size(96, 33);
            button_update.TabIndex = 79;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // DataGridViewScores
            // 
            DataGridViewScores.AllowUserToAddRows = false;
            DataGridViewScores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewScores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewScores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewScores.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewScores.ColumnHeadersHeight = 24;
            DataGridViewScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewScores.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewScores.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewScores.Location = new Point(12, 104);
            DataGridViewScores.Name = "DataGridViewScores";
            DataGridViewScores.RowHeadersVisible = false;
            DataGridViewScores.RowTemplate.Height = 80;
            DataGridViewScores.Size = new Size(910, 277);
            DataGridViewScores.TabIndex = 69;
            DataGridViewScores.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridViewScores.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridViewScores.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridViewScores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridViewScores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridViewScores.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridViewScores.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewScores.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridViewScores.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewScores.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridViewScores.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridViewScores.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridViewScores.ThemeStyle.HeaderStyle.Height = 24;
            DataGridViewScores.ThemeStyle.ReadOnly = false;
            DataGridViewScores.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridViewScores.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewScores.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridViewScores.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewScores.ThemeStyle.RowsStyle.Height = 80;
            DataGridViewScores.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridViewScores.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewScores.Click += DataGridViewScores_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(389, 18);
            label7.Name = "label7";
            label7.Size = new Size(183, 28);
            label7.TabIndex = 0;
            label7.Text = "Manage Score";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Teal;
            panel3.Location = new Point(12, 387);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 8);
            panel3.TabIndex = 71;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 58);
            panel1.TabIndex = 70;
            // 
            // comboBox_selectCourse
            // 
            comboBox_selectCourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox_selectCourse.FormattingEnabled = true;
            comboBox_selectCourse.Location = new Point(153, 448);
            comboBox_selectCourse.Name = "comboBox_selectCourse";
            comboBox_selectCourse.Size = new Size(461, 29);
            comboBox_selectCourse.TabIndex = 92;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(24, 452);
            label3.Name = "label3";
            label3.Size = new Size(120, 19);
            label3.TabIndex = 91;
            label3.Text = "Select Course :";
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Location = new Point(153, 539);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(461, 48);
            textBox_description.TabIndex = 90;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(24, 543);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 89;
            label5.Text = "Description :";
            // 
            // textBox_score
            // 
            textBox_score.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_score.Location = new Point(153, 493);
            textBox_score.Name = "textBox_score";
            textBox_score.Size = new Size(151, 27);
            textBox_score.TabIndex = 88;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(73, 497);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 87;
            label2.Text = "Score :";
            // 
            // textBox_studentId
            // 
            textBox_studentId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_studentId.Location = new Point(153, 407);
            textBox_studentId.Name = "textBox_studentId";
            textBox_studentId.Size = new Size(151, 27);
            textBox_studentId.TabIndex = 86;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(24, 407);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 85;
            label1.Text = "Student ID:";
            // 
            // ManageScoreForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(comboBox_selectCourse);
            Controls.Add(label3);
            Controls.Add(textBox_description);
            Controls.Add(label5);
            Controls.Add(textBox_score);
            Controls.Add(label2);
            Controls.Add(textBox_studentId);
            Controls.Add(label1);
            Controls.Add(textBox_search);
            Controls.Add(button_search);
            Controls.Add(button_clear);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(DataGridViewScores);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ManageScoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageScoreForm";
            Load += ManageScoreForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewScores).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_search;
        private Button button_search;
        private Button button_clear;
        private Button button_delete;
        private Button button_update;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewScores;
        private Label label7;
        private Panel panel3;
        private Panel panel1;
        private ComboBox comboBox_selectCourse;
        private Label label3;
        private TextBox textBox_description;
        private Label label5;
        private TextBox textBox_score;
        private Label label2;
        private TextBox textBox_studentId;
        private Label label1;
    }
}