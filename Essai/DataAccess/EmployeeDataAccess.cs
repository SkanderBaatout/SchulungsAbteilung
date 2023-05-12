using Essai.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai.DataAccess
{
    public class EmployeeDataAccess
    {
        private string connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string selectQuery = "SELECT * FROM employees";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Execute the command and get the data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Employee employee = new Employee();
                                employee.Id = Convert.ToInt32(reader["id"]);
                                employee.Username = reader["username"].ToString();
                                employee.Password = reader["password"].ToString();
                                employee.Email = reader["email"].ToString();
                                employee.Mobile = reader["mobile"].ToString();
                                employee.Cin = reader["cin"].ToString();
                                employee.Birthday = Convert.ToDateTime(reader["birthday"]);

                                employees.Add(employee);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite: " + ex.Message, "Erreur");
                }
            }

            return employees;
        }

        public List<Employee> SearchEmployees(string keyword)
        {
            List<Employee> employees = new List<Employee>();
            string selectQuery = "SELECT * FROM employees WHERE cin LIKE @keyword OR mobile LIKE @keyword";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        // Execute the command and get the data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Employee employee = new Employee();
                                employee.Id = Convert.ToInt32(reader["id"]);
                                employee.Username = reader["username"].ToString();
                                employee.Password = reader["password"].ToString();
                                employee.Email = reader["email"].ToString();
                                employee.Mobile = reader["mobile"].ToString();
                                employee.Cin = reader["cin"].ToString();
                                employee.Birthday = Convert.ToDateTime(reader["birthday"]);

                                employees.Add(employee);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite: " + ex.Message, "Erreur");
                }
            }

            return employees;
        }

        public void DeleteEmployee(int employeeId)
        {
            string deleteQuery = "DELETE FROM employees WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@id", employeeId);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            throw new Exception("Aucun employé n'a été supprimé.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Une erreur s'est produite lors de la suppression de l'employé.", ex);
                }
            }
        }

        public int CountEmployees()
        {
            string countQuery = "SELECT COUNT(*) FROM employees";
            int count = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(countQuery, connection))
                    {
                        count = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite: " + ex.Message, "Erreur");
                }
            }

            return count;
        }

        public int CountMaleEmployees()
        {
            string countQuery = "SELECT COUNT(*) FROM employees WHERE gender = 'Male'";
            int count = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(countQuery, connection))
                    {
                        count = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite: " + ex.Message, "Erreur");
                }
            }

            return count;
        }

        public int CountFemaleEmployees()
        {
            string countQuery = "SELECT COUNT(*) FROM employees WHERE gender = 'Female'";
            int count = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(countQuery, connection))
                    {
                        count = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite: " + ex.Message, "Erreur");
                }
            }

            return count;
        }
    }
}