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
            string query = "SELECT username, password, name, surname, roleId FROM Users";

            using var reader = Database.ExecuteReader(query);
            while (reader.Read())
            {
                users.Add(new UserModel
                {
                    Username = reader.GetString(0),
                    Password = reader.GetString(1),
                    Name = reader.GetString(2),
                    Surname = reader.GetString(3),
                    RoleId = reader.GetInt32(4)
                });
            }
            return users;
        }
        public static UserModel? Get(string username)
        {
            string query = "SELECT username, password, name, surname, roleId FROM Users WHERE username = @username";
            var parameters = new Dictionary<string, object>
            {
                { "@username", username }
            };
            using var reader = Database.ExecuteReader(query, parameters);
            if (reader.Read())
            {
                return new UserModel
                {
                    Username = reader.GetString(0),
                    Password = reader.GetString(1),
                    Name = reader.GetString(2),
                    Surname = reader.GetString(3),
                    RoleId = reader.GetInt32(4)
                };
            }
            return null;
        }

        public static void Insert(UserModel user)
        {
            string query = @"
            INSERT INTO Users (username, password, name, surname, roleId)
            VALUES (@username, @password, @name, @surname, @roleId);";

            var parameters = new Dictionary<string, object>
        {
            { "@username", user.Username },
            { "@password", user.Password },
            { "@name", user.Name },
            { "@surname", user.Surname },
            { "@roleId", user.RoleId }
        };

            Database.ExecuteNonQuery(query, parameters);
        }
    }
}
