using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementApp.Infrastructure.Data
{
    public class SqlDataAccess : IDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionStringName, bool isStoredProcedure)
        {
            string connectionString = _config.GetConnectionString(connectionStringName);
            CommandType commandType = GetCommandType(isStoredProcedure);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement, parameters, commandType: commandType).ToList();
                return rows;
            }
        }

        public void SaveData<T>(string sqlStatement, T parameters, string connectionStringName, bool isStoredProcedure = false)
        {
            string connectionString = _config.GetConnectionString(connectionStringName);
            CommandType commandType = GetCommandType(isStoredProcedure);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(sqlStatement, parameters, commandType: commandType);
            }
        }

        private CommandType GetCommandType(bool isStoredProcedure)
        {
            return isStoredProcedure ? CommandType.StoredProcedure : CommandType.Text;
        }
    }
}
