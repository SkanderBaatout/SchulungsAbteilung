using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using Essai.Models;
using System.Text;
using System.Transactions;

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
        public List<Subject> GetAllSubjects()
        {
            string query = "SELECT * FROM SubjectTbl LEFT JOIN ContentTbl ON SubjectTbl.SId = ContentTbl.SubjectId";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<Subject> subjects = new List<Subject>();

                while (reader.Read())
                {
                    int id = (int)reader["SId"];
                    string name = (string)reader["SName"];
                    string description = (string)reader["Description"];
                    string contentType = (string)reader["ContentType"];
                    DateTime dateAdded = (DateTime)reader["DateAdded"];
                    bool isActive = (bool)reader["IsActive"];

                    Content content = null;
                    if (!reader.IsDBNull(reader.GetOrdinal("ContentTitle")))
                    {
                        content = new Content
                        {
                            ContentId = reader["ContentId"] is DBNull ? 0 : (int)reader["ContentId"],
                            SubjectId = reader["SubjectId"] is DBNull ? 0 : (int)reader["SubjectId"],
                            ContentType = (string)reader["ContentType"],
                            ContentTitle = (string)reader["ContentTitle"],
                            ContentData = (byte[])reader["ContentData"]
                        };
                    }
                    Subject subject = new Subject
                    {
                        Id = id,
                        Name = name,
                        Description = description,
                        ContentType = contentType,
                        DateAdded = dateAdded,
                        IsActive = isActive,
                        Content = content
                    };

                    subjects.Add(subject);
                }

                return subjects;
            }
        }
        public Subject GetSubjectById(int id)
        {
            string query = "SELECT * FROM SubjectTbl WHERE SId = @Id";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Subject subject = new Subject
                    {
                        Id = (int)reader["SId"],
                        Name = (string)reader["SName"],
                        Description = (string)reader["Description"],
                        ContentType = (string)reader["ContentType"],
                        DateAdded = (DateTime)reader["DateAdded"],
                        IsActive = (bool)reader["IsActive"]
                    };

                    return subject;
                }
                else
                {
                    return null;
                }
            }
        }
        public byte[] GetContentBySubjectId(int subjectId)
        {
            byte[] content = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT ContentData FROM ContentTbl WHERE SubjectId = @SubjectId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SubjectId", subjectId);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    content = (byte[])result;
                }
            }

            return content;
        }
        public async Task<List<Content>> GetContentsBySubjectIdAsync(int subjectId)
        {
            List<Content> contents = new List<Content>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM ContentTbl WHERE SubjectId = @SubjectId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SubjectId", subjectId);

                await connection.OpenAsync();

                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    int contentId = (int)reader["ContentId"];
                    int subjectIdFromDb = (int)reader["SubjectId"];
                    string contentType = (string)reader["ContentType"];
                    string contentTitle = (string)reader["ContentTitle"];
                    byte[] contentData = (byte[])reader["ContentData"];
                    DateTime dateAdded = (DateTime)reader["DateAdded"];

                    Content content = new Content
                    {
                        ContentId = contentId,
                        SubjectId = subjectIdFromDb,
                        ContentType = contentType,
                        ContentTitle = contentTitle,
                        ContentData = contentData,
                        DateAdded = dateAdded // Set the DateAdded property
                    };

                    contents.Add(content);
                }

                connection.Close();
            }

            return contents;
        }
        public int InsertSubject(Subject subject)
        {
            int subjectId = 0;
                using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert the subject data
                        string insertSubjectQuery = "INSERT INTO SubjectTbl (SName, Description, Content, ContentType, DateAdded, IsActive) " +
                            "VALUES (@Name, @Description, @Content, @ContentType, @DateAdded, @IsActive); " +
                            "SELECT CAST(scope_identity() AS int);";
                        SqlCommand insertSubjectCommand = new SqlCommand(insertSubjectQuery, connection, transaction);
                        insertSubjectCommand.Parameters.AddWithValue("@Name", subject.Name);
                        insertSubjectCommand.Parameters.AddWithValue("@Description", subject.Description);
                        insertSubjectCommand.Parameters.AddWithValue("@ContentType", subject.ContentType);
                        insertSubjectCommand.Parameters.AddWithValue("@DateAdded", subject.DateAdded);
                        insertSubjectCommand.Parameters.AddWithValue("@IsActive", subject.IsActive);
                        // Save the ContentData to the`Content` column in the `Subject` table
                        if (subject.Content != null && subject.Content.ContentData != null)
                        {
                            insertSubjectCommand.Parameters.AddWithValue("@Content", subject.Content.ContentData);
                        }
                        else
                        {
                            insertSubjectCommand.Parameters.AddWithValue("@Content", DBNull.Value);
                        }

                        subjectId = (int)insertSubjectCommand.ExecuteScalar();

                        // If a content object was included, save the content data to the database
                        if (subject.Content != null && subject.Content.ContentData != null)
                        {
                            // Insert the content data
                            string insertContentQuery = "INSERT INTO ContentTbl (SubjectId, ContentType, ContentTitle, ContentData) " +
                                "VALUES (@SubjectId, @ContentType, @ContentTitle, @ContentData);";
                            SqlCommand insertContentCommand = new SqlCommand(insertContentQuery, connection, transaction);
                            insertContentCommand.Parameters.AddWithValue("@SubjectId", subjectId);
                            insertContentCommand.Parameters.AddWithValue("@ContentType", subject.Content.ContentType);
                            insertContentCommand.Parameters.AddWithValue("@ContentTitle", subject.Content.ContentTitle);
                            insertContentCommand.Parameters.AddWithValue("@ContentData", subject.Content.ContentData);
                            insertContentCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }

            return subjectId;
        }
        public void UpdateSubject(Subject subject)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Update the subject data
                        string updateSubjectQuery = "UPDATE SubjectTbl SET SName = @Name, Description = @Description, " +
                            "ContentType = @ContentType, DateAdded = @DateAdded, IsActive = @IsActive " +
                            "WHERE SId = @Id";
                        SqlCommand updateSubjectCommand = new SqlCommand(updateSubjectQuery, connection, transaction);
                        updateSubjectCommand.Parameters.AddWithValue("@Name", subject.Name);
                        updateSubjectCommand.Parameters.AddWithValue("@Description", subject.Description);
                        updateSubjectCommand.Parameters.AddWithValue("@ContentType", subject.ContentType);
                        updateSubjectCommand.Parameters.AddWithValue("@DateAdded", subject.DateAdded);
                        updateSubjectCommand.Parameters.AddWithValue("@IsActive", subject.IsActive);
                        updateSubjectCommand.Parameters.AddWithValue("@Id", subject.Id);

                        updateSubjectCommand.ExecuteNonQuery();

                        // If a content object was included, update the content data in the database
                        if (subject.Content != null && subject.Content.ContentData != null)
                        {
                            // Check if there is any existing content data for the subject
                            string selectContentQuery = "SELECT COUNT(*) FROM ContentTbl WHERE SubjectId = @SubjectId";
                            SqlCommand selectContentCommand = new SqlCommand(selectContentQuery, connection, transaction);
                            selectContentCommand.Parameters.AddWithValue("@SubjectId", subject.Id);
                            int contentCount = (int)selectContentCommand.ExecuteScalar();

                            if (contentCount > 0)
                            {
                                // Update the existing content data
                                string updateContentQuery = "UPDATE ContentTbl SET ContentType = @ContentType, ContentTitle = @ContentTitle, ContentData = @ContentData " +
                                    "WHERE SubjectId = @SubjectId";
                                SqlCommand updateContentCommand = new SqlCommand(updateContentQuery, connection, transaction);
                                updateContentCommand.Parameters.AddWithValue("@SubjectId", subject.Id);
                                updateContentCommand.Parameters.AddWithValue("@ContentType", subject.Content.ContentType);
                                updateContentCommand.Parameters.AddWithValue("@ContentTitle", subject.Content.ContentTitle);
                                updateContentCommand.Parameters.AddWithValue("@ContentData", subject.Content.ContentData);

                                updateContentCommand.ExecuteNonQuery();
                            }
                            else
                            {
                                // Insert the new content data
                                string insertContentQuery = "INSERT INTO ContentTbl (SubjectId, ContentType, ContentTitle, ContentData) " +
                                    "VALUES (@SubjectId, @ContentType, @ContentTitle, @ContentData);";
                                SqlCommand insertContentCommand = new SqlCommand(insertContentQuery, connection, transaction);
                                insertContentCommand.Parameters.AddWithValue("@SubjectId", subject.Id);
                                insertContentCommand.Parameters.AddWithValue("@ContentType", subject.Content.ContentType);
                                insertContentCommand.Parameters.AddWithValue("@ContentTitle", subject.Content.ContentTitle);
                                insertContentCommand.Parameters.AddWithValue("@ContentData", subject.Content.ContentData);

                                insertContentCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // If content object is null, delete any existing content data for the subject
                            string deleteContentQuery = "DELETE FROM ContentTbl WHERE SubjectId = @SubjectId";
                            SqlCommand deleteContentCommand = new SqlCommand(deleteContentQuery, connection, transaction);
                            deleteContentCommand.Parameters.AddWithValue("@SubjectId", subject.Id);

                            deleteContentCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }


        public void DeleteSubject(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Delete the subject data
                        string deleteSubjectQuery = "DELETE FROM SubjectTbl WHERE SId = @Id";
                        SqlCommand deleteSubjectCommand = new SqlCommand(deleteSubjectQuery, connection, transaction);
                        deleteSubjectCommand.Parameters.AddWithValue("@Id", id);

                        deleteSubjectCommand.ExecuteNonQuery();

                        // Delete any existing content data for the subject
                        string deleteContentQuery = "DELETE FROM ContentTbl WHERE SubjectId = @SubjectId";
                        SqlCommand deleteContentCommand = new SqlCommand(deleteContentQuery, connection, transaction);
                        deleteContentCommand.Parameters.AddWithValue("@SubjectId", id);

                        deleteContentCommand.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public bool SubjectHasContent(int sId)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM ContentTbl WHERE SubjectId = @SubjectId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SubjectId", sId);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        public List<Content> GetMediaContentList(string query)
        {
            List<Content> contentList = new List<Content>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Content content = new Content();
                        content.SubjectId = reader.GetInt32(0);
                        content.ContentType = reader.GetString(1);
                        content.ContentTitle = reader.GetString(2);
                        content.ContentData = (byte[])reader["ContentData"];
                        contentList.Add(content);
                    }
                }
            }

            return contentList;
        }
        public int GetTotalMediaContentCount(string query)
        {
            int totalRecords = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        totalRecords = reader.GetInt32(0);
                    }
                }
            }

            return totalRecords;
        }

        public Subject GetSubjectByName(string name)
        {
            string query = "SELECT * FROM SubjectTbl WHERE SName = @Name";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = (int)reader["SId"];
                    string description = (string)reader["Description"];
                    string contentType = (string)reader["ContentType"];
                    DateTime dateAdded = (DateTime)reader["DateAdded"];
                    bool isActive = (bool)reader["IsActive"];

                    Content content = null;
                    if (!reader.IsDBNull(reader.GetOrdinal("ContentTitle")))
                    {
                        content = new Content
                        {
                            ContentId = reader["ContentId"] is DBNull ? 0 : (int)reader["ContentId"],
                            SubjectId = reader["SubjectId"] is DBNull ? 0 : (int)reader["SubjectId"],
                            ContentType = (string)reader["ContentType"],
                            ContentTitle = (string)reader["ContentTitle"],
                            ContentData = (byte[])reader["ContentData"]
                        };
                    }

                    Subject subject = new Subject
                    {
                        Id = id,
                        Name = name,
                        Description = description,
                        ContentType = contentType,
                        DateAdded = dateAdded,
                        IsActive = isActive,
                        Content = content
                    };

                    return subject;
                }
            }

            return null;
        }
        public int InsertContent(Content content)
        {
            string query = "INSERT INTO ContentTbl(SubjectId, ContentType, ContentTitle, ContentData) VALUES(@SubjectId, @ContentType, @ContentTitle, @ContentData)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SubjectId", content.SubjectId);
                command.Parameters.AddWithValue("@ContentType", content.ContentType);
                command.Parameters.AddWithValue("@ContentTitle", content.ContentTitle);
                command.Parameters.AddWithValue("@ContentData", content.ContentData);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                return rowsAffected;
            }
        }
        public void UpdateContent(Content content)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                con.Open();
                string updateContentQuery = "UPDATE ContentTbl SET ContentType = @ContentType, ContentTitle = @ContentTitle, ContentData = @ContentData WHERE SubjectId = @SubjectId";
                SqlCommand updateContentCmd = new SqlCommand(updateContentQuery, con);
                updateContentCmd.Parameters.AddWithValue("@ContentType", content.ContentType);
                updateContentCmd.Parameters.AddWithValue("@ContentTitle", content.ContentTitle);
                updateContentCmd.Parameters.AddWithValue("@ContentData", content.ContentData);
                updateContentCmd.Parameters.AddWithValue("@SubjectId", content.SubjectId);
                updateContentCmd.ExecuteNonQuery();
            }
        }
        public void DeleteContent(int contentId) 
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM ContentTbl WHERE ContentId = @ContentId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ContentId", contentId);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
        public async Task DeleteContentByIdAsync(int contentId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM ContentTbl WHERE ContentId = @ContentId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ContentId", contentId);

                await connection.OpenAsync();

                await command.ExecuteNonQueryAsync();

                connection.Close();
            }
        }
    }
}