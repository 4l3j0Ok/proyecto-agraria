using GestionAgraria.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAgraria.data
{
    public static class RoleRepository
    {
        public static List<RoleModel> GetAll()
        {
            var roles = new List<RoleModel>();
            string query = "SELECT id, name, description FROM Roles";

            using var reader = Database.ExecuteReader(query);
            while (reader.Read())
            {
                roles.Add(new RoleModel 
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                });
            }
            return roles;
        }

        public static void Insert(RoleModel role)
        {
            string query = @"
                INSERT INTO Roles (name)
                VALUES (@name);";

            var parameters = new Dictionary<string, object>
            {
                { "@name", role.Name }
            };

            Database.ExecuteNonQuery(query, parameters);
        }
    }
}
