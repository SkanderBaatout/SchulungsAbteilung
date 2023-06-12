using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai.DataAccess
{
    public sealed class DataAccessLayer : IDisposable
    {
        private static readonly Lazy<DataAccessLayer> lazyInstance = new Lazy<DataAccessLayer>(() => new DataAccessLayer());
        private readonly string _connectionString;
        private readonly SqlConnection _connection;

        private DataAccessLayer()
        {
            _connectionString = @"datasource=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public static DataAccessLayer Instance { get { return lazyInstance.Value; } }

        public DataTable ExecuteDataTable(string query, Dictionary<string, object> parameters = null)
        {
            using (var command = new SqlCommand(query, _connection))
            {
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value ?? DBNull.Value);
                    }
                }

                var dataTable = new DataTable();
                using (var dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }

                return dataTable;
            }
        }

        public T ExecuteScalar<T>(string query, Dictionary<string, object> parameters = null)
        {
            using (var command = new SqlCommand(query, _connection))
            {
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value ?? DBNull.Value);
                    }
                }

                var result = command.ExecuteScalar();
                return result == DBNull.Value ? default : (T)result;
            }
        }

        public void ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (var command = new SqlCommand(query, _connection))
            {
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value ?? DBNull.Value);
                    }
                }

                command.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            _connection?.Dispose();
        }
    }
}