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
        Function fn = new Function();
        string query;
        DataSet ds;
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

                DataTable table = employee.getList(new MySqlCommand("SELECT * FROM `user` WHERE `username`= '" + uname + "' AND `password`='" + pass + "' "));
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel_admin.Visible = false;
            panel_Employee.Visible = false;
        }

        private void comboBox_selectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_selectUser.SelectedIndex == 0)
            {
                panel_admin.Visible = true;
                panel_Employee.Visible = false;

            }
            else if (comboBox_selectUser.SelectedIndex == 1)
            {
                panel_admin.Visible = false;
                panel_Employee.Visible = true;
            }
        }

        private void checkBox_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPass.Checked == true)
            {
                textBox_password.PasswordChar = '\0';
                checkBox_showPass.Text = "Hide Password";
            }
            else
            {
                textBox_password.PasswordChar = '*';
                checkBox_showPass.Text = "Show Password";
            }
        }
        private void checkBox_showpassEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpassEmp.Checked == true)
            {
                textBox_emp_pass.PasswordChar = '\0';
                checkBox_showpassEmp.Text = "Hide Password";
            }
            else
            {
                textBox_emp_pass.PasswordChar = '*';
                checkBox_showpassEmp.Text = "Show Password";
            }
        }
        private void button_employee_login_Click(object sender, EventArgs e)
        {
            query = "select * from employees where username ='" + textBox_emp_username.Text + "' AND  password ='" + textBox_emp_pass.Text + "' ";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.Hide();
                Quiz form = new Quiz();
                form.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password !!", "Error");
            }
        }


        private void button_employee_register_Click(object sender, EventArgs e)
        {
            CreateAccount form = new CreateAccount();
            form.Show();
            this.Hide();
        }


    }
}
