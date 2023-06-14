namespace Essai.Forms
{
    partial class ExamResults
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
            btnExport = new Guna.UI2.WinForms.Guna2Button();
            resultDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            candidatecb = new ComboBox();
            TestTypecb = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)resultDGV).BeginInit();
            SuspendLayout();
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
            btnExport.Location = new Point(364, 94);
            btnExport.Name = "btnExport";
            btnExport.ShadowDecoration.BorderRadius = 15;
            btnExport.ShadowDecoration.Color = Color.Transparent;
            btnExport.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExport.Size = new Size(200, 45);
            btnExport.TabIndex = 68;
            btnExport.Text = "Export to Excell";
            btnExport.Click += btnExport_Click;
            // 
            // resultDGV
            // 
            resultDGV.AllowUserToAddRows = false;
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
            resultDGV.ColumnHeadersHeight = 30;
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
            resultDGV.EnableHeadersVisualStyles = true;
            resultDGV.GridColor = Color.White;
            resultDGV.Location = new Point(0, 236);
            resultDGV.Name = "resultDGV";
            resultDGV.RowHeadersVisible = false;
            resultDGV.RowTemplate.Height = 24;
            resultDGV.Size = new Size(950, 414);
            resultDGV.TabIndex = 67;
            resultDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            resultDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            resultDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            resultDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            resultDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            resultDGV.ThemeStyle.BackColor = Color.White;
            resultDGV.ThemeStyle.GridColor = Color.White;
            resultDGV.ThemeStyle.HeaderStyle.BackColor = Color.Black;
            resultDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            resultDGV.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            resultDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            resultDGV.ThemeStyle.HeaderStyle.Height = 30;
            resultDGV.ThemeStyle.ReadOnly = false;
            resultDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            resultDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            resultDGV.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultDGV.ThemeStyle.RowsStyle.ForeColor = Color.Teal;
            resultDGV.ThemeStyle.RowsStyle.Height = 24;
            resultDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            resultDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.Teal;
            resultDGV.CellFormatting += resultDGV_CellFormatting;
            // 
            // candidatecb
            // 
            candidatecb.ForeColor = Color.Teal;
            candidatecb.FormattingEnabled = true;
            candidatecb.Location = new Point(507, 39);
            candidatecb.Name = "candidatecb";
            candidatecb.Size = new Size(174, 29);
            candidatecb.TabIndex = 66;
            candidatecb.Text = "Candidate";
            candidatecb.SelectedIndexChanged += candidatecb_SelectedIndexChanged;
            // 
            // TestTypecb
            // 
            TestTypecb.ForeColor = Color.Teal;
            TestTypecb.FormattingEnabled = true;
            TestTypecb.Location = new Point(239, 39);
            TestTypecb.Name = "TestTypecb";
            TestTypecb.Size = new Size(174, 29);
            TestTypecb.TabIndex = 65;
            TestTypecb.Text = "Test";
            TestTypecb.SelectedIndexChanged += TestTypecb_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(364, 182);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(216, 38);
            label4.TabIndex = 64;
            label4.Text = "Exam Results";
            // 
            // ExamResults
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(btnExport);
            Controls.Add(resultDGV);
            Controls.Add(candidatecb);
            Controls.Add(TestTypecb);
            Controls.Add(label4);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ExamResults";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExamResults";
            ((System.ComponentModel.ISupportInitialize)resultDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2DataGridView resultDGV;
        private ComboBox candidatecb;
        private ComboBox TestTypecb;
        private Label label4;
    }
}