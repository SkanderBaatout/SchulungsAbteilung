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
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.BackColor = Color.Teal;
            OkButton.ForeColor = Color.White;
            OkButton.Location = new Point(628, 38);
            OkButton.Margin = new Padding(4);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(88, 41);
            OkButton.TabIndex = 1;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkButton_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Location = new Point(479, 109);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(362, 221);
            tableLayoutPanel.TabIndex = 2;
            // 
            // detailsPanel
            // 
            detailsPanel.Location = new Point(46, 38);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(396, 499);
            detailsPanel.TabIndex = 3;
            // 
            // ContentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
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
    }
}