using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Essai
{
    public partial class EditEmployeeForm : Form
    {
        private readonly int _employeeId;

        public EditEmployeeForm(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
        }

        public void FillForm()
        {
            string connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";
            string selectQuery = "SELECT * FROM employees WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@id", _employeeId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtUsername.Text = reader["username"].ToString();
                            txtPassword.Text = reader["password"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtMobile.Text = reader["mobile"].ToString();
                            txtCin.Text = reader["cin"].ToString();
                            dtpBirthday.Value = Convert.ToDateTime(reader["birthday"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured: " + ex.Message, "Error");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username and password are mandatory .", "Input Error");
                return;
            }

            string connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";
            string updateQuery = "UPDATE employees SET username = @username, password = @password, email = @email, mobile = @mobile, cin = @cin, birthday = @birthday WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                try
                {
                    connection.Open();

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@username", txtUsername.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@mobile", txtMobile.Text);
                    command.Parameters.AddWithValue("@cin", txtCin.Text);
                    command.Parameters.AddWithValue("@birthday", dtpBirthday.Value);
                    command.Parameters.AddWithValue("@id", _employeeId);

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee updated successfully.", "Success");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No employee have been updated.", "Advertissment");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured : " + ex.Message, "Error");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}