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
            string query = @"SELECT S.SId, S.SName, S.Description, S.IsActive, C.ContentType, C.DateAdded, C.ContentTitle, C.ContentData
                     FROM SubjectTbl S
                     LEFT JOIN ContentTbl C ON S.SId = C.SubjectId
                     WHERE S.SId = @Id";

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
                        IsActive = (bool)reader["IsActive"],
                        Content = new Content
                        {
                            ContentType = reader["ContentType"] != DBNull.Value ? (string)reader["ContentType"] : null,
                            DateAdded = reader["DateAdded"] != DBNull.Value ? (DateTime)reader["DateAdded"] : default,
                            ContentTitle = reader["ContentTitle"] != DBNull.Value ? (string)reader["ContentTitle"] : null,
                            ContentData = reader["ContentData"] != DBNull.Value ? (byte[])reader["ContentData"] : null
                        }
                    };

                    return subject;
                }
                else
                {
                    return null;
                }
            }
        }
        public List<Subject> GetActiveSubjectList()
        {
            string query = @"SELECT st.*, ct.ContentId, ct.ContentTitle, ct.ContentData
                 FROM SubjectTbl st
                 LEFT JOIN ContentTbl ct ON st.SId = ct.SubjectId
                 WHERE st.IsActive = 1";
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
                            ContentId = reader.IsDBNull(reader.GetOrdinal("ContentId")) ? 0 : (int)reader["ContentId"],
                            SubjectId = id,
                            ContentType = (string)reader["ContentType"],
                            ContentTitle = (string)reader["ContentTitle"],
                            ContentData = (byte[])reader["ContentData"],
                            DateAdded = (DateTime)reader["DateAdded"]
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

                        // Update or delete the content data
                        if (subject.Content != null && subject.Content.ContentData != null)
                        {
                            // Update the existing content data or insert new content data
                            string mergeContentQuery = @"MERGE INTO ContentTbl AS target
                                                 USING (SELECT @SubjectId AS SubjectId, @ContentType AS ContentType, @ContentTitle AS ContentTitle, 
                                                        @ContentData AS ContentData) AS source
                                                 ON (target.SubjectId = source.SubjectId)
                                                 WHEN MATCHED THEN
                                                     UPDATE SET target.ContentType = source.ContentType, 
                                                                target.ContentTitle = source.ContentTitle, 
                                                                target.ContentData = source.ContentData
                                                 WHEN NOT MATCHED THEN
                                                     INSERT (SubjectId, ContentType, ContentTitle, ContentData)
                                                     VALUES (source.SubjectId, source.ContentType, source.ContentTitle, source.ContentData);";
                            SqlCommand mergeContentCommand = new SqlCommand(mergeContentQuery, connection, transaction);
                            mergeContentCommand.Parameters.AddWithValue("@SubjectId", subject.Id);
                            mergeContentCommand.Parameters.AddWithValue("@ContentType", subject.Content.ContentType);
                            mergeContentCommand.Parameters.AddWithValue("@ContentTitle", subject.Content.ContentTitle);
                            mergeContentCommand.Parameters.AddWithValue("@ContentData", subject.Content.ContentData);

                            mergeContentCommand.ExecuteNonQuery();
                        }
                        else
                        {
                            // Delete any existing content data for the subject
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
                        // Retrieve the ContentIds for the given SubjectId
                        string selectContentIdsQuery = "SELECT ContentId FROM ContentTbl WHERE SubjectId = @SubjectId";
                        SqlCommand selectContentIdsCommand = new SqlCommand(selectContentIdsQuery, connection, transaction);
                        selectContentIdsCommand.Parameters.AddWithValue("@SubjectId", id);

                        List<int> contentIdsToDelete = new List<int>();
                        using (SqlDataReader reader = selectContentIdsCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                contentIdsToDelete.Add(reader.GetInt32(reader.GetOrdinal("ContentId")));
                            }
                        }

                        // Delete the content data for the subject
                        string deleteContentQuery = "DELETE FROM ContentTbl WHERE ContentId = @ContentId";
                        SqlCommand deleteContentCommand = new SqlCommand(deleteContentQuery, connection, transaction);

                        foreach (int contentId in contentIdsToDelete)
                        {
                            deleteContentCommand.Parameters.Clear();
                            deleteContentCommand.Parameters.AddWithValue("@ContentId", contentId);
                            deleteContentCommand.ExecuteNonQuery();
                        }

                        // Delete the subject data
                        string deleteSubjectQuery = "DELETE FROM SubjectTbl WHERE SId = @Id";
                        SqlCommand deleteSubjectCommand = new SqlCommand(deleteSubjectQuery, connection, transaction);
                        deleteSubjectCommand.Parameters.AddWithValue("@Id", id);

                        deleteSubjectCommand.ExecuteNonQuery();

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
        public List<Content> GetMediaContentList(int subjectId, string contentTypeFilter)
        {
            List<Content> contentList = new List<Content>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Construct the SQL query with a JOIN on the Subject table
                string query = "SELECT c.ContentId, c.SubjectId, c.ContentType, c.ContentTitle, c.ContentData, c.DateAdded," +
                    " s.SId, s.SName, s.Description, s.ContentType, s.DateAdded AS SubjectDateAdded, s.IsActive FROM ContentTbl " +
                    "AS c JOIN SubjectTbl AS s ON c.SubjectId = s.SId WHERE c.SubjectId = @SubjectId AND " +
                    "(@ContentTypeFilter = 'All' OR c.ContentType = @ContentTypeFilter)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SubjectId", subjectId);
                command.Parameters.AddWithValue("@ContentTypeFilter", contentTypeFilter); // <-- updated parameter name

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Create a new Content object with its corresponding Subject object
                        Content content = new Content();
                        content.ContentId = reader.GetInt32(0);
                        content.SubjectId = reader.GetInt32(1);
                        content.ContentType = reader.GetString(2);
                        content.ContentTitle = reader.GetString(3);
                        content.ContentData = (byte[])reader["ContentData"];
                        content.DateAdded = reader.GetDateTime(5);

                        Subject subject = new Subject();
                        subject.Id = reader.GetInt32(6);
                        subject.Name = reader.GetString(7);
                        subject.Description = reader.GetString(8);
                        subject.ContentType = reader.GetString(9);
                        subject.DateAdded = reader.GetDateTime(10);
                        subject.IsActive = reader.GetBoolean(11);

                        content.Subject = subject;
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