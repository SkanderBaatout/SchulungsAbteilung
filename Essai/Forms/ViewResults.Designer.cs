namespace Essai
{
    partial class ViewResults
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
            resultDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            candidatecb = new ComboBox();
            subjectcb = new ComboBox();
            label4 = new Label();
            btnExport = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)resultDGV).BeginInit();
            SuspendLayout();
            // 
            // resultDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            resultDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            resultDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resultDGV.ColumnHeadersHeight = 25;
            resultDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            resultDGV.DefaultCellStyle = dataGridViewCellStyle3;
            resultDGV.Dock = DockStyle.Bottom;
            resultDGV.GridColor = Color.FromArgb(231, 229, 255);
            resultDGV.Location = new Point(0, 211);
            resultDGV.Name = "resultDGV";
            resultDGV.RowHeadersVisible = false;
            resultDGV.RowTemplate.Height = 24;
            resultDGV.Size = new Size(934, 400);
            resultDGV.TabIndex = 62;
            resultDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            resultDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            resultDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            resultDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            resultDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            resultDGV.ThemeStyle.BackColor = Color.White;
            resultDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            resultDGV.ThemeStyle.HeaderStyle.BackColor = Color.Black;
            resultDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            resultDGV.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            resultDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            resultDGV.ThemeStyle.HeaderStyle.Height = 25;
            resultDGV.ThemeStyle.ReadOnly = false;
            resultDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            resultDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            resultDGV.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            resultDGV.ThemeStyle.RowsStyle.Height = 24;
            resultDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            resultDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // candidatecb
            // 
            candidatecb.ForeColor = Color.Teal;
            candidatecb.FormattingEnabled = true;
            candidatecb.Location = new Point(507, 24);
            candidatecb.Name = "candidatecb";
            candidatecb.Size = new Size(174, 29);
            candidatecb.TabIndex = 61;
            candidatecb.Text = "Candidate";
            candidatecb.SelectedIndexChanged += candidatecb_SelectedIndexChanged_1;
            // 
            // subjectcb
            // 
            subjectcb.ForeColor = Color.Teal;
            subjectcb.FormattingEnabled = true;
            subjectcb.Location = new Point(239, 24);
            subjectcb.Name = "subjectcb";
            subjectcb.Size = new Size(174, 29);
            subjectcb.TabIndex = 60;
            subjectcb.Text = "Subject";
            subjectcb.SelectedIndexChanged += subjectcb_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(410, 152);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 58;
            label4.Text = "Results";
            label4.Click += label4_Click;
            // 
            // btnExport
            // 
            btnExport.BorderRadius = 15;
            btnExport.CustomizableEdges = customizableEdges1;
            btnExport.DisabledState.BorderColor = Color.DarkGray;
            btnExport.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExport.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExport.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExport.FillColor = Color.Teal;
            btnExport.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(364, 72);
            btnExport.Name = "btnExport";
            btnExport.ShadowDecoration.BorderRadius = 15;
            btnExport.ShadowDecoration.Color = Color.Transparent;
            btnExport.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExport.Size = new Size(200, 45);
            btnExport.TabIndex = 63;
            btnExport.Text = "Export to Excell";
            btnExport.Click += btnExport_Click;
            // 
            // ViewResults
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 611);
            Controls.Add(btnExport);
            Controls.Add(resultDGV);
            Controls.Add(candidatecb);
            Controls.Add(subjectcb);
            Controls.Add(label4);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ViewResults";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewResults";
            ((System.ComponentModel.ISupportInitialize)resultDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView resultDGV;
        private ComboBox candidatecb;
        private ComboBox subjectcb;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button btnExport;
    }
}