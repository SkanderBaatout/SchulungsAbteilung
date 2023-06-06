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
            contentDataGridView = new DataGridView();
            OkButton = new Button();
            ((System.ComponentModel.ISupportInitialize)contentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // contentDataGridView
            // 
            contentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contentDataGridView.Location = new Point(124, 24);
            contentDataGridView.Name = "contentDataGridView";
            contentDataGridView.RowTemplate.Height = 25;
            contentDataGridView.Size = new Size(569, 402);
            contentDataGridView.TabIndex = 0;
            contentDataGridView.CellContentDoubleClick += contentDataGridView_CellContentDoubleClick;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(713, 115);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 23);
            OkButton.TabIndex = 1;
            OkButton.Text = "button1";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // ContentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OkButton);
            Controls.Add(contentDataGridView);
            Name = "ContentForm";
            Text = "ContentForm";
            ((System.ComponentModel.ISupportInitialize)contentDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView contentDataGridView;
        private Button OkButton;
    }
}