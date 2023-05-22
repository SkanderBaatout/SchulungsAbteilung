namespace Essai.Forms
{
    partial class ViewContentForm
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
            lblTitle = new Label();
            lblDescription = new Label();
            lblContentType = new Label();
            lblContentTitle = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(289, 95);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 15);
            lblTitle.TabIndex = 60;
            lblTitle.Text = "label1";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(421, 92);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(38, 15);
            lblDescription.TabIndex = 61;
            lblDescription.Text = "label1";
            // 
            // lblContentType
            // 
            lblContentType.AutoSize = true;
            lblContentType.Location = new Point(600, 92);
            lblContentType.Name = "lblContentType";
            lblContentType.Size = new Size(38, 15);
            lblContentType.TabIndex = 62;
            lblContentType.Text = "label1";
            // 
            // lblContentTitle
            // 
            lblContentTitle.AutoSize = true;
            lblContentTitle.Location = new Point(358, 214);
            lblContentTitle.Name = "lblContentTitle";
            lblContentTitle.Size = new Size(38, 15);
            lblContentTitle.TabIndex = 63;
            lblContentTitle.Text = "label1";
            // 
            // ViewContentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblContentTitle);
            Controls.Add(lblContentType);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Name = "ViewContentForm";
            Text = "ViewContentForm";
            Load += ViewContentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Label lblDescription;
        private Label lblContentType;
        private Label lblContentTitle;
    }
}