namespace Essai.Forms
{
    partial class EditSubjectForm
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
            subjectTb = new TextBox();
            descriptionTB = new TextBox();
            contentTypeCB = new ComboBox();
            dateTimePicker = new DateTimePicker();
            isActiveCheckBox = new CheckBox();
            saveBtn = new Button();
            cancelBtn = new Button();
            browseBtn = new Button();
            contentPathLabel = new Label();
            SuspendLayout();
            // 
            // subjectTb
            // 
            subjectTb.Location = new Point(302, 68);
            subjectTb.Name = "subjectTb";
            subjectTb.Size = new Size(100, 23);
            subjectTb.TabIndex = 0;
            // 
            // descriptionTB
            // 
            descriptionTB.Location = new Point(471, 72);
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(100, 23);
            descriptionTB.TabIndex = 1;
            // 
            // contentTypeCB
            // 
            contentTypeCB.FormattingEnabled = true;
            contentTypeCB.Location = new Point(292, 172);
            contentTypeCB.Name = "contentTypeCB";
            contentTypeCB.Size = new Size(121, 23);
            contentTypeCB.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(506, 163);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 3;
            // 
            // isActiveCheckBox
            // 
            isActiveCheckBox.AutoSize = true;
            isActiveCheckBox.Location = new Point(435, 249);
            isActiveCheckBox.Name = "isActiveCheckBox";
            isActiveCheckBox.Size = new Size(83, 19);
            isActiveCheckBox.TabIndex = 4;
            isActiveCheckBox.Text = "checkBox1";
            isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(139, 336);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "SAve";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(269, 338);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(392, 347);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(75, 23);
            browseBtn.TabIndex = 7;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // contentPathLabel
            // 
            contentPathLabel.AutoSize = true;
            contentPathLabel.Location = new Point(573, 302);
            contentPathLabel.Name = "contentPathLabel";
            contentPathLabel.Size = new Size(38, 15);
            contentPathLabel.TabIndex = 8;
            contentPathLabel.Text = "label1";
            // 
            // EditSubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contentPathLabel);
            Controls.Add(browseBtn);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(isActiveCheckBox);
            Controls.Add(dateTimePicker);
            Controls.Add(contentTypeCB);
            Controls.Add(descriptionTB);
            Controls.Add(subjectTb);
            Name = "EditSubjectForm";
            Text = "EditSubjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox subjectTb;
        private TextBox descriptionTB;
        private ComboBox contentTypeCB;
        private DateTimePicker dateTimePicker;
        private CheckBox isActiveCheckBox;
        private Button saveBtn;
        private Button cancelBtn;
        private Button browseBtn;
        private Label contentPathLabel;
    }
}