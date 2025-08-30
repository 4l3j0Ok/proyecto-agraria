using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.IO;

namespace GestionAgraria
{
    internal class Database
    {
        public static void ExecuteNonQuery(string query)
        {
            using (SqliteConnection connection = new SqliteConnection(Config.sql_connection_string))
            {
                try
                {
                    connection.Open();
                    using (SqliteCommand command = new SqliteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        Debug.WriteLine($"Consulta ejecutada correctamente: {query}");
                    }
                }
                catch (SqliteException ex)
                {
                    Debug.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
                }
            }
        }

        public static SqliteDataReader ExecuteReader(string query)
        {
            SqliteConnection connection = new SqliteConnection(Config.sql_connection_string);
            try
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(query, connection);
                SqliteDataReader reader = command.ExecuteReader();
                Debug.WriteLine($"Consulta ejecutada correctamente: {query}");
                return reader;
            }
            catch (SqliteException ex)
            {
                Debug.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
                connection.Close();
                throw;
            }
        }

        public static void CreateTablesIfNotExists()
        {
            Debug.WriteLine($"Ejecutando consulta para crear las tabla de roles: {Queries.createRolesTable}");
            ExecuteNonQuery(Queries.createRolesTable);
            // Insertar los roles default
            foreach (KeyValuePair<string, string> role in Config.defaultRoles)
            {
                string query = Queries.insertRole(role.Key, role.Value);
                Debug.WriteLine($"Ejecutando consulta para crear el rol {role.Value}: {query}");
                ExecuteNonQuery(query);
            }
            Debug.WriteLine($"Ejecutando consulta para crear las tabla de usuarios: {Queries.createUsersTable}");
            ExecuteNonQuery(Queries.createUsersTable);
            Debug.WriteLine($"Ejecutando consulta para crear las tabla de entornos formativos: {Queries.createFormativeEnvironmentsTable}");
            ExecuteNonQuery(Queries.createFormativeEnvironmentsTable);
        }

        public static Dictionary<string, string> CreateAdminUserIfNotExists()
        {
            string query = "SELECT * FROM Users LIMIT 1;";
            Dictionary<string, string> user = new Dictionary<string, string>();
            SqliteDataReader sqlDataReader = ExecuteReader(query);
            if (!sqlDataReader.HasRows)
            {
                string username = "admin";
                string password = Utils.GenerateRandomString(12);
                query = Queries.insertUser(
                    username: username,
                    password: password,
                    name: "Administrador",
                    surname: "Sistema",
                    roleId: 1
                );
                Debug.WriteLine(query);
                ExecuteNonQuery(query);
                user["username"] = username;
                user["password"] = password;
            }
            sqlDataReader.Close();
            return user;
        }
        public static string GetUserPassword(string username)
        {
            string password = "";
            string query = Queries.getUserPassword(username);
            SqliteDataReader reader = ExecuteReader(query);
            if (reader.Read())
                password = reader["password"].ToString() ?? "";
            reader.Close();
            return password;
        }
    }
    public static class Queries
    {
        public static string createRolesTable = $@"
            CREATE TABLE IF NOT EXISTS Roles (
                id TEXT PRIMARY KEY,
                name TEXT NOT NULL
            );";
        public static string createUsersTable = @$"
            CREATE TABLE IF NOT EXISTS Users (
                username TEXT PRIMARY KEY,
                password TEXT NOT NULL,
                name TEXT NOT NULL,
                surname TEXT NOT NULL,
                roleId TEXT NOT NULL
            );";
        public static string createFormativeEnvironmentsTable = @$"
            CREATE TABLE IF NOT EXISTS FormativeEnvironments (
                id TEXT PRIMARY KEY,
                name TEXT NOT NULL
            );";
        public static string insertUser(string username, string password, string name, string surname, int roleId) => @$"
            INSERT INTO Users (username, password, name, surname, roleId)
            VALUES ('{username}', '{password}', '{name}', '{surname}', {roleId});";
        public static string insertRole(string id, string name) => @$"
            INSERT INTO Roles (id, name)
            VALUES ('{id}' , '{name}');";
        public static string getUserPassword(string username) => @$"
            SELECT password FROM Users WHERE username = '{username}';";
    }
}
