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
            button1 = new Button();
            panel2 = new Panel();
            xlView2 = new XLView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 100);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Location = new Point(401, 29);
            button1.Name = "button1";
            button1.Size = new Size(121, 42);
            button1.TabIndex = 0;
            button1.Text = "Select File";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(xlView2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(950, 550);
            panel2.TabIndex = 1;
            // 
            // xlView2
            // 
            xlView2.Dock = DockStyle.Fill;
            xlView2.Location = new Point(0, 0);
            xlView2.Margin = new Padding(4, 4, 4, 4);
            xlView2.Name = "xlView2";
            xlView2.Size = new Size(950, 550);
            xlView2.TabIndex = 0;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private XLView xlView1;
        private Panel panel2;
        private XLView xlView2;
    }
}