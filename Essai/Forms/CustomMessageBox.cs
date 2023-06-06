using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai.Forms
{
    public partial class CustomMessageBox : UserControl
    {
        public string MessageText
        {
            get { return labelMessage.Text; }
            set { labelMessage.Text = value; }
        }

        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public void ShowDialog()
        {
            Form form = new Form();
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ClientSize = new Size(300, 150);

            form.Controls.Add(this);
            this.Dock = DockStyle.Fill;

            Button button = new Button();
            button.Text = "OK";
            button.DialogResult = DialogResult.OK;
            button.Location = new Point(110, 80);
            button.Size = new Size(80, 30);
            form.Controls.Add(button);

            form.ShowDialog();
        }

        private void button_Click(object sender, EventArgs e)
        {

        }
    }
}
