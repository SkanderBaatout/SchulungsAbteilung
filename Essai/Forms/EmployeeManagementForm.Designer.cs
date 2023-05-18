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
            btnDeleteEmployee = new Guna.UI2.WinForms.Guna2Button();
            dgvEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            label4 = new Label();
            btnEditEmployee = new Guna.UI2.WinForms.Guna2Button();
            btnAddEmployee = new Guna.UI2.WinForms.Guna2Button();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            tbSearchKeyword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
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
            btnDeleteEmployee.Location = new Point(594, 78);
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
            dgvEmployees.Location = new Point(0, 149);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowTemplate.Height = 24;
            dgvEmployees.Size = new Size(950, 501);
            dgvEmployees.TabIndex = 58;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvEmployees.ThemeStyle.BackColor = Color.White;
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
            dgvEmployees.ThemeStyle.RowsStyle.ForeColor = Color.Teal;
            dgvEmployees.ThemeStyle.RowsStyle.Height = 24;
            dgvEmployees.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvEmployees.ThemeStyle.RowsStyle.SelectionForeColor = Color.Teal;
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(330, 9);
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
            btnEditEmployee.Location = new Point(353, 78);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.ShadowDecoration.BorderRadius = 15;
            btnEditEmployee.ShadowDecoration.Color = Color.Transparent;
            btnEditEmployee.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEditEmployee.Size = new Size(195, 45);
            btnEditEmployee.TabIndex = 56;
            btnEditEmployee.Text = "Edit Employee";
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BorderRadius = 15;
            btnAddEmployee.CustomizableEdges = customizableEdges5;
            btnAddEmployee.DisabledState.BorderColor = Color.DarkGray;
            btnAddEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddEmployee.FillColor = Color.Teal;
            btnAddEmployee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(126, 78);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.ShadowDecoration.BorderRadius = 15;
            btnAddEmployee.ShadowDecoration.Color = Color.Transparent;
            btnAddEmployee.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddEmployee.Size = new Size(195, 45);
            btnAddEmployee.TabIndex = 54;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnSearch
            // 
            btnSearch.BorderRadius = 15;
            btnSearch.CustomizableEdges = customizableEdges7;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.DarkSlateGray;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(804, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.BorderRadius = 15;
            btnSearch.ShadowDecoration.Color = Color.Transparent;
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSearch.Size = new Size(119, 29);
            btnSearch.TabIndex = 68;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearchKeyword
            // 
            tbSearchKeyword.Location = new Point(631, 14);
            tbSearchKeyword.Name = "tbSearchKeyword";
            tbSearchKeyword.Size = new Size(167, 27);
            tbSearchKeyword.TabIndex = 69;
            // 
            // EmployeeManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(tbSearchKeyword);
            Controls.Add(btnSearch);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(dgvEmployees);
            Controls.Add(label4);
            Controls.Add(btnEditEmployee);
            Controls.Add(btnAddEmployee);
            Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "EmployeeManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeManagementForm";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDeleteEmployee;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmployees;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button btnEditEmployee;
        private Guna.UI2.WinForms.Guna2Button btnAddEmployee;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private TextBox tbSearchKeyword;
    }
}