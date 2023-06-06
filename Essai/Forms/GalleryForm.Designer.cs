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
            label1 = new Label();
            subjectNameFilterTB = new TextBox();
            contentTypeCB = new ComboBox();
            totalRecordsLabel = new Label();
            applyFiltersButton = new Button();
            ContentButton = new Button();
            contentFlowLayoutPanel = new FlowLayoutPanel();
            pictureBox = new PictureBox();
            tableLayoutPanel = new TableLayoutPanel();
            ContentPictureBox = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            flowLayout1 = new Syncfusion.Windows.Forms.Tools.FlowLayout(components);
            SubjectButton = new Button();
            UrlButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContentPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flowLayout1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(624, 12);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // subjectNameFilterTB
            // 
            subjectNameFilterTB.Location = new Point(687, 12);
            subjectNameFilterTB.Name = "subjectNameFilterTB";
            subjectNameFilterTB.Size = new Size(100, 27);
            subjectNameFilterTB.TabIndex = 2;
            // 
            // contentTypeCB
            // 
            contentTypeCB.FormattingEnabled = true;
            contentTypeCB.Location = new Point(201, 9);
            contentTypeCB.Name = "contentTypeCB";
            contentTypeCB.Size = new Size(143, 29);
            contentTypeCB.TabIndex = 3;
            // 
            // totalRecordsLabel
            // 
            totalRecordsLabel.AutoSize = true;
            totalRecordsLabel.Location = new Point(32, 12);
            totalRecordsLabel.Name = "totalRecordsLabel";
            totalRecordsLabel.Size = new Size(57, 21);
            totalRecordsLabel.TabIndex = 4;
            totalRecordsLabel.Text = "label2";
            // 
            // applyFiltersButton
            // 
            applyFiltersButton.BackColor = Color.Teal;
            applyFiltersButton.ForeColor = Color.White;
            applyFiltersButton.Location = new Point(359, 9);
            applyFiltersButton.Name = "applyFiltersButton";
            applyFiltersButton.Size = new Size(111, 28);
            applyFiltersButton.TabIndex = 7;
            applyFiltersButton.Text = "Filter";
            applyFiltersButton.UseVisualStyleBackColor = false;
            applyFiltersButton.Click += applyFiltersButton_Click;
            // 
            // ContentButton
            // 
            ContentButton.Location = new Point(848, 10);
            ContentButton.Name = "ContentButton";
            ContentButton.Size = new Size(90, 29);
            ContentButton.TabIndex = 9;
            ContentButton.Text = "button3";
            ContentButton.UseVisualStyleBackColor = true;
            ContentButton.Click += ContentButton_Click;
            // 
            // contentFlowLayoutPanel
            // 
            contentFlowLayoutPanel.Location = new Point(377, 431);
            contentFlowLayoutPanel.Name = "contentFlowLayoutPanel";
            contentFlowLayoutPanel.Size = new Size(270, 63);
            contentFlowLayoutPanel.TabIndex = 11;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(653, 431);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(274, 63);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(ContentPictureBox, 1, 0);
            tableLayoutPanel.Location = new Point(40, 60);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(898, 365);
            tableLayoutPanel.TabIndex = 12;
            // 
            // ContentPictureBox
            // 
            ContentPictureBox.Location = new Point(452, 3);
            ContentPictureBox.Name = "ContentPictureBox";
            ContentPictureBox.Size = new Size(443, 176);
            ContentPictureBox.TabIndex = 0;
            ContentPictureBox.TabStop = false;
            ContentPictureBox.Click += ContentPictureBox_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = applyFiltersButton;
            // 
            // SubjectButton
            // 
            SubjectButton.Location = new Point(109, 444);
            SubjectButton.Name = "SubjectButton";
            SubjectButton.Size = new Size(75, 23);
            SubjectButton.TabIndex = 13;
            SubjectButton.Text = "button1";
            SubjectButton.UseVisualStyleBackColor = true;
            SubjectButton.Click += SubjectButton_Click;
            // 
            // UrlButton
            // 
            UrlButton.Location = new Point(242, 448);
            UrlButton.Name = "UrlButton";
            UrlButton.Size = new Size(75, 23);
            UrlButton.TabIndex = 14;
            UrlButton.Text = "button1";
            UrlButton.UseVisualStyleBackColor = true;
            UrlButton.Click += UrlButton_Click;
            // 
            // GalleryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(UrlButton);
            Controls.Add(SubjectButton);
            Controls.Add(pictureBox);
            Controls.Add(contentFlowLayoutPanel);
            Controls.Add(tableLayoutPanel);
            Controls.Add(ContentButton);
            Controls.Add(applyFiltersButton);
            Controls.Add(totalRecordsLabel);
            Controls.Add(contentTypeCB);
            Controls.Add(subjectNameFilterTB);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "GalleryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GalleryForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContentPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)flowLayout1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView mediaContentDataGridView;
        private Label label1;
        private TextBox subjectNameFilterTB;
        private ComboBox contentTypeCB;
        private Label totalRecordsLabel;
        private NumericUpDown numericUpDown1;
        private Button applyFiltersButton;
        private Button ContentButton;
        private FlowLayoutPanel contentFlowLayoutPanel;
        private PictureBox pictureBox;
        private TableLayoutPanel tableLayoutPanel;
        private Panel subjectPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PictureBox ContentPictureBox;
        private Vlc.DotNet.Forms.VlcControl videoPlayerControl;
        private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout1;
        private Button SubjectButton;
        private Button UrlButton;
    }
}