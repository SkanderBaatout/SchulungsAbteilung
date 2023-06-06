using Essai.Models;
using Essai.Singleton;
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
        Function fn = Function.Instance;
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

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            label_error.Visible = false;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            // Check if the username already exists in the database
            if (CheckExistingUser())
            {
                MessageBox.Show("Username already exists with the same CIN. Please choose a different username or CIN.", "Error");
                return;
            }

            query = "INSERT INTO employees (username, password, gender, email, mobile, birthday,cin) VALUES ('" + textBox_username.Text + "','" + textBox_password.Text + "','" + comboBox_gender.Text + "','" + textBox_email.Text + "','" + textBox_mobile.Text + "' ,'" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "','" + textBox_cin.Text + "' )";
            ds = fn.getData(query);

            if (textBox_password.Text != textBox_confirmPass.Text)
            {
                label_error.Visible = true;
            }
            else
            {
                MessageBox.Show("Employee Registered Successfully!", "Success");
                label_error.Visible = false;
                ResetFields();
            }
        }

        private void button_goBack_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void ResetFields()
        {
            // Reset all fields to their default values
            textBox_username.Text = "";
            textBox_password.Text = "";
            textBox_confirmPass.Text = "";
            comboBox_gender.SelectedIndex = 0;
            textBox_email.Text = "";
            textBox_mobile.Text = "";
            dateTimePicker.Value = DateTime.Now;
            textBox_cin.Text = "";
        }

        private bool CheckExistingUser()
        {
            // Check if a user already exists with the same username and CIN
            query = "SELECT * FROM employees WHERE username='" + textBox_username.Text + "' AND cin='" + textBox_cin.Text + "'";
            ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }

            return false;
        }
    }
}