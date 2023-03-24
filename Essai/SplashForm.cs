using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            ProgressIndicator.Start();
            if(startPoint > 40)
            {
                LoginForm login = new LoginForm();
                ProgressIndicator.Stop();
                timer1.Stop();
                this.Hide();
                login.Show();
            }
        }
    }
}
