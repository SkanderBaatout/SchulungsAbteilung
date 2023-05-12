namespace Essai
{
    partial class ManageCourseForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            button_delete = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            label7 = new Label();
            button_update = new Button();
            textBox_description = new TextBox();
            label5 = new Label();
            textBox_hour = new TextBox();
            label2 = new Label();
            textBox_courseName = new TextBox();
            label1 = new Label();
            DataGridViewCourses = new Guna.UI2.WinForms.Guna2DataGridView();
            textBox_id = new TextBox();
            label3 = new Label();
            button_clear = new Button();
            textBox_search = new TextBox();
            button_search = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(826, 572);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(96, 33);
            button_delete.TabIndex = 62;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Teal;
            panel3.Location = new Point(12, 384);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 8);
            panel3.TabIndex = 55;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 58);
            panel1.TabIndex = 54;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(389, 18);
            label7.Name = "label7";
            label7.Size = new Size(211, 28);
            label7.TabIndex = 0;
            label7.Text = "Manage Courses";
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.OrangeRed;
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(724, 572);
            button_update.Name = "button_update";
            button_update.Size = new Size(96, 33);
            button_update.TabIndex = 63;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Location = new Point(40, 519);
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
            label5.Location = new Point(38, 497);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 60;
            label5.Text = "Description :";
            // 
            // textBox_hour
            // 
            textBox_hour.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_hour.Location = new Point(40, 469);
            textBox_hour.Name = "textBox_hour";
            textBox_hour.Size = new Size(151, 27);
            textBox_hour.TabIndex = 59;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(40, 447);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 58;
            label2.Text = "Hour :";
            // 
            // textBox_courseName
            // 
            textBox_courseName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_courseName.Location = new Point(38, 417);
            textBox_courseName.Name = "textBox_courseName";
            textBox_courseName.Size = new Size(500, 27);
            textBox_courseName.TabIndex = 57;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(38, 395);
            label1.Name = "label1";
            label1.Size = new Size(123, 19);
            label1.TabIndex = 56;
            label1.Text = "Course Name :";
            // 
            // DataGridViewCourses
            // 
            DataGridViewCourses.AllowUserToAddRows = false;
            DataGridViewCourses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewCourses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DataGridViewCourses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewCourses.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataGridViewCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DataGridViewCourses.ColumnHeadersHeight = 24;
            DataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataGridViewCourses.DefaultCellStyle = dataGridViewCellStyle6;
            DataGridViewCourses.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewCourses.Location = new Point(12, 101);
            DataGridViewCourses.Name = "DataGridViewCourses";
            DataGridViewCourses.RowHeadersVisible = false;
            DataGridViewCourses.RowTemplate.Height = 80;
            DataGridViewCourses.Size = new Size(910, 277);
            DataGridViewCourses.TabIndex = 53;
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
            DataGridViewCourses.Click += DataGridViewCourses_Click;
            // 
            // textBox_id
            // 
            textBox_id.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_id.Location = new Point(264, 469);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(125, 27);
            textBox_id.TabIndex = 65;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(264, 447);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 64;
            label3.Text = "Course ID :";
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(622, 572);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(96, 33);
            button_clear.TabIndex = 66;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(588, 67);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(204, 27);
            textBox_search.TabIndex = 68;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.Orange;
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(798, 64);
            button_search.Name = "button_search";
            button_search.Size = new Size(98, 31);
            button_search.TabIndex = 67;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // ManageCourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(textBox_search);
            Controls.Add(button_search);
            Controls.Add(button_clear);
            Controls.Add(textBox_id);
            Controls.Add(label3);
            Controls.Add(button_delete);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(button_update);
            Controls.Add(textBox_description);
            Controls.Add(label5);
            Controls.Add(textBox_hour);
            Controls.Add(label2);
            Controls.Add(textBox_courseName);
            Controls.Add(label1);
            Controls.Add(DataGridViewCourses);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ManageCourseForm";
            Text = "ManageCourseForm";
            Load += ManageCourseForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_delete;
        private Panel panel3;
        private Panel panel1;
        private Label label7;
        private Button button_update;
        private TextBox textBox_description;
        private Label label5;
        private TextBox textBox_hour;
        private Label label2;
        private TextBox textBox_courseName;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewCourses;
        private TextBox textBox_id;
        private Label label3;
        private Button button_clear;
        private TextBox textBox_search;
        private Button button_search;
    }
}