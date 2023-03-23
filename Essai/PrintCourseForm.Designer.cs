namespace Essai
{
    partial class PrintCourseForm
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
            button_searc = new Button();
            panel3 = new Panel();
            radioButton_female = new RadioButton();
            button_print = new Button();
            radioButton_male = new RadioButton();
            radioButton_all = new RadioButton();
            label4 = new Label();
            textBox_id = new TextBox();
            label_id = new Label();
            button_clear = new Button();
            button_update = new Button();
            button_delete = new Button();
            textBox_phone = new TextBox();
            button_upload = new Button();
            pictureBox_employee = new PictureBox();
            DataGridViewCourses = new Guna.UI2.WinForms.Guna2DataGridView();
            label7 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            textBox_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_employee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCourses).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button_searc
            // 
            button_searc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_searc.BackColor = Color.Teal;
            button_searc.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_searc.ForeColor = Color.White;
            button_searc.Location = new Point(792, 71);
            button_searc.Name = "button_searc";
            button_searc.Size = new Size(105, 33);
            button_searc.TabIndex = 76;
            button_searc.Text = "Search";
            button_searc.UseVisualStyleBackColor = false;
            button_searc.Click += button_searc_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Teal;
            panel3.Location = new Point(12, 515);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 8);
            panel3.TabIndex = 73;
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton_female.ForeColor = Color.Teal;
            radioButton_female.Location = new Point(248, 3);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(84, 23);
            radioButton_female.TabIndex = 68;
            radioButton_female.Text = "FeMale";
            radioButton_female.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // button_print
            // 
            button_print.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_print.BackColor = Color.Teal;
            button_print.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_print.ForeColor = Color.White;
            button_print.Location = new Point(1515, 4);
            button_print.Name = "button_print";
            button_print.Size = new Size(105, 33);
            button_print.TabIndex = 67;
            button_print.Text = "Print";
            button_print.UseVisualStyleBackColor = false;
            // 
            // radioButton_male
            // 
            radioButton_male.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_male.AutoSize = true;
            radioButton_male.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton_male.ForeColor = Color.Teal;
            radioButton_male.Location = new Point(176, 3);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(66, 23);
            radioButton_male.TabIndex = 65;
            radioButton_male.Text = "Male";
            radioButton_male.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_all
            // 
            radioButton_all.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_all.AutoSize = true;
            radioButton_all.Checked = true;
            radioButton_all.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton_all.ForeColor = Color.Teal;
            radioButton_all.Location = new Point(114, 3);
            radioButton_all.Name = "radioButton_all";
            radioButton_all.Size = new Size(47, 23);
            radioButton_all.TabIndex = 64;
            radioButton_all.TabStop = true;
            radioButton_all.Text = "All";
            radioButton_all.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(20, 5);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 63;
            label4.Text = "Gender :";
            // 
            // textBox_id
            // 
            textBox_id.Anchor = AnchorStyles.None;
            textBox_id.Location = new Point(1378, 113);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(121, 27);
            textBox_id.TabIndex = 62;
            // 
            // label_id
            // 
            label_id.Anchor = AnchorStyles.None;
            label_id.AutoSize = true;
            label_id.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_id.ForeColor = Color.Teal;
            label_id.Location = new Point(1314, 113);
            label_id.Name = "label_id";
            label_id.Size = new Size(58, 19);
            label_id.TabIndex = 61;
            label_id.Text = "Id No :";
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(2049, 134);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(96, 33);
            button_clear.TabIndex = 60;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.OrangeRed;
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(2151, 134);
            button_update.Name = "button_update";
            button_update.Size = new Size(96, 33);
            button_update.TabIndex = 58;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(2253, 134);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(96, 33);
            button_delete.TabIndex = 57;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            // 
            // textBox_phone
            // 
            textBox_phone.Anchor = AnchorStyles.None;
            textBox_phone.Location = new Point(1332, -7);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(167, 27);
            textBox_phone.TabIndex = 56;
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.None;
            button_upload.BackColor = Color.DarkGreen;
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(1528, 109);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(105, 33);
            button_upload.TabIndex = 54;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            // 
            // pictureBox_employee
            // 
            pictureBox_employee.Anchor = AnchorStyles.None;
            pictureBox_employee.BackColor = SystemColors.ActiveBorder;
            pictureBox_employee.Location = new Point(1528, -19);
            pictureBox_employee.Name = "pictureBox_employee";
            pictureBox_employee.Size = new Size(105, 122);
            pictureBox_employee.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_employee.TabIndex = 53;
            pictureBox_employee.TabStop = false;
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
            DataGridViewCourses.Location = new Point(12, 120);
            DataGridViewCourses.Name = "DataGridViewCourses";
            DataGridViewCourses.RowHeadersVisible = false;
            DataGridViewCourses.RowTemplate.Height = 80;
            DataGridViewCourses.Size = new Size(910, 389);
            DataGridViewCourses.TabIndex = 70;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(310, 19);
            label7.Name = "label7";
            label7.Size = new Size(294, 28);
            label7.TabIndex = 0;
            label7.Text = "Draexlmaier Training List";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 58);
            panel1.TabIndex = 71;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(radioButton_female);
            panel2.Controls.Add(button_print);
            panel2.Controls.Add(radioButton_male);
            panel2.Controls.Add(radioButton_all);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox_id);
            panel2.Controls.Add(label_id);
            panel2.Controls.Add(button_clear);
            panel2.Controls.Add(button_update);
            panel2.Controls.Add(button_delete);
            panel2.Controls.Add(textBox_phone);
            panel2.Controls.Add(button_upload);
            panel2.Controls.Add(pictureBox_employee);
            panel2.Location = new Point(12, 529);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 76);
            panel2.TabIndex = 72;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(780, 37);
            button1.Name = "button1";
            button1.Size = new Size(105, 33);
            button1.TabIndex = 78;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(621, 74);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(165, 27);
            textBox_search.TabIndex = 77;
            // 
            // PrintCourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(textBox_search);
            Controls.Add(button_searc);
            Controls.Add(panel3);
            Controls.Add(DataGridViewCourses);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "PrintCourseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrintCourseForm";
            Load += PrintCourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_employee).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCourses).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_searc;
        private Panel panel3;
        private RadioButton radioButton_female;
        private Button button_print;
        private RadioButton radioButton_male;
        private RadioButton radioButton_all;
        private Label label4;
        private TextBox textBox_id;
        private Label label_id;
        private Button button_clear;
        private Button button_update;
        private Button button_delete;
        private TextBox textBox_phone;
        private Button button_upload;
        private PictureBox pictureBox_employee;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewCourses;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox_search;
        private Button button1;
    }
}