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
        public static UserModel? InitializeUser()
        {
            using var context = new AppDbContext();

            // Crear la base de datos y las tablas si no existen
            context.Database.EnsureCreated();

            // Seed de roles por defecto
            context.SeedDefaultRoles();
            context.SeedDefaultAnimalTypes();

            // Crear usuario administrador si no existe
            UserModel? user = context.CreateAdminUserIfNotExists();
            return user;
        }
    }
}
