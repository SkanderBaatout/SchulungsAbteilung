using Microsoft.Data.SqlClient;
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
    public partial class ProfileModificationForm : Form
    {
        private readonly string _username;
        private readonly string _cin;
        private int _employeeId;
        public ProfileModificationForm(string username, string cin)
        {
            InitializeComponent();
            _username = username;
            _cin = cin;
            dtp_birthday.Format = DateTimePickerFormat.Custom;
            dtp_birthday.CustomFormat = "yyyy-MM-dd";
        }

        private void ProfileModificationForm_Load(object sender, EventArgs e)
        {
            string connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";
            string selectQuery = "SELECT id, username, password, email, mobile, birthday, cin FROM employees WHERE username = @username AND cin = @cin";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@username", _username);
                        command.Parameters.AddWithValue("@cin", _cin);

                        // Execute the command and retrieve the data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _employeeId = reader.GetInt32(0);
                                txt_username.Text = _username;
                                txt_password.Text = reader.GetString(2);
                                txt_email.Text = reader.GetString(3);
                                txt_mobile.Text = reader.GetString(4);
                                txt_cin.Text = _cin;
                                txt_cin.ReadOnly = true;
                                dtp_birthday.Value = reader.GetDateTime(5);
                                dtp_birthday.Enabled = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite: " + ex.Message, "Erreur");
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";
            string updateQuery = "UPDATE employees SET password = @password, email = @email, mobile = @mobile WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@password", txt_password.Text);
                        command.Parameters.AddWithValue("@email", txt_email.Text);
                        command.Parameters.AddWithValue("@mobile", txt_mobile.Text);
                        command.Parameters.AddWithValue("@id", _employeeId);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profil mis à jour avec succès.", "Succès");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Aucun profil n'a été mis à jour.", "Avertissement");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite: " + ex.Message, "Erreur");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EmployeeBord form = new EmployeeBord();
            form.Show();
            this.Hide();
        }
    }
}
