using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace Essai.DataAccess
{
    public class UserDataAccess
    {
        private readonly string _connectionString;

        public UserDataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int CountEmployees()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Count the total number of employees in the employees table
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM employees", connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public int CountAdmins()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Count the total number of admins in the Admin table
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Admin", connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public int CountUsers()
        {
            // Count the total number of users by adding up the number of employees and admins
            return CountEmployees() + CountAdmins();
        }
    }
}