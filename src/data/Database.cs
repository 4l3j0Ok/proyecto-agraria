using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.IO;
using GestionAgraria.controllers;
using GestionAgraria.data;

namespace GestionAgraria.data
{
    internal class Database
    {
        private static readonly string _connectionString = Config.sql_connection_string;

        public static int ExecuteNonQuery(string query, Dictionary<string, object>? parameters = null)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            using var command = new SqliteCommand(query, connection);
            if (parameters != null)
            {
                foreach (var param in parameters)
                    command.Parameters.AddWithValue(param.Key, param.Value);
            }
            Debug.WriteLine($"Ejecutando consulta: {command.CommandText}");
            return command.ExecuteNonQuery();
        }

        public static SqliteDataReader ExecuteReader(string query, Dictionary<string, object>? parameters = null)
        {
            var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var command = new SqliteCommand(query, connection);
            if (parameters != null)
            {
                foreach (var param in parameters)
                    command.Parameters.AddWithValue(param.Key, param.Value);
            }
            Debug.WriteLine($"Ejecutando consulta: {command.CommandText}");
            return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }
    }
}
