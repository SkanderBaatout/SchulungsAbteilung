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
                        command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
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
            string deleteProgressionQuery = "DELETE FROM EmployeeProgression WHERE EmployeeId = @id";
            string deleteEmployeeQuery = "DELETE FROM employees WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Delete the employee's progression records, if they exist
                    using (SqlCommand command = new SqlCommand(deleteProgressionQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", employeeId);

                        int progressionRowsAffected = command.ExecuteNonQuery();

                        if (progressionRowsAffected == 0)
                        {
                            // If there are no progression records, simply log a message
                            Console.WriteLine($"No progression records found for employee {employeeId}.");
                        }
                    }

                    // Delete the employee record
                    using (SqlCommand command = new SqlCommand(deleteEmployeeQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", employeeId);

                        int employeeRowsAffected = command.ExecuteNonQuery();

                        if (employeeRowsAffected == 0)
                        {
                            throw new Exception("Employee record not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while deleting the employee.", ex);
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