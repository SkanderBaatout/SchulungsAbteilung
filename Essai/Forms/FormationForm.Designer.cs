namespace Essai.Forms
{
    partial class FormationForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            bindingSource = new BindingSource(components);
            contentPathLabel = new Label();
            contentTypeCB = new ComboBox();
            label9 = new Label();
            contentTB = new TextBox();
            loadBtn = new Button();
            deleteButton = new Guna.UI2.WinForms.Guna2Button();
            beginDate = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            formationGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            label4 = new Label();
            editbtn = new Guna.UI2.WinForms.Guna2Button();
            resetbtn = new Guna.UI2.WinForms.Guna2Button();
            addbtn = new Guna.UI2.WinForms.Guna2Button();
            nameTb = new MaskedTextBox();
            trainerTb = new MaskedTextBox();
            endDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            departmentCb = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formationGridView).BeginInit();
            SuspendLayout();
            // 
            // contentPathLabel
            // 
            contentPathLabel.AutoSize = true;
            contentPathLabel.Location = new Point(570, 164);
            contentPathLabel.Name = "contentPathLabel";
            contentPathLabel.Size = new Size(66, 21);
            contentPathLabel.TabIndex = 69;
            contentPathLabel.Text = "label10";
            // 
            // contentTypeCB
            // 
            contentTypeCB.FormattingEnabled = true;
            contentTypeCB.Location = new Point(308, 41);
            contentTypeCB.Name = "contentTypeCB";
            contentTypeCB.Size = new Size(167, 29);
            contentTypeCB.TabIndex = 68;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(127, 17);
            label9.Name = "label9";
            label9.Size = new Size(124, 19);
            label9.TabIndex = 67;
            label9.Text = "Training Name";
            // 
            // contentTB
            // 
            contentTB.Location = new Point(543, 100);
            contentTB.Name = "contentTB";
            contentTB.Size = new Size(128, 27);
            contentTB.TabIndex = 66;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(729, 97);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(62, 30);
            loadBtn.TabIndex = 65;
            loadBtn.Text = "Load Content";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // deleteButton
            // 
            deleteButton.BorderRadius = 15;
            deleteButton.CustomizableEdges = customizableEdges1;
            deleteButton.DisabledState.BorderColor = Color.DarkGray;
            deleteButton.DisabledState.CustomBorderColor = Color.DarkGray;
            deleteButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            deleteButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            deleteButton.FillColor = Color.OrangeRed;
            deleteButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(493, 211);
            deleteButton.Name = "deleteButton";
            deleteButton.PressedColor = Color.AntiqueWhite;
            deleteButton.ShadowDecoration.BorderRadius = 15;
            deleteButton.ShadowDecoration.Color = Color.Transparent;
            deleteButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            deleteButton.Size = new Size(167, 45);
            deleteButton.TabIndex = 64;
            deleteButton.Text = "Delete";
            deleteButton.Click += deleteButton_Click;
            // 
            // beginDate
            // 
            beginDate.Format = DateTimePickerFormat.Short;
            beginDate.Location = new Point(543, 41);
            beginDate.Name = "beginDate";
            beginDate.Size = new Size(128, 27);
            beginDate.TabIndex = 63;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(543, 17);
            label8.Name = "label8";
            label8.Size = new Size(93, 19);
            label8.TabIndex = 62;
            label8.Text = "Begin Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(305, 17);
            label7.Name = "label7";
            label7.Size = new Size(110, 19);
            label7.TabIndex = 61;
            label7.Text = "Content Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(517, 47);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 60;
            label6.Text = "Content";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(127, 79);
            label5.Name = "label5";
            label5.Size = new Size(61, 19);
            label5.TabIndex = 58;
            label5.Text = "Trainer";
            // 
            // formationGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            formationGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            formationGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            formationGridView.ColumnHeadersHeight = 25;
            formationGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            formationGridView.DefaultCellStyle = dataGridViewCellStyle3;
            formationGridView.Dock = DockStyle.Bottom;
            formationGridView.GridColor = Color.FromArgb(231, 229, 255);
            formationGridView.Location = new Point(0, 328);
            formationGridView.Name = "formationGridView";
            formationGridView.RowHeadersVisible = false;
            formationGridView.RowTemplate.Height = 24;
            formationGridView.Size = new Size(950, 322);
            formationGridView.TabIndex = 56;
            formationGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            formationGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            formationGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            formationGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            formationGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            formationGridView.ThemeStyle.BackColor = Color.White;
            formationGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            formationGridView.ThemeStyle.HeaderStyle.BackColor = Color.Black;
            formationGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            formationGridView.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            formationGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            formationGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            formationGridView.ThemeStyle.HeaderStyle.Height = 25;
            formationGridView.ThemeStyle.ReadOnly = false;
            formationGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            formationGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            formationGridView.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            formationGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            formationGridView.ThemeStyle.RowsStyle.Height = 24;
            formationGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            formationGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            formationGridView.CellClick += formationGridView_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(393, 272);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 55;
            label4.Text = "Trainings List";
            // 
            // editbtn
            // 
            editbtn.BorderRadius = 15;
            editbtn.CustomizableEdges = customizableEdges3;
            editbtn.DisabledState.BorderColor = Color.DarkGray;
            editbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            editbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            editbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            editbtn.FillColor = Color.FromArgb(255, 128, 0);
            editbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            editbtn.ForeColor = Color.White;
            editbtn.Location = new Point(308, 211);
            editbtn.Name = "editbtn";
            editbtn.ShadowDecoration.BorderRadius = 15;
            editbtn.ShadowDecoration.Color = Color.Transparent;
            editbtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            editbtn.Size = new Size(167, 45);
            editbtn.TabIndex = 54;
            editbtn.Text = "Edit";
            editbtn.Click += editbtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.BorderRadius = 15;
            resetbtn.CustomizableEdges = customizableEdges5;
            resetbtn.DisabledState.BorderColor = Color.DarkGray;
            resetbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            resetbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            resetbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            resetbtn.FillColor = Color.DarkTurquoise;
            resetbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.ForeColor = Color.White;
            resetbtn.Location = new Point(681, 211);
            resetbtn.Name = "resetbtn";
            resetbtn.ShadowDecoration.BorderRadius = 15;
            resetbtn.ShadowDecoration.Color = Color.Transparent;
            resetbtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            resetbtn.Size = new Size(167, 45);
            resetbtn.TabIndex = 53;
            resetbtn.Text = "Reset";
            resetbtn.Click += resetbtn_Click;
            // 
            // addbtn
            // 
            addbtn.BorderRadius = 15;
            addbtn.CustomizableEdges = customizableEdges7;
            addbtn.DisabledState.BorderColor = Color.DarkGray;
            addbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            addbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addbtn.FillColor = Color.Teal;
            addbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addbtn.ForeColor = Color.White;
            addbtn.Location = new Point(118, 211);
            addbtn.Name = "addbtn";
            addbtn.ShadowDecoration.BorderRadius = 15;
            addbtn.ShadowDecoration.Color = Color.Transparent;
            addbtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            addbtn.Size = new Size(167, 45);
            addbtn.TabIndex = 52;
            addbtn.Text = "Save";
            addbtn.Click += addbtn_Click;
            // 
            // nameTb
            // 
            nameTb.Location = new Point(117, 39);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(158, 27);
            nameTb.TabIndex = 51;
            nameTb.TextAlign = HorizontalAlignment.Center;
            // 
            // trainerTb
            // 
            trainerTb.Location = new Point(117, 100);
            trainerTb.Name = "trainerTb";
            trainerTb.Size = new Size(158, 27);
            trainerTb.TabIndex = 70;
            trainerTb.TextAlign = HorizontalAlignment.Center;
            // 
            // endDate
            // 
            endDate.Format = DateTimePickerFormat.Short;
            endDate.Location = new Point(713, 41);
            endDate.Name = "endDate";
            endDate.Size = new Size(128, 27);
            endDate.TabIndex = 73;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(713, 17);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 72;
            label1.Text = "End Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(677, 47);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 71;
            label2.Text = "Content";
            // 
            // departmentCb
            // 
            departmentCb.FormattingEnabled = true;
            departmentCb.Location = new Point(308, 100);
            departmentCb.Name = "departmentCb";
            departmentCb.Size = new Size(167, 29);
            departmentCb.TabIndex = 74;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(308, 78);
            label3.Name = "label3";
            label3.Size = new Size(101, 19);
            label3.TabIndex = 75;
            label3.Text = "Department";
            // 
            // FormationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(label3);
            Controls.Add(departmentCb);
            Controls.Add(endDate);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(trainerTb);
            Controls.Add(contentPathLabel);
            Controls.Add(contentTypeCB);
            Controls.Add(label9);
            Controls.Add(contentTB);
            Controls.Add(loadBtn);
            Controls.Add(deleteButton);
            Controls.Add(beginDate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(formationGridView);
            Controls.Add(label4);
            Controls.Add(editbtn);
            Controls.Add(resetbtn);
            Controls.Add(addbtn);
            Controls.Add(nameTb);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormationForm";
            Load += FormationForm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)formationGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource;
        private Label contentPathLabel;
        private ComboBox contentTypeCB;
        private Label label9;
        private TextBox contentTB;
        private Button loadBtn;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private DateTimePicker beginDate;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView formationGridView;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button editbtn;
        private Guna.UI2.WinForms.Guna2Button resetbtn;
        private Guna.UI2.WinForms.Guna2Button addbtn;
        private MaskedTextBox nameTb;
        private MaskedTextBox trainerTb;
        private DateTimePicker endDate;
        private Label label1;
        private Label label2;
        private ComboBox departmentCb;
        private Label label3;
    }
}