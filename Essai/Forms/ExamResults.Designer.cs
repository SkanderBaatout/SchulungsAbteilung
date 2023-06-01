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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            btnExport.CustomizableEdges = customizableEdges3;
            btnExport.DisabledState.BorderColor = Color.DarkGray;
            btnExport.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExport.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExport.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExport.FillColor = Color.Teal;
            btnExport.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(364, 67);
            btnExport.Name = "btnExport";
            btnExport.ShadowDecoration.BorderRadius = 15;
            btnExport.ShadowDecoration.Color = Color.Transparent;
            btnExport.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExport.Size = new Size(200, 45);
            btnExport.TabIndex = 68;
            btnExport.Text = "Export to Excell";
            btnExport.Click += btnExport_Click;
            // 
            // resultDGV
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            resultDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            resultDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            resultDGV.ColumnHeadersHeight = 25;
            resultDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            resultDGV.DefaultCellStyle = dataGridViewCellStyle6;
            resultDGV.Dock = DockStyle.Bottom;
            resultDGV.GridColor = Color.FromArgb(231, 229, 255);
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
            candidatecb.Location = new Point(507, 12);
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
            TestTypecb.Location = new Point(239, 12);
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
            label4.Location = new Point(364, 126);
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