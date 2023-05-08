using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Essai
{
    public partial class LoginForm : Form
    {
        public static string username;
        public static string cin;
        private readonly string _connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";

        public LoginForm()
        {
            InitializeComponent();
            //label_title.Font = new Font("Roboto", 24, FontStyle.Bold);
            label_username.Font = new Font("Roboto", 12, FontStyle.Regular);
            label_password.Font = new Font("Roboto", 12, FontStyle.Regular);
            //label_username_error.Font = new Font("Roboto", 10, FontStyle.Regular);
            // label_password_error.Font = new Font("Roboto", 10, FontStyle.Regular);
            button_login.Font = new Font("Roboto", 12, FontStyle.Bold);
            checkBox_showPass.Font = new Font("Roboto", 10, FontStyle.Regular);
            comboBox_selectUser.Font = new Font("Roboto", 12, FontStyle.Regular);
            button_employee_login.Font = new Font("Roboto", 12, FontStyle.Bold);
            button_employee_register.Font = new Font("Roboto", 12, FontStyle.Bold);
            label_emp_username.Font = new Font("Roboto", 12, FontStyle.Regular);
            label_emp_pass.Font = new Font("Roboto", 12, FontStyle.Regular);
            label_cin.Font = new Font("Roboto", 12, FontStyle.Regular);
            // label_emp_username_error.Font = new Font("Roboto", 10, FontStyle.Regular);
            // label_emp_pass_error.Font = new Font("Roboto", 10, FontStyle.Regular);
            // label_cin_error.Font = new Font("Roboto", 10, FontStyle.Regular);
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

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_username.Text))
            {
                MessageBox.Show("Username is required");
                // label_username_error.Text = "Username is required";
                // label_username_error.ForeColor = Color.Red;
                textBox_username.BackColor = Color.LightSalmon;
            }
            else
            {
                //label_username_error.Text = "";
                textBox_username.BackColor = Color.White;
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_password.Text))
            {
                MessageBox.Show("Password is required");
                // label_password_error.Text = "Password is required";
                // label_password_error.ForeColor = Color.Red;
                textBox_password.BackColor = Color.LightSalmon;
            }
            else
            {
                //label_password_error.Text = "";
                textBox_password.BackColor = Color.White;
            }
        }

        private void button_login_MouseEnter(object sender, EventArgs e)
        {
            button_login.BackColor = Color.FromArgb(56, 142, 60); // change to a darker shade of green
        }

        private void button_login_MouseLeave(object sender, EventArgs e)
        {
            button_login.BackColor = Color.FromArgb(76, 175, 80); // change back to the original shade of green
        }

        private async void button_login_Click(object sender, EventArgs e)
        {
            // start the loading indicator
            button_login.Image = Properties.Resources.spinner;
            button_login.ImageAlign = ContentAlignment.MiddleRight;
            button_login.Text = "Logging in...";

            if (string.IsNullOrWhiteSpace(textBox_username.Text) || string.IsNullOrWhiteSpace(textBox_password.Text))
            {
                // show error message and stop the loading indicator
                MessageBox.Show("Need Login Data!!", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button_login.Image = null;
                button_login.ImageAlign = ContentAlignment.MiddleCenter;
                button_login.Text = "Login";
            }
            else
            {
                string uname = textBox_username.Text;
                string pass = textBox_password.Text;

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Admin WHERE username = @username AND password = @password", connection))
                    {
                        command.Parameters.AddWithValue("@username", uname);
                        command.Parameters.AddWithValue("@password", pass);

                        DataTable table = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }

                        if (table.Rows.Count > 0)
                        {
                            // stop the loading indicator and navigate to the main form
                            button_login.Image = null;
                            button_login.ImageAlign = ContentAlignment.MiddleCenter;
                            button_login.Text = "Login";
                            Form1 main = new Form1();
                            this.Hide();
                            main.Show();
                        }
                        else
                        {
                            // show error message and stop the loading indicator
                            MessageBox.Show("Username and password do not exist", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            button_login.Image = null;
                            button_login.ImageAlign = ContentAlignment.MiddleCenter;
                            button_login.Text = "Login";
                        }
                    }
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
            textBox_password.PasswordChar = checkBox_showPass.Checked ? '\0' : '*';
            checkBox_showPass.Text = checkBox_showPass.Checked ? "Hide Password" : "Show Password";
        }


        private void button_employee_login_MouseEnter(object sender, EventArgs e)
        {
            button_employee_login.BackColor = Color.FromArgb(56, 142, 60); // change to a darker shade of green
        }

        private void button_employee_login_MouseLeave(object sender, EventArgs e)
        {
            button_employee_login.BackColor = Color.FromArgb(76, 175, 80); // change back to the original shade of green
        }

        private async void button_employee_login_Click(object sender, EventArgs e)
        {
            // start the loading indicator
            button_employee_login.Image = Properties.Resources.spinner;
            button_employee_login.ImageAlign = ContentAlignment.MiddleRight;
            button_employee_login.Text = "Logging in...";

            if (string.IsNullOrWhiteSpace(textBox_emp_username.Text) || string.IsNullOrWhiteSpace(textBox_emp_pass.Text) || string.IsNullOrWhiteSpace(textBox_cin.Text))
            {
                // show error message and stop the loading indicator
                MessageBox.Show("Need Login Data!!", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button_employee_login.Image = null;
                button_employee_login.ImageAlign = ContentAlignment.MiddleCenter;
                button_employee_login.Text = "Login";
            }
            else
            {
                string emp_uname = textBox_emp_username.Text;
                string emp_pass = textBox_emp_pass.Text;
                string emp_cin = textBox_cin.Text;

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM employees WHERE username = @username AND password = @password AND cin = @cin", connection))
                    {
                        command.Parameters.AddWithValue("@username", emp_uname);
                        command.Parameters.AddWithValue("@password", emp_pass);
                        command.Parameters.AddWithValue("@cin", emp_cin);

                        DataTable table = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }

                        if (table.Rows.Count > 0)
                        {
                            // stop the loading indicator and set the global username and cin variables, then navigate to the employee form
                            button_employee_login.Image = null;
                            button_employee_login.ImageAlign = ContentAlignment.MiddleCenter;
                            button_employee_login.Text = "Login";
                            username = emp_uname;
                            cin = emp_cin;
                            EmployeeBord emp = new EmployeeBord();
                            this.Hide();
                            emp.Show();
                        }
                        else
                        {
                            // show error message and stop the loading indicator
                            MessageBox.Show("Username, password, or CIN do not exist", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            button_employee_login.Image = null;
                            button_employee_login.ImageAlign = ContentAlignment.MiddleCenter;
                            button_employee_login.Text = "Login";
                        }
                    }
                }
            }
        }

        private void button_employee_register_MouseEnter(object sender, EventArgs e)
        {
            button_employee_register.BackColor = Color.FromArgb(56, 142, 60); // change to a darker shade of green
        }

        private void button_employee_register_MouseLeave(object sender, EventArgs e)
        {
            button_employee_register.BackColor = Color.FromArgb(76, 175, 80); // change back to the original shade of green
        }

        private void button_employee_register_Click(object sender, EventArgs e)
        {
            CreateAccount empReg = new CreateAccount();
            empReg.Show();
        }

        private void textBox_emp_username_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_emp_username.Text))
            {
                MessageBox.Show("Username is required");
                // label_emp_username_error.Text = "Username is required";
                // label_emp_username_error.ForeColor = Color.Red;
                textBox_emp_username.BackColor = Color.LightSalmon;
            }
            else
            {
                // label_emp_username_error.Text = "";
                textBox_emp_username.BackColor = Color.White;
            }
        }

        private void textBox_emp_pass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_emp_pass.Text))
            {
                MessageBox.Show("Password is required");
                // label_emp_pass_error.Text = "Password is required";
                // label_emp_pass_error.ForeColor = Color.Red;
                textBox_emp_pass.BackColor = Color.LightSalmon;
            }
            else
            {
                //label_emp_pass_error.Text = "";
                textBox_emp_pass.BackColor = Color.White;
            }
        }

        private void textBox_cin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_cin.Text))
            {
                MessageBox.Show("CIN is required");
                // label_cin_error.Text = "CIN is required";
                // label_cin_error.ForeColor = Color.Red;
                textBox_cin.BackColor = Color.LightSalmon;
            }
            else
            {
                //label_cin_error.Text = "";
                textBox_cin.BackColor = Color.White;
            }
        }

        private void checkBox_showpassEmp_CheckedChanged(object sender, EventArgs e)
        {
            textBox_emp_pass.PasswordChar = checkBox_showpassEmp.Checked ? '\0' : '*';
            checkBox_showpassEmp.Text = checkBox_showpassEmp.Checked ? "Hide Password" : "Show Password";
        }
    }
}
