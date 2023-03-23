namespace Essai
{
    partial class RegisterForm
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
            DataGridViewEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            button_clear = new Button();
            button_add = new Button();
            textBox_phone = new TextBox();
            label6 = new Label();
            button_upload = new Button();
            pictureBox_employee = new PictureBox();
            textBox_address = new TextBox();
            label5 = new Label();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox_lastName = new TextBox();
            label2 = new Label();
            textBox_firstName = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEmployees).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_employee).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewEmployees
            // 
            DataGridViewEmployees.AllowUserToAddRows = false;
            DataGridViewEmployees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            DataGridViewEmployees.Location = new Point(12, 70);
            DataGridViewEmployees.Name = "DataGridViewEmployees";
            DataGridViewEmployees.RowHeadersVisible = false;
            DataGridViewEmployees.RowTemplate.Height = 80;
            DataGridViewEmployees.Size = new Size(910, 255);
            DataGridViewEmployees.TabIndex = 3;
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
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 58);
            panel1.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(389, 18);
            label7.Name = "label7";
            label7.Size = new Size(147, 28);
            label7.TabIndex = 0;
            label7.Text = "Registration";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(button_clear);
            panel2.Controls.Add(button_add);
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
            panel2.Location = new Point(0, 354);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 257);
            panel2.TabIndex = 20;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(719, 204);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(96, 33);
            button_clear.TabIndex = 37;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click_1;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.SteelBlue;
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(821, 204);
            button_add.Name = "button_add";
            button_add.Size = new Size(96, 33);
            button_add.TabIndex = 36;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click_1;
            // 
            // textBox_phone
            // 
            textBox_phone.Anchor = AnchorStyles.None;
            textBox_phone.Location = new Point(605, 43);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(172, 27);
            textBox_phone.TabIndex = 35;
            textBox_phone.TextChanged += textBox_phone_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(533, 44);
            label6.Name = "label6";
            label6.Size = new Size(66, 19);
            label6.TabIndex = 34;
            label6.Text = "Phone :";
            label6.Click += label6_Click;
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_upload.BackColor = Color.DarkGreen;
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(793, 155);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(105, 33);
            button_upload.TabIndex = 33;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click_1;
            // 
            // pictureBox_employee
            // 
            pictureBox_employee.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox_employee.BackColor = SystemColors.ActiveBorder;
            pictureBox_employee.Location = new Point(793, 27);
            pictureBox_employee.Name = "pictureBox_employee";
            pictureBox_employee.Size = new Size(105, 122);
            pictureBox_employee.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_employee.TabIndex = 32;
            pictureBox_employee.TabStop = false;
            // 
            // textBox_address
            // 
            textBox_address.Anchor = AnchorStyles.None;
            textBox_address.Location = new Point(108, 160);
            textBox_address.Multiline = true;
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(500, 45);
            textBox_address.TabIndex = 31;
            textBox_address.TextChanged += textBox_address_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(15, 160);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 30;
            label5.Text = "Address :";
            label5.Click += label5_Click;
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.None;
            radioButton_female.AutoSize = true;
            radioButton_female.ForeColor = Color.Teal;
            radioButton_female.Location = new Point(575, 100);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(86, 23);
            radioButton_female.TabIndex = 29;
            radioButton_female.Text = "Female";
            radioButton_female.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.Anchor = AnchorStyles.None;
            radioButton_male.AutoSize = true;
            radioButton_male.Checked = true;
            radioButton_male.ForeColor = Color.Teal;
            radioButton_male.Location = new Point(501, 100);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(66, 23);
            radioButton_male.TabIndex = 28;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(407, 102);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 27;
            label4.Text = "Gender :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(138, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 26;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(15, 102);
            label3.Name = "label3";
            label3.Size = new Size(110, 19);
            label3.TabIndex = 25;
            label3.Text = "Date Of Birth :";
            // 
            // textBox_lastName
            // 
            textBox_lastName.Anchor = AnchorStyles.None;
            textBox_lastName.Location = new Point(376, 44);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(151, 27);
            textBox_lastName.TabIndex = 24;
            textBox_lastName.TextChanged += textBox_lastName_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(272, 44);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 23;
            label2.Text = "Last Name :";
            label2.Click += label2_Click;
            // 
            // textBox_firstName
            // 
            textBox_firstName.Anchor = AnchorStyles.None;
            textBox_firstName.Location = new Point(120, 44);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(146, 27);
            textBox_firstName.TabIndex = 22;
            textBox_firstName.TextChanged += textBox_firstName_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(15, 43);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 21;
            label1.Text = "First Name :";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Teal;
            panel3.Location = new Point(12, 340);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 8);
            panel3.TabIndex = 38;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DataGridViewEmployees);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MinimumSize = new Size(950, 650);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewEmployees).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_employee).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewEmployees;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Panel panel3;
        private Button button_clear;
        private Button button_add;
        private TextBox textBox_phone;
        private Label label6;
        private Button button_upload;
        private PictureBox pictureBox_employee;
        private TextBox textBox_address;
        private Label label5;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox_lastName;
        private Label label2;
        private TextBox textBox_firstName;
        private Label label1;
    }
}