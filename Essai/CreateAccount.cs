using Microsoft.Data.SqlClient;
using Mysqlx.Crud;
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
    public partial class CreateAccount : Form
    {
        Function fn = new Function();
        string query;
        DataSet ds;
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            label_error.Visible = false;
        }

        private void panel_admin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO employees (username, password, gender, email, mobile, birthday) VALUES ('" + textBox_username.Text + "','" + textBox_password.Text + "','" + comboBox_gender.Text + "','" + textBox_email.Text + "','" + textBox_mobile.Text + "' ,'" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "' )";
            ds = fn.getData(query);

            if (textBox_password.Text != textBox_confirmPass.Text)
            {
                label_error.Visible = true;
            }
            else
            {
                MessageBox.Show("Employee Registred Successfully!", "Success");
                label_error.Visible = false;
            }


        }

        private void button_goBack_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void textBox_confirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
        }
    }
}
