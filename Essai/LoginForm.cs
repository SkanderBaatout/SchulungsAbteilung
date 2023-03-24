using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        EmployeeClass employee = new EmployeeClass();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Transparent;

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Need Login Data!!", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {



                string uname = textBox_username.Text;
                string pass = textBox_password.Text;

                DataTable table = employee.getList(new MySqlCommand("SELECT * FROM `user` WHERE `username`= '"+ uname +"' AND `password`='"+ pass +"' "));
                if (table.Rows.Count > 0)
                {

                    Form1 main = new Form1();
                    this.Hide();
                    main.Show();

                }
                else
                {
                    MessageBox.Show("Username and password does not exists ", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
