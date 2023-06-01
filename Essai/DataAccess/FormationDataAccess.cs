using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Essai.Models;
using Microsoft.Data.SqlClient;


namespace Essai.DataAccess
{
    public class FormationDataAccess
    {
        private readonly string _connectionString;

        public FormationDataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int CountFormations()
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("SELECT COUNT(*) FROM Formation", connection))
            {
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public void LoadFormations(DataGridView formationGridView)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("SELECT FId, FName, ContentType, Content, Trainer, BeginDate, EndDate, DeptName FROM Formation", connection))
            {
                connection.Open();
                using (var adapter = new SqlDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    formationGridView.AutoGenerateColumns = false;
                    formationGridView.DataSource = dataTable;
                }
            }
        }
        public List<Formation> GetAllFormations()
        {
            var formations = new List<Formation>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("SELECT FId, FName, ContentType, Content, Trainer, BeginDate, EndDate, DeptName FROM Formation", connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var formation = MapFormation(reader);
                        formations.Add(formation);
                    }
                }
            }

            return formations;
        }

        public List<Department> GetAllDepartments()
        {
            var departments = new List<Department>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("SELECT Id, Name FROM Department", connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var department = new Department
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"]
                        };

                        departments.Add(department);
                    }
                }
            }

            return departments;
        }

        public Formation GetFormationById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("SELECT FId, FName, ContentType, Content, Trainer, BeginDate, EndDate, DeptName FROM Formation WHERE FId = @Id", connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var formation = MapFormation(reader);
                        return formation;
                    }
                }
            }

            return null;
        }

        public async Task<List<Formation>> GetAllFormationsAsync()
        {
            var formations = new List<Formation>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("SELECT FId, FName, ContentType, Content, Trainer, BeginDate, EndDate, DeptName FROM Formation", connection))
            {
                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var formation = MapFormation(reader);
                        formations.Add(formation);
                    }
                }
            }

            return formations;
        }

        public async Task<Formation> GetFormationByIdAsync(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("SELECT FId, FName, ContentType, Content, Trainer, BeginDate, EndDate, DeptName FROM Formation WHERE FId = @Id", connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        var formation = MapFormation(reader);
                        return formation;
                    }
                }
            }

            return null;
        }

        public int InsertFormation(Formation formation)
        {
            if (formation == null)
            {
                throw new ArgumentNullException(nameof(formation));
            }

            if (string.IsNullOrEmpty(formation.DeptName))
            {
                throw new ArgumentException("Department name cannot be null or empty.", nameof(formation.DeptName));
            }

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("INSERT INTO Formation (FName, ContentType, Trainer, BeginDate, EndDate, DeptName, Content) " +
                "VALUES (@Name, @ContentType, @Trainer, @BeginDate, @EndDate,@DeptName, @Content); SELECT CAST(scope_identity() AS int);", connection))
            {
                command.Parameters.AddWithValue("@Name", formation.Name);
                command.Parameters.AddWithValue("@ContentType", formation.ContentType);
                command.Parameters.AddWithValue("@Trainer", (object)formation.Trainer ?? DBNull.Value);
                command.Parameters.AddWithValue("@BeginDate", (object)formation.BeginDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@EndDate", (object)formation.EndDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@DeptName", formation.DeptName);
                command.Parameters.AddWithValue("@Content", (object)formation.Content ?? DBNull.Value);

                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }
        public int UpdateFormation(Formation formation)
        {
            if (formation == null)
            {
                throw new ArgumentNullException(nameof(formation));
            }

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("UPDATE Formation SET FName = @Name, ContentType = @ContentType, Content = @Content, " +
                "Trainer = @Trainer, BeginDate = @BeginDate, EndDate = @EndDate, DeptName = @DeptName WHERE FId = @Id", connection))
            {
                command.Parameters.AddWithValue("@Name", formation.Name);
                command.Parameters.AddWithValue("@ContentType", formation.ContentType);
                command.Parameters.AddWithValue("@Content", formation.Content);
                command.Parameters.AddWithValue("@Trainer", (object)formation.Trainer ?? DBNull.Value);
                command.Parameters.AddWithValue("@BeginDate", (object)formation.BeginDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@EndDate", (object)formation.EndDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@DeptName", formation.DeptName);
                command.Parameters.AddWithValue("@Id", formation.Id);

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
        public async Task<List<Formation>> GetFormationsByDepartmentAsync(string departmentName)
        {
            var formations = new List<Formation>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("SELECT FId, FName, ContentType, Content, Trainer, BeginDate, EndDate, DeptName FROM Formation WHERE DeptName = @DeptName", connection))
            {
                command.Parameters.AddWithValue("@DeptName", departmentName);

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var formation = MapFormation(reader);
                        formations.Add(formation);
                    }
                }
            }

            return formations;
        }
        public int DeleteFormation(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("DELETE FROM Formation WHERE FId = @Id", connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }


        private static Formation MapFormation(IDataRecord record)
        {
            var formation = new Formation
            {
                Id = (int)record["FId"],
                Name = (string)record["FName"],
                ContentType = (string)record["ContentType"],
                Trainer = record["Trainer"] != DBNull.Value ? (string)record["Trainer"] : null,
                BeginDate = record["BeginDate"] != DBNull.Value ? (DateTime?)record["BeginDate"] : null,
                EndDate = record["EndDate"] != DBNull.Value ? (DateTime?)record["EndDate"] : null,
                DeptName = (string)record["DeptName"],
                Content = record["Content"] != DBNull.Value ? (byte[])record["Content"] : null
            };

            return formation;
        }
    }
}