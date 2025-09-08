using GestionAgraria.data;
using GestionAgraria.models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAgraria.data
{
    internal class DbInitializer
    {
        public static string createRolesTable = $@"
            CREATE TABLE IF NOT EXISTS Roles (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL
            );";
        public static string createUsersTable = @$"
            CREATE TABLE IF NOT EXISTS Users (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                username TEXT UNIQUE,
                password TEXT NOT NULL,
                name TEXT NOT NULL,
                surname TEXT NOT NULL,
                phone TEXT NOT NULL,
                personId TEXT NOT NULL,
                roleId TEXT NOT NULL,
                isActive INTEGER NOT NULL DEFAULT 1,
                FOREIGN KEY (roleId) REFERENCES Roles(id)
            );";
        public static string createFormativeEnvironmentsTable = @$"
            CREATE TABLE IF NOT EXISTS FormativeEnvironments (
                id TEXT PRIMARY KEY,
                name TEXT NOT NULL
            );";
        public static void CreateTablesIfNotExists()
        {
            Database.ExecuteNonQuery(createRolesTable);
            CreateDefaultRolesIfNotExists();
            Database.ExecuteNonQuery(createUsersTable);
            Debug.WriteLine($"Ejecutando consulta para crear las tabla de entornos formativos: {createFormativeEnvironmentsTable}");
            Database.ExecuteNonQuery(createFormativeEnvironmentsTable);
        }

        public static void CreateDefaultRolesIfNotExists()
        {
            string query = "SELECT * FROM Roles LIMIT 1;";
            bool hasAnyRole;

            using (var sqlDataReader = Database.ExecuteReader(query))
            {
                hasAnyRole = sqlDataReader.HasRows;
            }

            if (hasAnyRole) return;

            foreach (string role in Config.defaultRoles)
                RoleRepository.Insert(new RoleModel { Name = role });
        }

        public static UserModel? CreateAdminUserIfNotExists()
        {
            string query = "SELECT * FROM Users LIMIT 1;";
            using (var sqlDataReader = Database.ExecuteReader(query))
            {
                if (sqlDataReader.HasRows) return null;
            }

            int? roleId = null;
            query = "SELECT id FROM Roles WHERE name = 'Administrador' LIMIT 1;";
            using (SqliteDataReader roleDataReader = Database.ExecuteReader(query))
            {
                if (roleDataReader.Read())
                    roleId = roleDataReader.GetInt32(0);
            }

            if (roleId == null) return null;

            var user = new UserModel
            {
                username = "admin",
                password = Utils.GenerateRandomString(12),
                name = "Administrador",
                surname = "Sistema",
                personId = "10000000",
                phone = "2224123456",
                roleId = roleId.Value,
                isActive = 1
            };
            UserRepository.Insert(user);
            return user;
        }
    }
}
