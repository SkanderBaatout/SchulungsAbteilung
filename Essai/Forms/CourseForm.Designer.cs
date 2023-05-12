namespace Essai
{
    partial class CourseForm
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
            label7 = new Label();
            DataGridViewCourses = new Guna.UI2.WinForms.Guna2DataGridView();
            button_clear = new Button();
            button_add = new Button();
            textBox_description = new TextBox();
            label5 = new Label();
            textBox_hour = new TextBox();
            label2 = new Label();
            textBox_courseName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Teal;
            panel3.Location = new Point(12, 340);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 8);
            panel3.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 58);
            panel1.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(389, 18);
            label7.Name = "label7";
            label7.Size = new Size(153, 28);
            label7.TabIndex = 0;
            label7.Text = "New Course";
            // 
            // DataGridViewCourses
            // 
            DataGridViewCourses.AllowUserToAddRows = false;
            DataGridViewCourses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCourses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewCourses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewCourses.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewCourses.ColumnHeadersHeight = 24;
            DataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewCourses.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewCourses.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewCourses.Location = new Point(12, 70);
            DataGridViewCourses.Name = "DataGridViewCourses";
            DataGridViewCourses.RowHeadersVisible = false;
            DataGridViewCourses.RowTemplate.Height = 80;
            DataGridViewCourses.Size = new Size(910, 255);
            DataGridViewCourses.TabIndex = 39;
            DataGridViewCourses.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridViewCourses.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridViewCourses.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridViewCourses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridViewCourses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridViewCourses.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridViewCourses.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewCourses.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridViewCourses.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCourses.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridViewCourses.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridViewCourses.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridViewCourses.ThemeStyle.HeaderStyle.Height = 24;
            DataGridViewCourses.ThemeStyle.ReadOnly = false;
            DataGridViewCourses.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridViewCourses.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewCourses.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridViewCourses.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewCourses.ThemeStyle.RowsStyle.Height = 80;
            DataGridViewCourses.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridViewCourses.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(724, 566);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(96, 33);
            button_clear.TabIndex = 52;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.SteelBlue;
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(826, 566);
            button_add.Name = "button_add";
            button_add.Size = new Size(96, 33);
            button_add.TabIndex = 51;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Location = new Point(24, 511);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(500, 60);
            textBox_description.TabIndex = 48;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(24, 489);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 47;
            label5.Text = "Description :";
            // 
            // textBox_hour
            // 
            textBox_hour.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_hour.Location = new Point(24, 450);
            textBox_hour.Name = "textBox_hour";
            textBox_hour.Size = new Size(151, 27);
            textBox_hour.TabIndex = 46;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(24, 428);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 45;
            label2.Text = "Hour :";
            // 
            // textBox_courseName
            // 
            textBox_courseName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_courseName.Location = new Point(24, 387);
            textBox_courseName.Name = "textBox_courseName";
            textBox_courseName.Size = new Size(500, 27);
            textBox_courseName.TabIndex = 44;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(24, 365);
            label1.Name = "label1";
            label1.Size = new Size(123, 19);
            label1.TabIndex = 43;
            label1.Text = "Course Name :";
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(button_clear);
            Controls.Add(button_add);
            Controls.Add(textBox_description);
            Controls.Add(label5);
            Controls.Add(textBox_hour);
            Controls.Add(label2);
            Controls.Add(textBox_courseName);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(DataGridViewCourses);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CourseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CourseForm";
            Load += CourseForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewCourses;
        private Button button_clear;
        private Button button_add;
        private TextBox textBox_description;
        private Label label5;
        private TextBox textBox_hour;
        private Label label2;
        private TextBox textBox_courseName;
        private Label label1;
    }
}