namespace Essai
{
    partial class FollowSubjectForm
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
            comboBox_subjects = new ComboBox();
            label_subjectName = new Label();
            textBox_content = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView = new DataGridView();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_subjects
            // 
            comboBox_subjects.FormattingEnabled = true;
            comboBox_subjects.Location = new Point(689, 74);
            comboBox_subjects.Margin = new Padding(4);
            comboBox_subjects.Name = "comboBox_subjects";
            comboBox_subjects.Size = new Size(210, 29);
            comboBox_subjects.TabIndex = 0;
            // 
            // label_subjectName
            // 
            label_subjectName.AutoSize = true;
            label_subjectName.Location = new Point(384, 48);
            label_subjectName.Margin = new Padding(4, 0, 4, 0);
            label_subjectName.Name = "label_subjectName";
            label_subjectName.Size = new Size(57, 21);
            label_subjectName.TabIndex = 1;
            label_subjectName.Text = "label1";
            // 
            // textBox_content
            // 
            textBox_content.Location = new Point(689, 135);
            textBox_content.Margin = new Padding(4);
            textBox_content.Name = "textBox_content";
            textBox_content.Size = new Size(141, 27);
            textBox_content.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(479, 243);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 335);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(13, 243);
            dataGridView.Margin = new Padding(4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(413, 335);
            dataGridView.TabIndex = 4;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(13, 74);
            webView21.Name = "webView21";
            webView21.Size = new Size(406, 143);
            webView21.TabIndex = 5;
            webView21.ZoomFactor = 1D;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(461, 21);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(150, 100);
            splitContainer1.TabIndex = 6;
            // 
            // FollowSubjectForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(splitContainer1);
            Controls.Add(webView21);
            Controls.Add(dataGridView);
            Controls.Add(pictureBox1);
            Controls.Add(textBox_content);
            Controls.Add(label_subjectName);
            Controls.Add(comboBox_subjects);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FollowSubjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FollowSubjectForm";
            Load += FollowSubjectForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_subjects;
        private Label label_subjectName;
        private TextBox textBox_content;
        private PictureBox pictureBox1;
        private DataGridView dataGridView;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private SplitContainer splitContainer1;
    }
}