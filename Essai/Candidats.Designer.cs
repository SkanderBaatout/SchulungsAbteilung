namespace Essai
{
    partial class Candidats
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Candidats));
            label4 = new Label();
            candidatesList = new Guna.UI2.WinForms.Guna2DataGridView();
            EditBtn = new Guna.UI2.WinForms.Guna2Button();
            ResetBtn = new Guna.UI2.WinForms.Guna2Button();
            SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            CCin = new MaskedTextBox();
            CPassword = new MaskedTextBox();
            CPhone = new MaskedTextBox();
            CName = new MaskedTextBox();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker = new DateTimePicker();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)candidatesList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(340, 319);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(190, 28);
            label4.TabIndex = 32;
            label4.Text = "Candidates List";
            // 
            // candidatesList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            candidatesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            candidatesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            candidatesList.ColumnHeadersHeight = 25;
            candidatesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            candidatesList.DefaultCellStyle = dataGridViewCellStyle3;
            candidatesList.GridColor = Color.FromArgb(231, 229, 255);
            candidatesList.Location = new Point(8, 360);
            candidatesList.Name = "candidatesList";
            candidatesList.RowHeadersVisible = false;
            candidatesList.RowTemplate.Height = 24;
            candidatesList.Size = new Size(871, 278);
            candidatesList.TabIndex = 31;
            candidatesList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            candidatesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            candidatesList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            candidatesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            candidatesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            candidatesList.ThemeStyle.BackColor = Color.White;
            candidatesList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            candidatesList.ThemeStyle.HeaderStyle.BackColor = Color.Black;
            candidatesList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            candidatesList.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            candidatesList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            candidatesList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            candidatesList.ThemeStyle.HeaderStyle.Height = 25;
            candidatesList.ThemeStyle.ReadOnly = false;
            candidatesList.ThemeStyle.RowsStyle.BackColor = Color.White;
            candidatesList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            candidatesList.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            candidatesList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            candidatesList.ThemeStyle.RowsStyle.Height = 24;
            candidatesList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            candidatesList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            candidatesList.CellContentClick += candidatesList_CellContentClick;
            // 
            // EditBtn
            // 
            EditBtn.BorderRadius = 15;
            EditBtn.CustomizableEdges = customizableEdges1;
            EditBtn.DisabledState.BorderColor = Color.DarkGray;
            EditBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            EditBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            EditBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            EditBtn.FillColor = Color.White;
            EditBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.Teal;
            EditBtn.Location = new Point(283, 258);
            EditBtn.Name = "EditBtn";
            EditBtn.ShadowDecoration.BorderRadius = 15;
            EditBtn.ShadowDecoration.Color = Color.Transparent;
            EditBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            EditBtn.Size = new Size(180, 35);
            EditBtn.TabIndex = 30;
            EditBtn.Text = "Edit";
            EditBtn.Click += EditBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BorderRadius = 15;
            ResetBtn.CustomizableEdges = customizableEdges3;
            ResetBtn.DisabledState.BorderColor = Color.DarkGray;
            ResetBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ResetBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ResetBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ResetBtn.FillColor = Color.White;
            ResetBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ResetBtn.ForeColor = Color.Teal;
            ResetBtn.Location = new Point(493, 258);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.ShadowDecoration.BorderRadius = 15;
            ResetBtn.ShadowDecoration.Color = Color.Transparent;
            ResetBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ResetBtn.Size = new Size(180, 35);
            ResetBtn.TabIndex = 29;
            ResetBtn.Text = "Reset";
            ResetBtn.Click += ResetBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BorderRadius = 15;
            SaveBtn.CustomizableEdges = customizableEdges5;
            SaveBtn.DisabledState.BorderColor = Color.DarkGray;
            SaveBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SaveBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SaveBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SaveBtn.FillColor = Color.White;
            SaveBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.Teal;
            SaveBtn.Location = new Point(64, 258);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.ShadowDecoration.BorderRadius = 15;
            SaveBtn.ShadowDecoration.Color = Color.Transparent;
            SaveBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            SaveBtn.Size = new Size(180, 35);
            SaveBtn.TabIndex = 28;
            SaveBtn.Text = "Save";
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CCin
            // 
            CCin.BeepOnError = true;
            CCin.Location = new Point(309, 113);
            CCin.Name = "CCin";
            CCin.Size = new Size(256, 27);
            CCin.TabIndex = 26;
            CCin.Text = "Cin";
            CCin.TextAlign = HorizontalAlignment.Center;
            // 
            // CPassword
            // 
            CPassword.BeepOnError = true;
            CPassword.Location = new Point(110, 176);
            CPassword.Name = "CPassword";
            CPassword.Size = new Size(256, 27);
            CPassword.TabIndex = 24;
            CPassword.Text = "Password";
            CPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // CPhone
            // 
            CPhone.BeepOnError = true;
            CPhone.Location = new Point(465, 176);
            CPhone.Name = "CPhone";
            CPhone.Size = new Size(256, 27);
            CPhone.TabIndex = 23;
            CPhone.Text = "Phone";
            CPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // CName
            // 
            CName.BeepOnError = true;
            CName.Location = new Point(31, 113);
            CName.Name = "CName";
            CName.Size = new Size(237, 27);
            CName.TabIndex = 21;
            CName.Text = "Name";
            CName.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(519, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 5);
            panel1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(367, 12);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 19;
            label3.Text = "Subjects";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(519, 12);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 18;
            label2.Text = "Candidates";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(208, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 17;
            label1.Text = "Questions";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(610, 113);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(260, 27);
            dateTimePicker.TabIndex = 34;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Candidats
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(950, 650);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker);
            Controls.Add(label4);
            Controls.Add(candidatesList);
            Controls.Add(EditBtn);
            Controls.Add(ResetBtn);
            Controls.Add(SaveBtn);
            Controls.Add(CCin);
            Controls.Add(CPassword);
            Controls.Add(CPhone);
            Controls.Add(CName);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Candidats";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Candidats";
            ((System.ComponentModel.ISupportInitialize)candidatesList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView candidatesList;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private Guna.UI2.WinForms.Guna2Button ResetBtn;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private MaskedTextBox CCin;
        private MaskedTextBox CPassword;
        private MaskedTextBox CPhone;
        private MaskedTextBox CName;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private PictureBox pictureBox1;
    }
}