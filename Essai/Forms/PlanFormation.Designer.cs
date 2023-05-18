namespace Essai
{
    partial class PlanFormation
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
            panel1 = new Panel();
            loadDataButton = new Button();
            saveButton = new Button();
            button1 = new Button();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(loadDataButton);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 100);
            panel1.TabIndex = 0;
            // 
            // loadDataButton
            // 
            loadDataButton.BackColor = Color.Teal;
            loadDataButton.ForeColor = Color.White;
            loadDataButton.Location = new Point(548, 31);
            loadDataButton.Name = "loadDataButton";
            loadDataButton.Size = new Size(121, 42);
            loadDataButton.TabIndex = 2;
            loadDataButton.Text = "Load Data";
            loadDataButton.UseVisualStyleBackColor = false;
            loadDataButton.Click += loadDataButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Teal;
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(396, 31);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(121, 42);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.ForeColor = Color.White;
            button1.Location = new Point(247, 31);
            button1.Name = "button1";
            button1.Size = new Size(121, 42);
            button1.TabIndex = 0;
            button1.Text = "Select File";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(950, 550);
            panel2.TabIndex = 1;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(950, 550);
            dataGridView.TabIndex = 0;
            // 
            // PlanFormation
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 650);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "PlanFormation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlanFormation";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private XLView xlView1;
        private Panel panel2;
        private DataGridView dataGridView;
        private Button saveButton;
        private Button loadDataButton;
    }
}