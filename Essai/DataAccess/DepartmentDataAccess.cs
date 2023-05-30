using Essai.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai.DataAccess
{
    public class DepartmentDataAccess
    {
        private readonly string _connectionString;

        public DepartmentDataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Department";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Department department = new Department
                            {
                                Id = (int)reader["DeptId"],
                                Name = (string)reader["DeptName"]
                            };

                            departments.Add(department);
                        }
                    }
                }
            }

            return departments;
        }

        public async Task<List<Department>> GetAllDepartmentsAsync()
        {
            List<Department> departments = new List<Department>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT DeptName FROM Department", connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Department department = new Department
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"]
                            };

                            departments.Add(department);
                        }
                    }
                }
            }

            return departments;
        }
    }

}