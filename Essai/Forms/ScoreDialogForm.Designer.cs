namespace Essai
{
    partial class ScoreDialogForm
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
            labelScore = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelScore.Location = new Point(222, 94);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(113, 38);
            labelScore.TabIndex = 0;
            labelScore.Text = "label1";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Teal;
            btnClose.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(498, 208);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 43);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // ScoreDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 263);
            Controls.Add(btnClose);
            Controls.Add(labelScore);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScoreDialogForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScoreDialogForm";
            Load += ScoreDialogForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelScore;
        private Button btnClose;
    }
}