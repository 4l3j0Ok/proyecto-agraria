using GestionAgraria.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAgraria.data
{
    internal class FormativeEnvironmentRepository
    {
        public static List<RoleModel> GetAll()
        {
            var formativeEnvironments = new List<RoleModel>();
            string query = "SELECT id, name FROM FormativeEnvironments";

            using var reader = Database.ExecuteReader(query);
            while (reader.Read())
            {
                formativeEnvironments.Add(new RoleModel
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                });
            }
            return formativeEnvironments;
        }

        public static void Insert(FormativeEnvironmentModel formativeEnvironment)
        {
            string query = @"
                INSERT INTO FormativeEnvironments (name)
                VALUES (@name);";

            var parameters = new Dictionary<string, object>
            {
                { "@name", formativeEnvironment.Name }
            };
            Database.ExecuteNonQuery(query, parameters);
        }
    }
}
