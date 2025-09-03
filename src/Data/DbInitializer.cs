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
        public static void CreateTablesIfNotExists()
        {
            Debug.WriteLine($"Ejecutando consulta para crear las tabla de roles: {createRolesTable}");
            Database.ExecuteNonQuery(createRolesTable);
            // Insertar los roles default
            foreach (string role in Config.defaultRoles)
            {
                RoleRepository.Insert(new RoleModel { Name = role });
            }
            Debug.WriteLine($"Ejecutando consulta para crear las tabla de usuarios: {createUsersTable}");
            Database.ExecuteNonQuery(createUsersTable);
            Debug.WriteLine($"Ejecutando consulta para crear las tabla de entornos formativos: {createFormativeEnvironmentsTable}");
            Database.ExecuteNonQuery(createFormativeEnvironmentsTable);
        }

        public static UserModel? CreateAdminUserIfNotExists()
        {
            string query = "SELECT * FROM Users LIMIT 1;";
            SqliteDataReader sqlDataReader = Database.ExecuteReader(query);
            if (sqlDataReader.HasRows) return null;
            UserModel user = new UserModel();
            sqlDataReader.Close();
            user.Username = "admin";
            user.Password = Utils.GenerateRandomString(12);
            user.Name = "Administrador";
            user.Surname = "Sistema";
            user.RoleId = 1;
            UserRepository.Insert(user);
            return user;
        }
    }
}
