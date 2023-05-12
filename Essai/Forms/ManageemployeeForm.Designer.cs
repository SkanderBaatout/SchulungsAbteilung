namespace Essai
{
    partial class ManageemployeeForm
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
            label1 = new Label();
            textBox_firstName = new TextBox();
            label2 = new Label();
            textBox_lastName = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            radioButton_male = new RadioButton();
            radioButton_female = new RadioButton();
            label5 = new Label();
            textBox_address = new TextBox();
            pictureBox_employee = new PictureBox();
            button_upload = new Button();
            label6 = new Label();
            textBox_phone = new TextBox();
            button_delete = new Button();
            button_update = new Button();
            panel3 = new Panel();
            button_clear = new Button();
            panel2 = new Panel();
            textBox_id = new TextBox();
            label_id = new Label();
            label7 = new Label();
            panel1 = new Panel();
            DataGridViewEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            button_search = new Button();
            textBox_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_employee).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(26, 17);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 42;
            label1.Text = "First Name :";
            // 
            // textBox_firstName
            // 
            textBox_firstName.Anchor = AnchorStyles.None;
            textBox_firstName.Location = new Point(131, 18);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(146, 27);
            textBox_firstName.TabIndex = 43;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(283, 18);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 44;
            label2.Text = "Last Name :";
            // 
            // textBox_lastName
            // 
            textBox_lastName.Anchor = AnchorStyles.None;
            textBox_lastName.Location = new Point(387, 18);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(151, 27);
            textBox_lastName.TabIndex = 45;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(26, 77);
            label3.Name = "label3";
            label3.Size = new Size(110, 19);
            label3.TabIndex = 46;
            label3.Text = "Date Of Birth :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(142, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(263, 27);
            dateTimePicker1.TabIndex = 47;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(431, 79);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 48;
            label4.Text = "Gender :";
            // 
            // radioButton_male
            // 
            radioButton_male.Anchor = AnchorStyles.None;
            radioButton_male.AutoSize = true;
            radioButton_male.Checked = true;
            radioButton_male.ForeColor = Color.Teal;
            radioButton_male.Location = new Point(525, 77);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(67, 23);
            radioButton_male.TabIndex = 49;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.None;
            radioButton_female.AutoSize = true;
            radioButton_female.ForeColor = Color.Teal;
            radioButton_female.Location = new Point(599, 77);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(86, 23);
            radioButton_female.TabIndex = 50;
            radioButton_female.Text = "Female";
            radioButton_female.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(26, 124);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 51;
            label5.Text = "Address :";
            // 
            // textBox_address
            // 
            textBox_address.Anchor = AnchorStyles.None;
            textBox_address.Location = new Point(110, 124);
            textBox_address.Multiline = true;
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(477, 55);
            textBox_address.TabIndex = 52;
            // 
            // pictureBox_employee
            // 
            pictureBox_employee.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox_employee.BackColor = SystemColors.ActiveBorder;
            pictureBox_employee.Location = new Point(812, 5);
            pictureBox_employee.Name = "pictureBox_employee";
            pictureBox_employee.Size = new Size(105, 122);
            pictureBox_employee.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_employee.TabIndex = 53;
            pictureBox_employee.TabStop = false;
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_upload.BackColor = Color.DarkGreen;
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(812, 133);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(105, 33);
            button_upload.TabIndex = 54;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(544, 18);
            label6.Name = "label6";
            label6.Size = new Size(66, 19);
            label6.TabIndex = 55;
            label6.Text = "Phone :";
            // 
            // textBox_phone
            // 
            textBox_phone.Anchor = AnchorStyles.None;
            textBox_phone.Location = new Point(616, 17);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(167, 27);
            textBox_phone.TabIndex = 56;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(821, 182);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(96, 33);
            button_delete.TabIndex = 57;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.OrangeRed;
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(719, 182);
            button_update.Name = "button_update";
            button_update.Size = new Size(96, 33);
            button_update.TabIndex = 58;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Teal;
            panel3.Location = new Point(12, 372);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 8);
            panel3.TabIndex = 59;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(617, 182);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(96, 33);
            button_clear.TabIndex = 60;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(textBox_id);
            panel2.Controls.Add(label_id);
            panel2.Controls.Add(button_clear);
            panel2.Controls.Add(button_update);
            panel2.Controls.Add(button_delete);
            panel2.Controls.Add(textBox_phone);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button_upload);
            panel2.Controls.Add(pictureBox_employee);
            panel2.Controls.Add(textBox_address);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(radioButton_female);
            panel2.Controls.Add(radioButton_male);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_lastName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_firstName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 386);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 225);
            panel2.TabIndex = 40;
            // 
            // textBox_id
            // 
            textBox_id.Anchor = AnchorStyles.None;
            textBox_id.Location = new Point(662, 137);
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
            label_id.Location = new Point(598, 137);
            label_id.Name = "label_id";
            label_id.Size = new Size(58, 19);
            label_id.TabIndex = 61;
            label_id.Text = "Id No :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(353, 18);
            label7.Name = "label7";
            label7.Size = new Size(234, 28);
            label7.TabIndex = 0;
            label7.Text = "Manage Employee";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 58);
            panel1.TabIndex = 39;
            // 
            // DataGridViewEmployees
            // 
            DataGridViewEmployees.AllowUserToAddRows = false;
            DataGridViewEmployees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewEmployees.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewEmployees.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewEmployees.ColumnHeadersHeight = 24;
            DataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewEmployees.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewEmployees.Location = new Point(12, 114);
            DataGridViewEmployees.Name = "DataGridViewEmployees";
            DataGridViewEmployees.RowHeadersVisible = false;
            DataGridViewEmployees.RowTemplate.Height = 80;
            DataGridViewEmployees.Size = new Size(910, 252);
            DataGridViewEmployees.TabIndex = 23;
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
            DataGridViewEmployees.Click += DataGridViewEmployees_Click;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.Orange;
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(812, 64);
            button_search.Name = "button_search";
            button_search.Size = new Size(98, 31);
            button_search.TabIndex = 61;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(602, 67);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(204, 27);
            textBox_search.TabIndex = 62;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // ManageemployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(textBox_search);
            Controls.Add(button_search);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(DataGridViewEmployees);
            Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimumSize = new Size(950, 650);
            Name = "ManageemployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageemployeeForm";
            Load += ManageemployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_employee).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_firstName;
        private Label label2;
        private TextBox textBox_lastName;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private RadioButton radioButton_male;
        private RadioButton radioButton_female;
        private Label label5;
        private TextBox textBox_address;
        private PictureBox pictureBox_employee;
        private Button button_upload;
        private Label label6;
        private TextBox textBox_phone;
        private Button button_delete;
        private Button button_update;
        private Panel panel3;
        private Button button_clear;
        private Panel panel2;
        private Label label7;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewEmployees;
        private Button button_search;
        private TextBox textBox_search;
        private TextBox textBox_id;
        private Label label_id;
    }
}