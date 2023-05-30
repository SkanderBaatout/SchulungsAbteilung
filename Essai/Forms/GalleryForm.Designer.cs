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
            mediaContentDataGridView = new DataGridView();
            label1 = new Label();
            subjectNameFilterTB = new TextBox();
            contentTypeCB = new ComboBox();
            totalRecordsLabel = new Label();
            currentPageLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            applyFiltersButton = new Button();
            nextPageButton = new Button();
            ContentButton = new Button();
            previousPageButton = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            pictureBox = new PictureBox();
            tableLayoutPanel = new TableLayoutPanel();
            ContentPictureBox = new PictureBox();
            vlcControl = new Vlc.DotNet.Forms.VlcControl();
            subjectPanel = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)mediaContentDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContentPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vlcControl).BeginInit();
            SuspendLayout();
            // 
            // mediaContentDataGridView
            // 
            mediaContentDataGridView.BackgroundColor = Color.Gainsboro;
            mediaContentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mediaContentDataGridView.Location = new Point(570, 93);
            mediaContentDataGridView.Name = "mediaContentDataGridView";
            mediaContentDataGridView.RowTemplate.Height = 25;
            mediaContentDataGridView.Size = new Size(380, 396);
            mediaContentDataGridView.TabIndex = 0;
            mediaContentDataGridView.CellContentDoubleClick += mediaContentDataGridView_CellContentDoubleClick;
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
            // currentPageLabel
            // 
            currentPageLabel.AutoSize = true;
            currentPageLabel.Location = new Point(359, 497);
            currentPageLabel.Name = "currentPageLabel";
            currentPageLabel.Size = new Size(57, 21);
            currentPageLabel.TabIndex = 5;
            currentPageLabel.Text = "label3";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(511, 496);
            numericUpDown1.Margin = new Padding(4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 27);
            numericUpDown1.TabIndex = 6;
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
            // nextPageButton
            // 
            nextPageButton.Location = new Point(570, 530);
            nextPageButton.Name = "nextPageButton";
            nextPageButton.Size = new Size(75, 29);
            nextPageButton.TabIndex = 8;
            nextPageButton.Text = "Next";
            nextPageButton.UseVisualStyleBackColor = true;
            nextPageButton.Click += nextPageButton_Click;
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
            // previousPageButton
            // 
            previousPageButton.Location = new Point(477, 530);
            previousPageButton.Name = "previousPageButton";
            previousPageButton.Size = new Size(75, 29);
            previousPageButton.TabIndex = 10;
            previousPageButton.Text = "Previous";
            previousPageButton.UseVisualStyleBackColor = true;
            previousPageButton.Click += previousPageButton_Click;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(pictureBox);
            flowLayoutPanel.Location = new Point(264, 341);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(288, 148);
            flowLayoutPanel.TabIndex = 11;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(274, 103);
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
            tableLayoutPanel.Controls.Add(vlcControl, 0, 0);
            tableLayoutPanel.Location = new Point(45, 93);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(496, 230);
            tableLayoutPanel.TabIndex = 12;
            // 
            // ContentPictureBox
            // 
            ContentPictureBox.Location = new Point(251, 3);
            ContentPictureBox.Name = "ContentPictureBox";
            ContentPictureBox.Size = new Size(100, 50);
            ContentPictureBox.TabIndex = 0;
            ContentPictureBox.TabStop = false;
            ContentPictureBox.Click += ContentPictureBox_Click;
            // 
            // vlcControl
            // 
            vlcControl.BackColor = Color.Black;
            vlcControl.Location = new Point(3, 3);
            vlcControl.Name = "vlcControl";
            vlcControl.Size = new Size(242, 109);
            vlcControl.Spu = -1;
            vlcControl.TabIndex = 1;
            vlcControl.Text = "vlcControl1";
            this.vlcControl.VlcLibDirectory = new DirectoryInfo(@"C:\Program Files\VideoLAN\VLC\");
            vlcControl.VlcMediaplayerOptions = null;
            // 
            // subjectPanel
            // 
            subjectPanel.Location = new Point(32, 407);
            subjectPanel.Name = "subjectPanel";
            subjectPanel.Size = new Size(225, 152);
            subjectPanel.TabIndex = 13;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = applyFiltersButton;
            // 
            // GalleryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(subjectPanel);
            Controls.Add(flowLayoutPanel);
            Controls.Add(tableLayoutPanel);
            Controls.Add(previousPageButton);
            Controls.Add(ContentButton);
            Controls.Add(nextPageButton);
            Controls.Add(applyFiltersButton);
            Controls.Add(numericUpDown1);
            Controls.Add(currentPageLabel);
            Controls.Add(totalRecordsLabel);
            Controls.Add(contentTypeCB);
            Controls.Add(subjectNameFilterTB);
            Controls.Add(label1);
            Controls.Add(mediaContentDataGridView);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "GalleryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GalleryForm";
            Load += GalleryForm_Load;
            ((System.ComponentModel.ISupportInitialize)mediaContentDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            flowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContentPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)vlcControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView mediaContentDataGridView;
        private Label label1;
        private TextBox subjectNameFilterTB;
        private ComboBox contentTypeCB;
        private Label totalRecordsLabel;
        private Label currentPageLabel;
        private NumericUpDown numericUpDown1;
        private Button applyFiltersButton;
        private Button nextPageButton;
        private Button ContentButton;
        private Button previousPageButton;
        private FlowLayoutPanel flowLayoutPanel;
        private PictureBox pictureBox;
        private TableLayoutPanel tableLayoutPanel;
        private Panel subjectPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PictureBox ContentPictureBox;
        private Vlc.DotNet.Forms.VlcControl vlcControl;
    }
}