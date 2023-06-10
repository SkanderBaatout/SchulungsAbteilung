namespace Essai.Forms
{
    partial class ProgressForm
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
            viewProgressButton = new Guna.UI2.WinForms.Guna2Button();
            candidatecb = new ComboBox();
            subjectcb = new ComboBox();
            label4 = new Label();
            progressionDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)progressionDGV).BeginInit();
            SuspendLayout();
            // 
            // viewProgressButton
            // 
            viewProgressButton.BorderRadius = 15;
            viewProgressButton.CustomizableEdges = customizableEdges1;
            viewProgressButton.DisabledState.BorderColor = Color.DarkGray;
            viewProgressButton.DisabledState.CustomBorderColor = Color.DarkGray;
            viewProgressButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            viewProgressButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            viewProgressButton.FillColor = Color.Teal;
            viewProgressButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            viewProgressButton.ForeColor = Color.White;
            viewProgressButton.Location = new Point(366, 58);
            viewProgressButton.Name = "viewProgressButton";
            viewProgressButton.ShadowDecoration.BorderRadius = 15;
            viewProgressButton.ShadowDecoration.Color = Color.Transparent;
            viewProgressButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            viewProgressButton.Size = new Size(220, 45);
            viewProgressButton.TabIndex = 67;
            viewProgressButton.Text = "View Progression";
            viewProgressButton.Click += viewProgressButton_Click;
            // 
            // candidatecb
            // 
            candidatecb.ForeColor = Color.Teal;
            candidatecb.FormattingEnabled = true;
            candidatecb.Location = new Point(527, 12);
            candidatecb.Name = "candidatecb";
            candidatecb.Size = new Size(174, 29);
            candidatecb.TabIndex = 66;
            candidatecb.Text = "Candidate";
            candidatecb.SelectedIndexChanged += candidatecb_SelectedIndexChanged;
            // 
            // subjectcb
            // 
            subjectcb.ForeColor = Color.Teal;
            subjectcb.FormattingEnabled = true;
            subjectcb.Location = new Point(259, 12);
            subjectcb.Name = "subjectcb";
            subjectcb.Size = new Size(174, 29);
            subjectcb.TabIndex = 65;
            subjectcb.Text = "Subject";
            subjectcb.SelectedIndexChanged += subjectcb_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(357, 135);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(241, 28);
            label4.TabIndex = 64;
            label4.Text = "Training Progression";
            // 
            // progressionDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            progressionDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            progressionDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            progressionDGV.ColumnHeadersHeight = 25;
            progressionDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            progressionDGV.DefaultCellStyle = dataGridViewCellStyle3;
            progressionDGV.Dock = DockStyle.Bottom;
            progressionDGV.GridColor = Color.FromArgb(231, 229, 255);
            progressionDGV.Location = new Point(0, 217);
            progressionDGV.Name = "progressionDGV";
            progressionDGV.RowHeadersVisible = false;
            progressionDGV.RowTemplate.Height = 24;
            progressionDGV.Size = new Size(950, 433);
            progressionDGV.TabIndex = 72;
            progressionDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            progressionDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            progressionDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            progressionDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            progressionDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            progressionDGV.ThemeStyle.BackColor = Color.White;
            progressionDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            progressionDGV.ThemeStyle.HeaderStyle.BackColor = Color.Black;
            progressionDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            progressionDGV.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            progressionDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            progressionDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            progressionDGV.ThemeStyle.HeaderStyle.Height = 25;
            progressionDGV.ThemeStyle.ReadOnly = false;
            progressionDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            progressionDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            progressionDGV.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            progressionDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            progressionDGV.ThemeStyle.RowsStyle.Height = 24;
            progressionDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            progressionDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ProgressForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(progressionDGV);
            Controls.Add(viewProgressButton);
            Controls.Add(candidatecb);
            Controls.Add(subjectcb);
            Controls.Add(label4);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ProgressForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProgressForm";
            ((System.ComponentModel.ISupportInitialize)progressionDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button viewProgressButton;
        private ComboBox candidatecb;
        private ComboBox subjectcb;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView progressionDGV;
    }
}