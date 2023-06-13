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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            viewProgressButton = new Guna.UI2.WinForms.Guna2Button();
            candidatecb = new ComboBox();
            subjectcb = new ComboBox();
            progressionDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)progressionDGV).BeginInit();
            SuspendLayout();
            // 
            // viewProgressButton
            // 
            viewProgressButton.BorderRadius = 15;
            viewProgressButton.CustomizableEdges = customizableEdges5;
            viewProgressButton.DisabledState.BorderColor = Color.DarkGray;
            viewProgressButton.DisabledState.CustomBorderColor = Color.DarkGray;
            viewProgressButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            viewProgressButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            viewProgressButton.FillColor = Color.Teal;
            viewProgressButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            viewProgressButton.ForeColor = Color.White;
            viewProgressButton.Location = new Point(359, 76);
            viewProgressButton.Name = "viewProgressButton";
            viewProgressButton.ShadowDecoration.BorderRadius = 15;
            viewProgressButton.ShadowDecoration.Color = Color.Transparent;
            viewProgressButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            viewProgressButton.Size = new Size(220, 45);
            viewProgressButton.TabIndex = 67;
            viewProgressButton.Text = "View Progression";
            viewProgressButton.Click += viewProgressButton_Click;
            // 
            // candidatecb
            // 
            candidatecb.ForeColor = Color.Teal;
            candidatecb.FormattingEnabled = true;
            candidatecb.Location = new Point(520, 30);
            candidatecb.Name = "candidatecb";
            candidatecb.Size = new Size(215, 29);
            candidatecb.TabIndex = 66;
            candidatecb.Text = "Candidate";
            candidatecb.SelectedIndexChanged += candidatecb_SelectedIndexChanged;
            // 
            // subjectcb
            // 
            subjectcb.ForeColor = Color.Teal;
            subjectcb.FormattingEnabled = true;
            subjectcb.Location = new Point(190, 30);
            subjectcb.Name = "subjectcb";
            subjectcb.Size = new Size(236, 29);
            subjectcb.TabIndex = 65;
            subjectcb.Text = "Subject";
            subjectcb.SelectedIndexChanged += subjectcb_SelectedIndexChanged;
            // 
            // progressionDGV
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            progressionDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            progressionDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            progressionDGV.ColumnHeadersHeight = 25;
            progressionDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            progressionDGV.DefaultCellStyle = dataGridViewCellStyle9;
            progressionDGV.Dock = DockStyle.Bottom;
            progressionDGV.GridColor = Color.FromArgb(231, 229, 255);
            progressionDGV.Location = new Point(0, 254);
            progressionDGV.Name = "progressionDGV";
            progressionDGV.RowHeadersVisible = false;
            progressionDGV.RowTemplate.Height = 24;
            progressionDGV.Size = new Size(950, 396);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(337, 204);
            label1.Name = "label1";
            label1.Size = new Size(290, 36);
            label1.TabIndex = 74;
            label1.Text = "Training Progression";
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            circularProgressBar1.AnimationSpeed = 500;
            circularProgressBar1.BackColor = Color.Transparent;
            circularProgressBar1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            circularProgressBar1.ForeColor = Color.FromArgb(64, 64, 64);
            circularProgressBar1.InnerColor = Color.White;
            circularProgressBar1.InnerMargin = 2;
            circularProgressBar1.InnerWidth = -1;
            circularProgressBar1.Location = new Point(741, 30);
            circularProgressBar1.MarqueeAnimationSpeed = 2000;
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.OuterColor = Color.MediumTurquoise;
            circularProgressBar1.OuterMargin = -25;
            circularProgressBar1.OuterWidth = 26;
            circularProgressBar1.ProgressColor = Color.Teal;
            circularProgressBar1.ProgressWidth = 25;
            circularProgressBar1.SecondaryFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            circularProgressBar1.Size = new Size(179, 146);
            circularProgressBar1.StartAngle = 270;
            circularProgressBar1.SubscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            circularProgressBar1.SubscriptText = "";
            circularProgressBar1.SuperscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            circularProgressBar1.SuperscriptText = "";
            circularProgressBar1.TabIndex = 75;
            circularProgressBar1.Text = "%";
            circularProgressBar1.TextMargin = new Padding(8, 8, 0, 0);
            circularProgressBar1.Value = 68;
            // 
            // ProgressForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(circularProgressBar1);
            Controls.Add(label1);
            Controls.Add(progressionDGV);
            Controls.Add(viewProgressButton);
            Controls.Add(candidatecb);
            Controls.Add(subjectcb);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ProgressForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProgressForm";
            Load += ProgressForm_Load;
            ((System.ComponentModel.ISupportInitialize)progressionDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button viewProgressButton;
        private ComboBox candidatecb;
        private ComboBox subjectcb;
        private Guna.UI2.WinForms.Guna2DataGridView progressionDGV;
        private Label label1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}