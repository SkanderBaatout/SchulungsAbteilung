namespace Essai
{
    partial class ContentForm
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
            OkButton = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            detailsPanel = new Panel();
            label1 = new Label();
            progressBar = new ProgressBar();
            progressBarLabel = new Label();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.BackColor = Color.Teal;
            OkButton.ForeColor = Color.White;
            OkButton.Location = new Point(832, 13);
            OkButton.Margin = new Padding(4);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(88, 41);
            OkButton.TabIndex = 1;
            OkButton.Text = "Close";
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkButton_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Location = new Point(576, 99);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(362, 221);
            tableLayoutPanel.TabIndex = 2;
            // 
            // detailsPanel
            // 
            detailsPanel.Location = new Point(46, 99);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(511, 438);
            detailsPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(67, 18);
            label1.Name = "label1";
            label1.Size = new Size(374, 56);
            label1.TabIndex = 4;
            label1.Text = "Training Details";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(680, 381);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(100, 23);
            progressBar.TabIndex = 5;
            // 
            // progressBarLabel
            // 
            progressBarLabel.AutoSize = true;
            progressBarLabel.Location = new Point(698, 417);
            progressBarLabel.Name = "progressBarLabel";
            progressBarLabel.Size = new Size(57, 21);
            progressBarLabel.TabIndex = 6;
            progressBarLabel.Text = "label2";
            // 
            // ContentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(progressBarLabel);
            Controls.Add(progressBar);
            Controls.Add(label1);
            Controls.Add(detailsPanel);
            Controls.Add(tableLayoutPanel);
            Controls.Add(OkButton);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ContentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button OkButton;
        private TableLayoutPanel tableLayoutPanel;
        private Panel detailsPanel;
        private Label label1;
        private ProgressBar progressBar;
        private Label progressBarLabel;
    }
}