using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace Essai.DataAccess
{
    public class SubjectDataAccess
    {
        private readonly string _connectionString;

        public SubjectDataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int CountSubjects()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Count the total number of subjects in the SubjectTbl table
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM SubjectTbl", connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}