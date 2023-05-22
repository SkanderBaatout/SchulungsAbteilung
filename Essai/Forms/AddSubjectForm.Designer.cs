namespace Essai.Forms
{
    partial class AddSubjectForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            contentTB = new TextBox();
            loadBtn = new Button();
            dtpDateAdded = new DateTimePicker();
            txtDescription = new TextBox();
            chkIsActive = new CheckBox();
            btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            txtName = new MaskedTextBox();
            openFileDialog1 = new OpenFileDialog();
            txtContentType = new MaskedTextBox();
            SuspendLayout();
            // 
            // contentTB
            // 
            contentTB.Location = new Point(597, 178);
            contentTB.Name = "contentTB";
            contentTB.Size = new Size(170, 23);
            contentTB.TabIndex = 56;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(621, 211);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(135, 30);
            loadBtn.TabIndex = 55;
            loadBtn.Text = "Load Content";
            loadBtn.UseVisualStyleBackColor = true;
            // 
            // dtpDateAdded
            // 
            dtpDateAdded.Location = new Point(469, 119);
            dtpDateAdded.Name = "dtpDateAdded";
            dtpDateAdded.Size = new Size(298, 23);
            dtpDateAdded.TabIndex = 54;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(33, 179);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(358, 89);
            txtDescription.TabIndex = 53;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chkIsActive.ForeColor = Color.Black;
            chkIsActive.Location = new Point(469, 182);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(91, 23);
            chkIsActive.TabIndex = 52;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.BorderRadius = 15;
            btnSubmit.CustomizableEdges = customizableEdges1;
            btnSubmit.DisabledState.BorderColor = Color.DarkGray;
            btnSubmit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSubmit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSubmit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSubmit.FillColor = Color.Teal;
            btnSubmit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(34, 289);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ShadowDecoration.BorderRadius = 15;
            btnSubmit.ShadowDecoration.Color = Color.Transparent;
            btnSubmit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSubmit.Size = new Size(167, 45);
            btnSubmit.TabIndex = 51;
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(33, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(158, 23);
            txtName.TabIndex = 50;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtContentType
            // 
            txtContentType.Location = new Point(233, 119);
            txtContentType.Name = "txtContentType";
            txtContentType.Size = new Size(158, 23);
            txtContentType.TabIndex = 57;
            txtContentType.TextAlign = HorizontalAlignment.Center;
            // 
            // AddSubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContentType);
            Controls.Add(contentTB);
            Controls.Add(loadBtn);
            Controls.Add(dtpDateAdded);
            Controls.Add(txtDescription);
            Controls.Add(chkIsActive);
            Controls.Add(btnSubmit);
            Controls.Add(txtName);
            Name = "AddSubjectForm";
            Text = "AddSubjectForm";
            Load += AddSubjectForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox contentTB;
        private Button loadBtn;
        private DateTimePicker dtpDateAdded;
        private TextBox txtDescription;
        private CheckBox chkIsActive;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private MaskedTextBox txtName;
        private OpenFileDialog openFileDialog1;
        private MaskedTextBox txtContentType;
    }
}