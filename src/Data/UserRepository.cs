using GestionAgraria.models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GestionAgraria.data
{
    public static class UserRepository
    {
        public static List<UserModel> GetAll()
        {
            var users = new List<UserModel>();
            string query = "SELECT * FROM Users";

            using var reader = Database.ExecuteReader(query);
            while (reader.Read())
            {
                users.Add(new UserModel
                {
                    id = reader.GetInt32(reader.GetOrdinal("id")),
                    username = reader.GetString(reader.GetOrdinal("username")),
                    password = reader.GetString(reader.GetOrdinal("password")),
                    name = reader.GetString(reader.GetOrdinal("name")),
                    surname = reader.GetString(reader.GetOrdinal("surname")),
                    personId = reader.GetString(reader.GetOrdinal("personId")),
                    email = reader.GetString(reader.GetOrdinal("email")),
                    phone = reader.GetString(reader.GetOrdinal("phone")),
                    roleId = reader.GetInt32(reader.GetOrdinal("roleId")),
                    isActive = reader.GetInt32(reader.GetOrdinal("isActive"))
                });
            }
            return users;
        }
        public static UserModel? Get(string username)
        {
            string query = "SELECT * FROM Users WHERE username = @username";
            var parameters = new Dictionary<string, object>
            {
                { "@username", username }
            };
            using var reader = Database.ExecuteReader(query, parameters);
            if (reader.Read())
            {
                return new UserModel
                {
                    id = reader.GetInt32(reader.GetOrdinal("id")),
                    username = reader.GetString(reader.GetOrdinal("username")),
                    password = reader.GetString(reader.GetOrdinal("password")),
                    name = reader.GetString(reader.GetOrdinal("name")),
                    surname = reader.GetString(reader.GetOrdinal("surname")),
                    personId = reader.GetString(reader.GetOrdinal("personId")),
                    email = reader.GetString(reader.GetOrdinal("email")),
                    phone = reader.GetString(reader.GetOrdinal("phone")),
                    roleId = reader.GetInt32(reader.GetOrdinal("roleId")),
                    isActive = reader.GetInt32(reader.GetOrdinal("isActive"))
                };
            }
            return null;
        }

        public static void Insert(UserModel user)
        {
            string query = @"
            INSERT INTO Users (username, password, name, surname, personId, email, phone, roleId)
            VALUES (@username, @password, @name, @surname, @personId, @email ,@phone, @roleId);";

            var parameters = new Dictionary<string, object>
            {
                { "@username", user.username },
                { "@password", user.password },
                { "@name", user.name },
                { "@surname", user.surname },
                { "@personId", user.personId },
                { "@email", user.email },
                { "@phone", user.phone },
                { "@roleId", user.roleId },
                { "@isActive", user.isActive }
            };
            Database.ExecuteNonQuery(query, parameters);
        }

        public static void Update(UserModel user)
        {
            string query = @"
            UPDATE Users
            SET password = @password,
                name = @name,
                surname = @surname,
                personId = @personId,
                email = @email,
                phone = @phone,
                roleId = @roleId
            WHERE id = @id;";
            var parameters = new Dictionary<string, object>
            {
                { "@id", user.id },
                { "@username", user.username },
                { "@password", user.password },
                { "@name", user.name },
                { "@surname", user.surname },
                { "@personId", user.personId },
                { "@email", user.email },
                { "@phone", user.phone },
                { "@roleId", user.roleId },
                { "@isActive", user.isActive }
            };
            Database.ExecuteNonQuery(query, parameters);
        }
    }
}
