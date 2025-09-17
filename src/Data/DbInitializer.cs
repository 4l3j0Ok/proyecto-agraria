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
        public static UserModel? Initialize()
        {
            using var context = new AppDbContext();

            // Crear la base de datos y las tablas si no existen
            context.Database.EnsureCreated();

            // Seed de roles por defecto
            SeedDefaultRoles(context);

            // Crear usuario administrador si no existe
            UserModel? user = CreateAdminUserIfNotExists(context);
            return user;
        }

        private static void SeedDefaultRoles(AppDbContext context)
        {
            if (context.Roles.Any()) return;

            foreach (string roleName in Config.defaultRoles)
            {
                context.Roles.Add(new RoleModel { Name = roleName });
            }
            context.SaveChanges();
        }

        private static UserModel? CreateAdminUserIfNotExists(AppDbContext context)
        {
            if (context.Users.Any()) return null;

            var adminRole = context.Roles.FirstOrDefault(r => r.Name == "Administrador");
            if (adminRole == null) return null;

            UserModel user = new UserModel
            {
                Username = "admin",
                Password = Utils.GenerateRandomString(12),
                Name = "Administrador",
                Surname = "Sistema",
                PersonId = "10000000",
                Email = "email@admin.com",
                Phone = "2224123456",
                RoleId = adminRole.Id,
                IsActive = true
            };

            context.Users.Add(user);
            context.SaveChanges();

            return user;
        }
    }
}
