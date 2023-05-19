using Essai.Singleton;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Essai.DataAccess
{
    public class QuestionDataAccess
    {
        private readonly string _connectionString;

        public QuestionDataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Question> GetQuestions()
        {
            var questions = new List<Question>();
            var selectQuery = "SELECT * FROM questions";

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(selectQuery, connection))
            {
                try
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var question = new Question
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("id")),
                                Text = reader.GetString(reader.GetOrdinal("text")),
                                Option1 = reader.GetString(reader.GetOrdinal("option1")),
                                Option2 = reader.GetString(reader.GetOrdinal("option2")),
                                Option3 = reader.GetString(reader.GetOrdinal("option3")),
                                Option4 = reader.GetString(reader.GetOrdinal("option4")),
                                CorrectOption = reader.GetInt32(reader.GetOrdinal("correctOption")),
                            };

                            questions.Add(question);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while retrieving the questions.", ex);
                }
            }

            return questions;
        }
        public int CountQuestions()
        {
            var countQuery = "SELECT COUNT(*) FROM questions UNION SELECT COUNT(*) FROM QuestionTbl";

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(countQuery, connection))
            {
                try
                {
                    connection.Open();

                    var sum = 0;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sum += reader.GetInt32(0);
                        }
                    }

                    return sum;
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while counting the questions.", ex);
                }
            }
        }
        public void AddQuestion(Question question)
        {
            var insertQuery = "INSERT INTO questions (text, option1, option2, option3, option4, correctOption) VALUES (@text, @option1, @option2, @option3, @option4, @correctOption)";

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@text", question.Text);
                command.Parameters.AddWithValue("@option1", question.Option1);
                command.Parameters.AddWithValue("@option2", question.Option2);
                command.Parameters.AddWithValue("@option3", question.Option3);
                command.Parameters.AddWithValue("@option4", question.Option4);
                command.Parameters.AddWithValue("@correctOption", question.CorrectOption);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while adding the question.", ex);
                }
            }
        }

        public void UpdateQuestion(Question question)
        {
            var updateQuery = "UPDATE questions SET text = @text, option1 = @option1, option2 = @option2, option3 = @option3, option4 = @option4, correctOption = @correctOption WHERE id = @id";

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@id", question.ID);
                command.Parameters.AddWithValue("@text", question.Text);
                command.Parameters.AddWithValue("@option1", question.Option1);
                command.Parameters.AddWithValue("@option2", question.Option2);
                command.Parameters.AddWithValue("@option3", question.Option3);
                command.Parameters.AddWithValue("@option4", question.Option4);
                command.Parameters.AddWithValue("@correctOption", question.CorrectOption);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while updating the question.", ex);
                }
            }
        }

        public void DeleteQuestion(int id)
        {
            var deleteQuery = "DELETE FROM questions WHERE id = @id";

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while deleting the question.", ex);
                }
            }
        }
    }
}