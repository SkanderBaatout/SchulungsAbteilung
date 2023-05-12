using Essai.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai.Repository
{
    internal class SubjectRepository : IDisposable
    {
        private readonly SqlConnection _connection;

        public SubjectRepository(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        public async Task<Subject[]> GetActiveSubjectsAsync()
        {
            var query = "SELECT SName FROM SubjectTbl WHERE IsActive = 1";
            var cmd = new SqlCommand(query, _connection);
            var reader = await cmd.ExecuteReaderAsync();

            var subjects = new List<Subject>();

            while (await reader.ReadAsync())
            {
                subjects.Add(new Subject { Name = reader["SName"].ToString() });
            }

            reader.Close();

            return subjects.ToArray();
        }

        public async Task<Subject> GetSubjectAsync(string subjectName)
        {
            var query = "SELECT Content, ContentType FROM SubjectTbl WHERE SName = @SName";
            var cmd = new SqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@SName", subjectName);

            var reader = await cmd.ExecuteReaderAsync();

            Subject subject = null;

            if (await reader.ReadAsync())
            {
                subject = new Subject
                {
                    Content = (byte[])reader["Content"],
                    ContentType = reader["ContentType"].ToString()
                };
            }

            reader.Close();

            return subject;
        }

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}