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
    public partial class EmployeeBord : Form
    {
        public EmployeeBord()
        {
            InitializeComponent();
        }

        private void EmployeeBord_Load(object sender, EventArgs e)
        {
            username.Text = LoginForm.username;
        }

        private void button_questions_Click(object sender, EventArgs e)
        {
            Quiz form = new Quiz();
            form.Show();
            this.Hide();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void button_plan_Click(object sender, EventArgs e)
        {

        }

        private void button_course_Click(object sender, EventArgs e)
        {
            Questions questions = new Questions();

            this.Hide();
            questions.Show();
        }
    }
}
