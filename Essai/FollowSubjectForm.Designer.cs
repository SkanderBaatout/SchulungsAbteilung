﻿namespace Essai
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // comboBox_subjects
            // 
            comboBox_subjects.FormattingEnabled = true;
            comboBox_subjects.Location = new Point(547, 80);
            comboBox_subjects.Margin = new Padding(4, 4, 4, 4);
            comboBox_subjects.Name = "comboBox_subjects";
            comboBox_subjects.Size = new Size(210, 29);
            comboBox_subjects.TabIndex = 0;
            comboBox_subjects.SelectedIndexChanged += comboBox_subjects_SelectedIndexChanged;
            // 
            // label_subjectName
            // 
            label_subjectName.AutoSize = true;
            label_subjectName.Location = new Point(224, 77);
            label_subjectName.Margin = new Padding(4, 0, 4, 0);
            label_subjectName.Name = "label_subjectName";
            label_subjectName.Size = new Size(57, 21);
            label_subjectName.TabIndex = 1;
            label_subjectName.Text = "label1";
            // 
            // textBox_content
            // 
            textBox_content.Location = new Point(547, 141);
            textBox_content.Margin = new Padding(4, 4, 4, 4);
            textBox_content.Name = "textBox_content";
            textBox_content.Size = new Size(141, 27);
            textBox_content.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(479, 243);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
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
            dataGridView.Margin = new Padding(4, 4, 4, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(413, 335);
            dataGridView.TabIndex = 4;
            // 
            // FollowSubjectForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(dataGridView);
            Controls.Add(pictureBox1);
            Controls.Add(textBox_content);
            Controls.Add(label_subjectName);
            Controls.Add(comboBox_subjects);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FollowSubjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FollowSubjectForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_subjects;
        private Label label_subjectName;
        private TextBox textBox_content;
        private PictureBox pictureBox1;
        private DataGridView dataGridView;
    }
}