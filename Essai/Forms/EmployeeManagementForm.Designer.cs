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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagementForm));
            btnDeleteEmployee = new Guna.UI2.WinForms.Guna2Button();
            dgvEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            label4 = new Label();
            btnEditEmployee = new Guna.UI2.WinForms.Guna2Button();
            btnAddEmployee = new Guna.UI2.WinForms.Guna2Button();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            tbSearchKeyword = new TextBox();
            btnFirstPage = new PictureBox();
            btnPrevPage = new PictureBox();
            btnNextPage = new Button();
            lblPageNumber = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnFirstPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPrevPage).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BorderRadius = 15;
            btnDeleteEmployee.CustomizableEdges = customizableEdges9;
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
            btnDeleteEmployee.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnDeleteEmployee.Size = new Size(196, 45);
            btnDeleteEmployee.TabIndex = 67;
            btnDeleteEmployee.Text = "Delete Employee";
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // dgvEmployees
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvEmployees.ColumnHeadersHeight = 25;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle6;
            dgvEmployees.Dock = DockStyle.Bottom;
            dgvEmployees.GridColor = Color.FromArgb(231, 229, 255);
            dgvEmployees.Location = new Point(0, 262);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowTemplate.Height = 24;
            dgvEmployees.Size = new Size(950, 388);
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
            btnEditEmployee.CustomizableEdges = customizableEdges11;
            btnEditEmployee.DisabledState.BorderColor = Color.DarkGray;
            btnEditEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditEmployee.Enabled = false;
            btnEditEmployee.FillColor = Color.FromArgb(255, 128, 0);
            btnEditEmployee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditEmployee.ForeColor = Color.White;
            btnEditEmployee.Location = new Point(371, 78);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.ShadowDecoration.BorderRadius = 15;
            btnEditEmployee.ShadowDecoration.Color = Color.Transparent;
            btnEditEmployee.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnEditEmployee.Size = new Size(195, 45);
            btnEditEmployee.TabIndex = 56;
            btnEditEmployee.Text = "Edit Employee";
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BorderRadius = 15;
            btnAddEmployee.CustomizableEdges = customizableEdges13;
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
            btnAddEmployee.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnAddEmployee.Size = new Size(195, 45);
            btnAddEmployee.TabIndex = 54;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnSearch
            // 
            btnSearch.BorderRadius = 15;
            btnSearch.CustomizableEdges = customizableEdges15;
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
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges16;
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
            // btnFirstPage
            // 
            btnFirstPage.Image = (Image)resources.GetObject("btnFirstPage.Image");
            btnFirstPage.Location = new Point(537, 168);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(50, 22);
            btnFirstPage.SizeMode = PictureBoxSizeMode.Zoom;
            btnFirstPage.TabIndex = 70;
            btnFirstPage.TabStop = false;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Image = (Image)resources.GetObject("btnPrevPage.Image");
            btnPrevPage.Location = new Point(350, 168);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(50, 22);
            btnPrevPage.SizeMode = PictureBoxSizeMode.Zoom;
            btnPrevPage.TabIndex = 71;
            btnPrevPage.TabStop = false;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = Color.LightGray;
            btnNextPage.ForeColor = Color.Black;
            btnNextPage.Location = new Point(419, 155);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(102, 35);
            btnNextPage.TabIndex = 72;
            btnNextPage.Text = "Next Page";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.ForeColor = Color.Black;
            lblPageNumber.Location = new Point(419, 193);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(54, 20);
            lblPageNumber.TabIndex = 73;
            lblPageNumber.Text = "label1";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = btnNextPage;
            // 
            // EmployeeManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(lblPageNumber);
            Controls.Add(btnNextPage);
            Controls.Add(btnPrevPage);
            Controls.Add(btnFirstPage);
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
            Load += EmployeeManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnFirstPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPrevPage).EndInit();
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
        private PictureBox btnFirstPage;
        private PictureBox btnPrevPage;
        private Button btnNextPage;
        private Label lblPageNumber;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}