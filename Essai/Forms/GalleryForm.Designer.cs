using Vlc.DotNet.Forms;

namespace Essai.Forms
{
    partial class GalleryForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalleryForm));
            subjectNameFilterTB = new TextBox();
            contentTypeCB = new ComboBox();
            totalRecordsLabel = new Label();
            applyFiltersButton = new Button();
            ContentButton = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            SubjectButton = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            flowLayout1 = new Syncfusion.Windows.Forms.Tools.FlowLayout(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            lblPageNumber = new Label();
            btnNextPage = new Button();
            btnPrevPage = new PictureBox();
            btnFirstPage = new PictureBox();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flowLayout1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPrevPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnFirstPage).BeginInit();
            SuspendLayout();
            // 
            // subjectNameFilterTB
            // 
            subjectNameFilterTB.Location = new Point(652, 115);
            subjectNameFilterTB.Name = "subjectNameFilterTB";
            subjectNameFilterTB.Size = new Size(161, 27);
            subjectNameFilterTB.TabIndex = 2;
            // 
            // contentTypeCB
            // 
            contentTypeCB.FormattingEnabled = true;
            contentTypeCB.Location = new Point(190, 114);
            contentTypeCB.Name = "contentTypeCB";
            contentTypeCB.Size = new Size(143, 29);
            contentTypeCB.TabIndex = 3;
            // 
            // totalRecordsLabel
            // 
            totalRecordsLabel.AutoSize = true;
            totalRecordsLabel.Location = new Point(24, 122);
            totalRecordsLabel.Name = "totalRecordsLabel";
            totalRecordsLabel.Size = new Size(57, 21);
            totalRecordsLabel.TabIndex = 4;
            totalRecordsLabel.Text = "label2";
            // 
            // applyFiltersButton
            // 
            applyFiltersButton.BackColor = Color.Teal;
            applyFiltersButton.ForeColor = Color.White;
            applyFiltersButton.Location = new Point(339, 115);
            applyFiltersButton.Name = "applyFiltersButton";
            applyFiltersButton.Size = new Size(105, 28);
            applyFiltersButton.TabIndex = 7;
            applyFiltersButton.Text = "Filter";
            applyFiltersButton.UseVisualStyleBackColor = false;
            applyFiltersButton.Click += applyFiltersButton_Click;
            // 
            // ContentButton
            // 
            ContentButton.BackColor = Color.Teal;
            ContentButton.ForeColor = Color.White;
            ContentButton.Location = new Point(819, 113);
            ContentButton.Name = "ContentButton";
            ContentButton.Size = new Size(90, 29);
            ContentButton.TabIndex = 9;
            ContentButton.Text = "Search";
            ContentButton.UseVisualStyleBackColor = false;
            ContentButton.Click += ContentButton_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(SubjectButton, 1, 1);
            tableLayoutPanel.Location = new Point(22, 159);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(906, 419);
            tableLayoutPanel.TabIndex = 12;
            // 
            // SubjectButton
            // 
            SubjectButton.Location = new Point(456, 212);
            SubjectButton.Name = "SubjectButton";
            SubjectButton.Size = new Size(133, 43);
            SubjectButton.TabIndex = 13;
            SubjectButton.Text = "button1";
            SubjectButton.UseVisualStyleBackColor = true;
            SubjectButton.Click += SubjectButton_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = applyFiltersButton;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            guna2Elipse2.TargetControl = applyFiltersButton;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 15;
            guna2Elipse3.TargetControl = ContentButton;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(506, 77);
            label1.TabIndex = 13;
            label1.Text = "Subject Gallery";
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.ForeColor = Color.Black;
            lblPageNumber.Location = new Point(446, 622);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(57, 21);
            lblPageNumber.TabIndex = 77;
            lblPageNumber.Text = "label1";
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = Color.Teal;
            btnNextPage.ForeColor = Color.White;
            btnNextPage.Location = new Point(429, 584);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(102, 35);
            btnNextPage.TabIndex = 76;
            btnNextPage.Text = "Next Page";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Image = (Image)resources.GetObject("btnPrevPage.Image");
            btnPrevPage.Location = new Point(360, 597);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(50, 22);
            btnPrevPage.SizeMode = PictureBoxSizeMode.Zoom;
            btnPrevPage.TabIndex = 75;
            btnPrevPage.TabStop = false;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Image = (Image)resources.GetObject("btnFirstPage.Image");
            btnFirstPage.Location = new Point(547, 597);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(50, 22);
            btnFirstPage.SizeMode = PictureBoxSizeMode.Zoom;
            btnFirstPage.TabIndex = 74;
            btnFirstPage.TabStop = false;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // GalleryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(lblPageNumber);
            Controls.Add(btnNextPage);
            Controls.Add(btnPrevPage);
            Controls.Add(btnFirstPage);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel);
            Controls.Add(ContentButton);
            Controls.Add(applyFiltersButton);
            Controls.Add(totalRecordsLabel);
            Controls.Add(contentTypeCB);
            Controls.Add(subjectNameFilterTB);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "GalleryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GalleryForm";
            tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flowLayout1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPrevPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnFirstPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView mediaContentDataGridView;
        private TextBox subjectNameFilterTB;
        private ComboBox contentTypeCB;
        private Label totalRecordsLabel;
        private NumericUpDown numericUpDown1;
        private Button applyFiltersButton;
        private Button ContentButton;
        private TableLayoutPanel tableLayoutPanel;
        private Panel subjectPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Vlc.DotNet.Forms.VlcControl videoPlayerControl;
        private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout1;
        private Button SubjectButton;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Label label1;
        private Label lblPageNumber;
        private Button btnNextPage;
        private PictureBox btnPrevPage;
        private PictureBox btnFirstPage;
    }
}