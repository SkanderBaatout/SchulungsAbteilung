namespace Essai
{
    partial class EmployeeManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagementForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            btnDeleteEmployee = new Guna.UI2.WinForms.Guna2Button();
            dgvEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            label4 = new Label();
            btnEditEmployee = new Guna.UI2.WinForms.Guna2Button();
            resetbtn = new Guna.UI2.WinForms.Guna2Button();
            btnAddEmployee = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BorderRadius = 15;
            btnDeleteEmployee.CustomizableEdges = customizableEdges1;
            btnDeleteEmployee.DisabledState.BorderColor = Color.DarkGray;
            btnDeleteEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeleteEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeleteEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeleteEmployee.Enabled = false;
            btnDeleteEmployee.FillColor = Color.OrangeRed;
            btnDeleteEmployee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteEmployee.ForeColor = Color.White;
            btnDeleteEmployee.Location = new Point(518, 68);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.PressedColor = Color.AntiqueWhite;
            btnDeleteEmployee.ShadowDecoration.BorderRadius = 15;
            btnDeleteEmployee.ShadowDecoration.Color = Color.Transparent;
            btnDeleteEmployee.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDeleteEmployee.Size = new Size(196, 45);
            btnDeleteEmployee.TabIndex = 67;
            btnDeleteEmployee.Text = "Delete Employee";
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // dgvEmployees
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployees.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployees.ColumnHeadersHeight = 25;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployees.Dock = DockStyle.Bottom;
            dgvEmployees.GridColor = Color.FromArgb(231, 229, 255);
            dgvEmployees.Location = new Point(0, 131);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowTemplate.Height = 24;
            dgvEmployees.Size = new Size(950, 519);
            dgvEmployees.TabIndex = 58;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvEmployees.ThemeStyle.BackColor = Color.Gainsboro;
            dgvEmployees.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvEmployees.ThemeStyle.HeaderStyle.BackColor = Color.Black;
            dgvEmployees.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmployees.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvEmployees.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvEmployees.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvEmployees.ThemeStyle.HeaderStyle.Height = 25;
            dgvEmployees.ThemeStyle.ReadOnly = true;
            dgvEmployees.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvEmployees.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployees.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvEmployees.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvEmployees.ThemeStyle.RowsStyle.Height = 24;
            dgvEmployees.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvEmployees.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(366, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(181, 28);
            label4.TabIndex = 57;
            label4.Text = "Employees List";
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.BorderRadius = 15;
            btnEditEmployee.CustomizableEdges = customizableEdges3;
            btnEditEmployee.DisabledState.BorderColor = Color.DarkGray;
            btnEditEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditEmployee.Enabled = false;
            btnEditEmployee.FillColor = Color.FromArgb(255, 128, 0);
            btnEditEmployee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditEmployee.ForeColor = Color.White;
            btnEditEmployee.Location = new Point(277, 68);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.ShadowDecoration.BorderRadius = 15;
            btnEditEmployee.ShadowDecoration.Color = Color.Transparent;
            btnEditEmployee.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEditEmployee.Size = new Size(195, 45);
            btnEditEmployee.TabIndex = 56;
            btnEditEmployee.Text = "Edit Employee";
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // resetbtn
            // 
            resetbtn.BorderRadius = 15;
            resetbtn.CustomizableEdges = customizableEdges5;
            resetbtn.DisabledState.BorderColor = Color.DarkGray;
            resetbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            resetbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            resetbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            resetbtn.FillColor = Color.DarkTurquoise;
            resetbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.ForeColor = Color.White;
            resetbtn.Location = new Point(756, 68);
            resetbtn.Name = "resetbtn";
            resetbtn.ShadowDecoration.BorderRadius = 15;
            resetbtn.ShadowDecoration.Color = Color.Transparent;
            resetbtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            resetbtn.Size = new Size(167, 45);
            resetbtn.TabIndex = 55;
            resetbtn.Text = "Reset";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BorderRadius = 15;
            btnAddEmployee.CustomizableEdges = customizableEdges7;
            btnAddEmployee.DisabledState.BorderColor = Color.DarkGray;
            btnAddEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddEmployee.FillColor = Color.Teal;
            btnAddEmployee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(50, 68);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.ShadowDecoration.BorderRadius = 15;
            btnAddEmployee.ShadowDecoration.Color = Color.Transparent;
            btnAddEmployee.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAddEmployee.Size = new Size(195, 45);
            btnAddEmployee.TabIndex = 54;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // EmployeeManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 650);
            Controls.Add(pictureBox1);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(dgvEmployees);
            Controls.Add(label4);
            Controls.Add(btnEditEmployee);
            Controls.Add(resetbtn);
            Controls.Add(btnAddEmployee);
            Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "EmployeeManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeManagementForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDeleteEmployee;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmployees;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button btnEditEmployee;
        private Guna.UI2.WinForms.Guna2Button resetbtn;
        private Guna.UI2.WinForms.Guna2Button btnAddEmployee;
    }
}