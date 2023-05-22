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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges37 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges38 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges39 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges40 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ListViewContents = new ListView();
            ButtonDelete = new Guna.UI2.WinForms.Guna2Button();
            ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            pictureBoxImage = new PictureBox();
            label1 = new Label();
            ButtonEdit = new Guna.UI2.WinForms.Guna2Button();
            ButtonView = new Guna.UI2.WinForms.Guna2Button();
            buttonChangeFile = new Guna.UI2.WinForms.Guna2Button();
            comboBox = new ComboBox();
            this.tableLayoutPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ListViewContents
            // 
            ListViewContents.Location = new Point(478, 3);
            ListViewContents.Name = "ListViewContents";
            ListViewContents.Size = new Size(469, 193);
            ListViewContents.TabIndex = 0;
            ListViewContents.UseCompatibleStateImageBehavior = false;
            ListViewContents.SelectedIndexChanged += ListViewContents_SelectedIndexChanged;
            // 
            // ButtonDelete
            // 
            ButtonDelete.BorderRadius = 15;
            ButtonDelete.CustomizableEdges = customizableEdges31;
            ButtonDelete.DisabledState.BorderColor = Color.DarkGray;
            ButtonDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonDelete.FillColor = Color.OrangeRed;
            ButtonDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonDelete.ForeColor = Color.White;
            ButtonDelete.Location = new Point(506, 176);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.PressedColor = Color.AntiqueWhite;
            ButtonDelete.ShadowDecoration.BorderRadius = 15;
            ButtonDelete.ShadowDecoration.Color = Color.Transparent;
            ButtonDelete.ShadowDecoration.CustomizableEdges = customizableEdges32;
            ButtonDelete.Size = new Size(167, 45);
            ButtonDelete.TabIndex = 46;
            ButtonDelete.Text = "Delete";
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // ButtonAdd
            // 
            ButtonAdd.BorderRadius = 15;
            ButtonAdd.CustomizableEdges = customizableEdges33;
            ButtonAdd.DisabledState.BorderColor = Color.DarkGray;
            ButtonAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonAdd.FillColor = Color.Teal;
            ButtonAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonAdd.ForeColor = Color.White;
            ButtonAdd.Location = new Point(110, 176);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.ShadowDecoration.BorderRadius = 15;
            ButtonAdd.ShadowDecoration.Color = Color.Transparent;
            ButtonAdd.ShadowDecoration.CustomizableEdges = customizableEdges34;
            ButtonAdd.Size = new Size(167, 45);
            ButtonAdd.TabIndex = 45;
            ButtonAdd.Text = "Add";
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(3, 202);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(469, 133);
            pictureBoxImage.TabIndex = 47;
            pictureBoxImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 44);
            label1.TabIndex = 48;
            label1.Text = "Gallery Form";
            // 
            // ButtonEdit
            // 
            ButtonEdit.BorderRadius = 15;
            ButtonEdit.CustomizableEdges = customizableEdges35;
            ButtonEdit.DisabledState.BorderColor = Color.DarkGray;
            ButtonEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonEdit.FillColor = Color.FromArgb(255, 128, 0);
            ButtonEdit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonEdit.ForeColor = Color.White;
            ButtonEdit.Location = new Point(311, 176);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.ShadowDecoration.BorderRadius = 15;
            ButtonEdit.ShadowDecoration.Color = Color.Transparent;
            ButtonEdit.ShadowDecoration.CustomizableEdges = customizableEdges36;
            ButtonEdit.Size = new Size(167, 45);
            ButtonEdit.TabIndex = 50;
            ButtonEdit.Text = "Edit";
            ButtonEdit.Click += ButtonEdit_Click;
            // 
            // ButtonView
            // 
            ButtonView.BorderRadius = 15;
            ButtonView.CustomizableEdges = customizableEdges37;
            ButtonView.DisabledState.BorderColor = Color.DarkGray;
            ButtonView.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonView.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonView.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonView.FillColor = Color.DarkTurquoise;
            ButtonView.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonView.ForeColor = Color.White;
            ButtonView.Location = new Point(695, 176);
            ButtonView.Name = "ButtonView";
            ButtonView.ShadowDecoration.BorderRadius = 15;
            ButtonView.ShadowDecoration.Color = Color.Transparent;
            ButtonView.ShadowDecoration.CustomizableEdges = customizableEdges38;
            ButtonView.Size = new Size(167, 45);
            ButtonView.TabIndex = 49;
            ButtonView.Text = "View";
            ButtonView.Click += ButtonView_Click;
            // 
            // buttonChangeFile
            // 
            buttonChangeFile.BorderRadius = 15;
            buttonChangeFile.CustomizableEdges = customizableEdges39;
            buttonChangeFile.DisabledState.BorderColor = Color.DarkGray;
            buttonChangeFile.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonChangeFile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonChangeFile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonChangeFile.FillColor = Color.CadetBlue;
            buttonChangeFile.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChangeFile.ForeColor = Color.White;
            buttonChangeFile.Location = new Point(659, 79);
            buttonChangeFile.Name = "buttonChangeFile";
            buttonChangeFile.ShadowDecoration.BorderRadius = 15;
            buttonChangeFile.ShadowDecoration.Color = Color.Transparent;
            buttonChangeFile.ShadowDecoration.CustomizableEdges = customizableEdges40;
            buttonChangeFile.Size = new Size(158, 35);
            buttonChangeFile.TabIndex = 51;
            buttonChangeFile.Text = "Change File";
            buttonChangeFile.Click += buttonChangeFile_Click;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "All", "Video", "Image", "Audio" });
            comboBox.Location = new Point(3, 3);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(146, 29);
            comboBox.TabIndex = 52;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(ListViewContents, 1, 0);
            this.tableLayoutPanel.Controls.Add(comboBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(pictureBoxImage, 0, 1);
            this.tableLayoutPanel.Dock = DockStyle.Bottom;
            this.tableLayoutPanel.Location = new Point(0, 251);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new Size(950, 399);
            this.tableLayoutPanel.TabIndex = 53;
            // 
            // GalleryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(this.tableLayoutPanel);
            Controls.Add(buttonChangeFile);
            Controls.Add(ButtonEdit);
            Controls.Add(ButtonView);
            Controls.Add(label1);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonAdd);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "GalleryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GalleryForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ListViewContents;
        private Guna.UI2.WinForms.Guna2Button ButtonDelete;
        private Guna.UI2.WinForms.Guna2Button ButtonAdd;
        private PictureBox pictureBoxImage;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button ButtonEdit;
        private Guna.UI2.WinForms.Guna2Button ButtonView;
        private Guna.UI2.WinForms.Guna2Button buttonChangeFile;
        private ComboBox comboBox;
        private TableLayoutPanel tableLayoutPanel;
    }
}