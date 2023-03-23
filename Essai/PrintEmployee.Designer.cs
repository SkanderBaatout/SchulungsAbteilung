namespace Essai
{
    partial class PrintEmployee
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
            panel1 = new Panel();
            label7 = new Label();
            DataGridViewEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            textBox_id = new TextBox();
            label_id = new Label();
            panel2 = new Panel();
            radioButton_female = new RadioButton();
            button_print = new Button();
            radioButton_male = new RadioButton();
            radioButton_all = new RadioButton();
            label4 = new Label();
            button_clear = new Button();
            button_update = new Button();
            button_delete = new Button();
            button_upload = new Button();
            pictureBox_employee = new PictureBox();
            panel3 = new Panel();
            comboBox_session = new ComboBox();
            label1 = new Label();
            button_searc = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEmployees).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_employee).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 58);
            panel1.TabIndex = 64;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(353, 18);
            label7.Name = "label7";
            label7.Size = new Size(92, 28);
            label7.TabIndex = 0;
            label7.Text = "To Print";
            label7.Click += label7_Click;
            // 
            // DataGridViewEmployees
            // 
            DataGridViewEmployees.AllowUserToAddRows = false;
            DataGridViewEmployees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DataGridViewEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewEmployees.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DataGridViewEmployees.ColumnHeadersHeight = 24;
            DataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataGridViewEmployees.DefaultCellStyle = dataGridViewCellStyle6;
            DataGridViewEmployees.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewEmployees.Location = new Point(12, 114);
            DataGridViewEmployees.Name = "DataGridViewEmployees";
            DataGridViewEmployees.RowHeadersVisible = false;
            DataGridViewEmployees.RowTemplate.Height = 80;
            DataGridViewEmployees.Size = new Size(910, 389);
            DataGridViewEmployees.TabIndex = 63;
            DataGridViewEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridViewEmployees.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridViewEmployees.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridViewEmployees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridViewEmployees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridViewEmployees.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridViewEmployees.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewEmployees.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridViewEmployees.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewEmployees.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridViewEmployees.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridViewEmployees.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridViewEmployees.ThemeStyle.HeaderStyle.Height = 24;
            DataGridViewEmployees.ThemeStyle.ReadOnly = false;
            DataGridViewEmployees.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridViewEmployees.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewEmployees.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridViewEmployees.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewEmployees.ThemeStyle.RowsStyle.Height = 80;
            DataGridViewEmployees.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridViewEmployees.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewEmployees.CellContentClick += DataGridViewEmployees_CellContentClick;
            // 
            // textBox_id
            // 
            textBox_id.Anchor = AnchorStyles.None;
            textBox_id.Location = new Point(1023, 125);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(121, 23);
            textBox_id.TabIndex = 62;
            textBox_id.TextChanged += textBox_id_TextChanged;
            // 
            // label_id
            // 
            label_id.Anchor = AnchorStyles.None;
            label_id.AutoSize = true;
            label_id.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_id.ForeColor = Color.Teal;
            label_id.Location = new Point(959, 125);
            label_id.Name = "label_id";
            label_id.Size = new Size(58, 19);
            label_id.TabIndex = 61;
            label_id.Text = "Id No :";
            label_id.Click += label_id_Click;
            // 
            // panel2
            // 
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
            panel2.Controls.Add(button_upload);
            panel2.Controls.Add(pictureBox_employee);
            panel2.Location = new Point(0, 523);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 76);
            panel2.TabIndex = 65;
            panel2.Paint += panel2_Paint;
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton_female.ForeColor = Color.Teal;
            radioButton_female.Location = new Point(240, 17);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(84, 23);
            radioButton_female.TabIndex = 68;
            radioButton_female.Text = "FeMale";
            radioButton_female.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_female.UseVisualStyleBackColor = true;
            radioButton_female.CheckedChanged += radioButton_female_CheckedChanged;
            // 
            // button_print
            // 
            button_print.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_print.BackColor = Color.Teal;
            button_print.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_print.ForeColor = Color.White;
            button_print.Location = new Point(805, 28);
            button_print.Name = "button_print";
            button_print.Size = new Size(105, 33);
            button_print.TabIndex = 67;
            button_print.Text = "Print";
            button_print.UseVisualStyleBackColor = false;
            button_print.Click += button_print_Click;
            // 
            // radioButton_male
            // 
            radioButton_male.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_male.AutoSize = true;
            radioButton_male.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton_male.ForeColor = Color.Teal;
            radioButton_male.Location = new Point(168, 17);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(66, 23);
            radioButton_male.TabIndex = 65;
            radioButton_male.Text = "Male";
            radioButton_male.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_male.UseVisualStyleBackColor = true;
            radioButton_male.CheckedChanged += radioButton_male_CheckedChanged;
            // 
            // radioButton_all
            // 
            radioButton_all.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_all.AutoSize = true;
            radioButton_all.Checked = true;
            radioButton_all.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton_all.ForeColor = Color.Teal;
            radioButton_all.Location = new Point(106, 17);
            radioButton_all.Name = "radioButton_all";
            radioButton_all.Size = new Size(47, 23);
            radioButton_all.TabIndex = 64;
            radioButton_all.TabStop = true;
            radioButton_all.Text = "All";
            radioButton_all.UseVisualStyleBackColor = true;
            radioButton_all.CheckedChanged += radioButton_all_CheckedChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(12, 19);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 63;
            label4.Text = "Gender :";
            label4.Click += label4_Click;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(1339, 158);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(96, 33);
            button_clear.TabIndex = 60;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.OrangeRed;
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(1441, 158);
            button_update.Name = "button_update";
            button_update.Size = new Size(96, 33);
            button_update.TabIndex = 58;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(1543, 158);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(96, 33);
            button_delete.TabIndex = 57;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.None;
            button_upload.BackColor = Color.DarkGreen;
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(1173, 121);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(105, 33);
            button_upload.TabIndex = 54;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // pictureBox_employee
            // 
            pictureBox_employee.Anchor = AnchorStyles.None;
            pictureBox_employee.BackColor = SystemColors.ActiveBorder;
            pictureBox_employee.Location = new Point(1173, -7);
            pictureBox_employee.Name = "pictureBox_employee";
            pictureBox_employee.Size = new Size(105, 122);
            pictureBox_employee.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_employee.TabIndex = 53;
            pictureBox_employee.TabStop = false;
            pictureBox_employee.Click += pictureBox_employee_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Teal;
            panel3.Location = new Point(12, 509);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 8);
            panel3.TabIndex = 66;
            panel3.Paint += panel3_Paint;
            // 
            // comboBox_session
            // 
            comboBox_session.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox_session.FormattingEnabled = true;
            comboBox_session.Location = new Point(605, 72);
            comboBox_session.Name = "comboBox_session";
            comboBox_session.Size = new Size(181, 23);
            comboBox_session.TabIndex = 67;
            comboBox_session.SelectedIndexChanged += comboBox_session_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(440, 72);
            label1.Name = "label1";
            label1.Size = new Size(159, 19);
            label1.TabIndex = 68;
            label1.Text = "Select Department :";
            label1.Click += label1_Click;
            // 
            // button_searc
            // 
            button_searc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_searc.BackColor = Color.Teal;
            button_searc.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_searc.ForeColor = Color.White;
            button_searc.Location = new Point(792, 65);
            button_searc.Name = "button_searc";
            button_searc.Size = new Size(105, 33);
            button_searc.TabIndex = 69;
            button_searc.Text = "Search";
            button_searc.UseVisualStyleBackColor = false;
            button_searc.Click += button_searc_Click;
            // 
            // PrintEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(button_searc);
            Controls.Add(label1);
            Controls.Add(comboBox_session);
            Controls.Add(panel1);
            Controls.Add(DataGridViewEmployees);
            Controls.Add(panel2);
            Controls.Add(panel3);
            MinimumSize = new Size(950, 650);
            Name = "PrintEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrintEmployee";
            Load += PrintEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEmployees).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_employee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_search;
        private Panel panel1;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewEmployees;
        private TextBox textBox_id;
        private Label label_id;
        private Panel panel2;
        private Button button_clear;
        private Button button_update;
        private Button button_delete;
        private Button button_upload;
        private PictureBox pictureBox_employee;
        private Panel panel3;
        private Button button_search;
        private RadioButton radioButton_all;
        private RadioButton radioButton1;
        private RadioButton radioButton_male;
        private Label label4;
        private Button button_print;
        private ComboBox comboBox_session;
        private Label label1;
        private RadioButton radioButton_female;
        private Button button_searc;
    }
}