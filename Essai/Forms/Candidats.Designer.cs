﻿namespace Essai
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
            label4 = new Label();
            candidatesList = new Guna.UI2.WinForms.Guna2DataGridView();
            CCin = new MaskedTextBox();
            CPassword = new MaskedTextBox();
            CPhone = new MaskedTextBox();
            dateTimePicker = new DateTimePicker();
            CName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ResetBtn = new Guna.UI2.WinForms.Guna2Button();
            EditBtn = new Guna.UI2.WinForms.Guna2Button();
            SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)candidatesList).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(348, 304);
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
            candidatesList.Dock = DockStyle.Bottom;
            candidatesList.GridColor = Color.FromArgb(231, 229, 255);
            candidatesList.Location = new Point(0, 365);
            candidatesList.Name = "candidatesList";
            candidatesList.RowHeadersVisible = false;
            candidatesList.RowTemplate.Height = 24;
            candidatesList.Size = new Size(950, 285);
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
            candidatesList.ThemeStyle.RowsStyle.ForeColor = Color.Teal;
            candidatesList.ThemeStyle.RowsStyle.Height = 24;
            candidatesList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            candidatesList.ThemeStyle.RowsStyle.SelectionForeColor = Color.Teal;
            candidatesList.CellContentClick += candidatesList_CellContentClick;
            // 
            // CCin
            // 
            CCin.BeepOnError = true;
            CCin.Location = new Point(318, 78);
            CCin.Name = "CCin";
            CCin.Size = new Size(256, 27);
            CCin.TabIndex = 26;
            CCin.TextAlign = HorizontalAlignment.Center;
            // 
            // CPassword
            // 
            CPassword.BeepOnError = true;
            CPassword.Location = new Point(119, 141);
            CPassword.Name = "CPassword";
            CPassword.Size = new Size(256, 27);
            CPassword.TabIndex = 24;
            CPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // CPhone
            // 
            CPhone.BeepOnError = true;
            CPhone.Location = new Point(474, 141);
            CPhone.Name = "CPhone";
            CPhone.Size = new Size(256, 27);
            CPhone.TabIndex = 23;
            CPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(619, 78);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(260, 27);
            dateTimePicker.TabIndex = 34;
            // 
            // CName
            // 
            CName.Location = new Point(49, 78);
            CName.Name = "CName";
            CName.Size = new Size(204, 27);
            CName.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(59, 57);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 37;
            label5.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(330, 54);
            label6.Name = "label6";
            label6.Size = new Size(37, 19);
            label6.TabIndex = 38;
            label6.Text = "CIN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(633, 54);
            label7.Name = "label7";
            label7.Size = new Size(99, 19);
            label7.TabIndex = 39;
            label7.Text = "Date of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(129, 117);
            label8.Name = "label8";
            label8.Size = new Size(80, 19);
            label8.TabIndex = 40;
            label8.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(480, 117);
            label9.Name = "label9";
            label9.Size = new Size(58, 19);
            label9.TabIndex = 41;
            label9.Text = "Phone";
            // 
            // ResetBtn
            // 
            ResetBtn.BorderRadius = 15;
            ResetBtn.CustomizableEdges = customizableEdges1;
            ResetBtn.DisabledState.BorderColor = Color.DarkGray;
            ResetBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ResetBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ResetBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ResetBtn.FillColor = Color.DarkTurquoise;
            ResetBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(567, 203);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ResetBtn.Size = new Size(167, 45);
            ResetBtn.TabIndex = 42;
            ResetBtn.Text = "Reset";
            ResetBtn.Click += ResetBtn_Click_1;
            // 
            // EditBtn
            // 
            EditBtn.BorderRadius = 15;
            EditBtn.CustomizableEdges = customizableEdges3;
            EditBtn.DisabledState.BorderColor = Color.DarkGray;
            EditBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            EditBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            EditBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            EditBtn.FillColor = Color.FromArgb(255, 128, 0);
            EditBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(371, 203);
            EditBtn.Name = "EditBtn";
            EditBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            EditBtn.Size = new Size(167, 45);
            EditBtn.TabIndex = 43;
            EditBtn.Text = "Edit";
            EditBtn.Click += EditBtn_Click_1;
            // 
            // SaveBtn
            // 
            SaveBtn.BorderRadius = 15;
            SaveBtn.CustomizableEdges = customizableEdges5;
            SaveBtn.DisabledState.BorderColor = Color.DarkGray;
            SaveBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SaveBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SaveBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SaveBtn.FillColor = Color.Teal;
            SaveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(172, 203);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            SaveBtn.Size = new Size(167, 45);
            SaveBtn.TabIndex = 44;
            SaveBtn.Text = "Save";
            SaveBtn.Click += SaveBtn_Click_1;
            // 
            // Candidats
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(SaveBtn);
            Controls.Add(EditBtn);
            Controls.Add(ResetBtn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CName);
            Controls.Add(dateTimePicker);
            Controls.Add(label4);
            Controls.Add(candidatesList);
            Controls.Add(CCin);
            Controls.Add(CPassword);
            Controls.Add(CPhone);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Candidats";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Candidats";
            ((System.ComponentModel.ISupportInitialize)candidatesList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView candidatesList;
        private MaskedTextBox CCin;
        private MaskedTextBox CPassword;
        private MaskedTextBox CPhone;
        private DateTimePicker dateTimePicker;
        private TextBox CName;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Button ResetBtn;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
    }
}