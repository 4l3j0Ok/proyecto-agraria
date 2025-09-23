using GestionAgraria.models;
using GestionAgraria.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace GestionAgraria.data
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<RoleModel> Roles { get; set; }
        public DbSet<FormativeEnvironmentModel> FormativeEnvironments { get; set; }
        public DbSet<AnimalModel> Animals { get; set; }
        public DbSet<AnimalTypeModel> AnimalTypes { get; set; }
        public DbSet<VegetalModel> Vegetables { get; set; }

        public DbSet<ProductModel> Product { get; set; }

        // acá agregamos todos los modelos que tengamos
        // public DbSet<ProductModel> Products { get; set; }
        // public DbSet<InvoiceModel> Invoices { get; set; }
        // etc...

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Config.sql_connection_string);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de la relación User-Role
            modelBuilder.Entity<UserModel>()
                .HasOne(u => u.Role)
                .WithMany()
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuración de la relación Animal - FormativeEnviroment
            modelBuilder.Entity<AnimalModel>()
                .HasOne(a => a.FormativeEnvironment)
                .WithMany()
                .HasForeignKey(a => a.FormativeEnvironmentId)
                .OnDelete(DeleteBehavior.Restrict);
            // Configuración de la relación Animal-AnimalType
            modelBuilder.Entity<AnimalModel>()
                .HasOne(a => a.AnimalType)
                .WithMany()
                .HasForeignKey(a => a.AnimalTypeId)
                .OnDelete(DeleteBehavior.Restrict);
            // Configuración de índices únicos
            modelBuilder.Entity<UserModel>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<UserModel>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<UserModel>()
                .HasIndex(u => u.PersonId)
                .IsUnique();

            modelBuilder.Entity<ProductModel>()
                .HasIndex(u => u.code)
                .IsUnique();

            // Configuración de índices únicos para código de animal
            modelBuilder.Entity<AnimalModel>()
                .HasIndex(a => a.Code)
                .IsUnique();

            // Configuración de índices únicos para código de Producto
            modelBuilder.Entity<ProductModel>()
                .HasIndex(u => u.code)
                .IsUnique();

            // Configuración de la relación Product - FormativeEnviroment
            modelBuilder.Entity<ProductModel>()
                .HasOne(a => a.FormativeEnvironment)
                .WithMany()
                .HasForeignKey(a => a.FormativeEnvironmentId)
                .OnDelete(DeleteBehavior.Restrict);


            // Mapeo de nombres de tabla (si es necesario mantener compatibilidad)
            modelBuilder.Entity<UserModel>().ToTable("Users");
            modelBuilder.Entity<RoleModel>().ToTable("Roles");
            modelBuilder.Entity<FormativeEnvironmentModel>().ToTable("FormativeEnvironments");
            modelBuilder.Entity<AnimalModel>().ToTable("Animals");
            modelBuilder.Entity<AnimalTypeModel>().ToTable("AnimalTypes");
            modelBuilder.Entity<VegetalModel>().ToTable("Vegetables");
            modelBuilder.Entity<ProductModel>().ToTable("Product");

            base.OnModelCreating(modelBuilder);
        }

        public void SeedDefaultRoles()
        {
            foreach (var roleName in Config.defaultRoles)
            {
                if (!this.Roles.Any(r => r.Name == roleName))
                {
                    this.Roles.Add(new RoleModel { Name = roleName });
                }
            }
            this.SaveChanges();
        }
        public void SeedDefaultAnimalTypes()
        {
            foreach (var typeName in Config.defaultAnimalTypes)
            {
                if (!this.AnimalTypes.Any(t => t.Name == typeName))
                {
                    this.AnimalTypes.Add(new AnimalTypeModel { Name = typeName });
                }
            }
            this.SaveChanges();
        }

        public UserModel? GetUserByUsername(string username)
        {
            return this.Users
                .Include(u => u.Role)
                .FirstOrDefault(u => u.Username == username);
        }

        public List<UserModel> GetAllUsersWithRoles()
        {
            return this.Users
                .Include(u => u.Role)
                .Where(u => u.IsActive)
                .ToList();
        }

        public UserModel? CreateAdminUserIfNotExists()
        {
            if (this.Users.Any()) return null;

            var adminRole = this.Roles.FirstOrDefault(r => r.Name == "Administrador");
            if (adminRole == null) return null;

            var user = new UserModel
            {
                Username = "admin",
                Password = Utils.GenerateRandomString(12),
                Name = "Administrador",
                Surname = "Sistema",
                PersonId = "10000000",
                Email = "email@admin.com",
                Phone = "2224123456",
                RoleId = adminRole.Id,
                ProfilePicture = Utils.ImageToByteArray(Config.default_profile_picture),
                IsActive = true
            };

            this.Users.Add(user);
            this.SaveChanges();
            return user;
        }
    }
}
