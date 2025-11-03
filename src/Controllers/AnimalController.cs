using GestionAgraria.data;
using GestionAgraria.models;
using GestionAgraria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GestionAgraria.controllers
{
    public class AnimalController : IDisposable
    {
        private readonly AppDbContext _context;

        public AnimalController()
        {
            _context = new AppDbContext();
        }

        public AnimalController(AppDbContext context)
        {
            _context = context;
        }

        public List<AnimalModel> GetAllAnimals()
        {
            return _context.Animals
                .Include(a => a.AnimalType)
                .Include(a => a.FormativeEnvironment)
                .Where(a => a.IsActive)
                .ToList();
        }
        public List<AnimalModel> GetAnimalsForFiltro(int estado,string? entorno = null,string? searchText = null,string? animalType = null,string? productiveState = null, int page = 1, int pageSize = 20)
        {
            var query = _context.Animals
                .Include(a => a.AnimalType)            // Incluimos tipo de animal
                .Include(a => a.FormativeEnvironment)  // Incluimos entorno
                .AsQueryable();

            // 📌 Filtro por estado (Activo / Inactivo / Todos)
            if (estado == 0) // Activos
                query = query.Where(a => a.IsActive);
            else if (estado == 1) // Inactivos
                query = query.Where(a => !a.IsActive);
            // estado == 2 → Todos (sin filtro)

            // 📌 Filtro por entorno
            if (!string.IsNullOrEmpty(entorno))
                query = query.Where(a => a.FormativeEnvironment.Name == entorno);

            // 📌 Filtro por tipo de animal
            if (!string.IsNullOrEmpty(animalType))
                query = query.Where(a => a.AnimalType.Name == animalType);

            // 📌 Filtro por estado productivo
            if (!string.IsNullOrEmpty(productiveState))
                query = query.Where(a => a.ProductiveState == productiveState);

            // 📌 Filtro por texto (ej: tipo, observaciones, sexo, etc.)
            if (!string.IsNullOrEmpty(searchText))
            {
                string lowerText = searchText.ToLower();
                query = query.Where(a =>
                    a.AnimalType.Name.ToLower().Contains(lowerText) ||  // nombre del tipo de animal
                    a.Sex.ToLower().Contains(lowerText) ||              // sexo
                    a.ProductiveState.ToLower().Contains(lowerText) ||  // estado productivo
                    a.Observations.ToLower().Contains(lowerText)        // observaciones
                );
            }

            // 📌 Pagination
            return query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public int GetAnimalsCountForFilter(int estado, string? entorno = null, string? searchText = null, string? animalType = null, string? productiveState = null)
        {
            var query = _context.Animals.AsQueryable();

            // 📌 Filtro por estado
            if (estado == 0) // Activos
                query = query.Where(a => a.IsActive);
            else if (estado == 1) // Inactivos
                query = query.Where(a => !a.IsActive);

            // 📌 Filtro por entorno
            if (!string.IsNullOrEmpty(entorno))
                query = query.Where(a => a.FormativeEnvironment.Name == entorno);

            // 📌 Filtro por tipo de animal
            if (!string.IsNullOrEmpty(animalType))
                query = query.Where(a => a.AnimalType.Name == animalType);

            // 📌 Filtro por estado productivo
            if (!string.IsNullOrEmpty(productiveState))
                query = query.Where(a => a.ProductiveState == productiveState);

            // 📌 Filtro por texto
            if (!string.IsNullOrEmpty(searchText))
            {
                string lowerText = searchText.ToLower();
                query = query.Where(a =>
                    a.AnimalType.Name.ToLower().Contains(lowerText) ||
                    a.Sex.ToLower().Contains(lowerText) ||
                    a.ProductiveState.ToLower().Contains(lowerText) ||
                    a.Observations.ToLower().Contains(lowerText)
                );
            }

            return query.Count();
        }

        public AnimalModel? GetAnimalById(int id)
        {
            return _context.Animals
                .Include(a => a.AnimalType)
                .Include(a => a.FormativeEnvironment)
                .FirstOrDefault(a => a.Id == id);
        }

        public AnimalModel? GetAnimalByCode(string code)
        {
            return _context.Animals
                .Include(a => a.AnimalType)
                .Include(a => a.FormativeEnvironment)
                .FirstOrDefault(a => a.Code == code && a.IsActive);
        }

        public List<AnimalModel> GetAnimalsByFormativeEnvironment(int formativeEnvironmentId)
        {
            return _context.Animals
                .Include(a => a.AnimalType)
                .Include(a => a.FormativeEnvironment)
                .ToList();
        }

        public List<AnimalTypeModel> GetAnimalTypes()
        {
            return _context.AnimalTypes
                .ToList();
        }
        public List<AnimalModel> GetAnimalsByType(string animalType)
        {
            return _context.Animals
                .Include(a => a.AnimalType)
                .Include(a => a.FormativeEnvironment)
                .Where(a => a.AnimalType.Name == animalType && a.IsActive)
                .ToList();
        }

        public List<AnimalModel> GetAnimalsBySex(string sex)
        {
            return _context.Animals
                .Include(a => a.AnimalType)
                .Include(a => a.FormativeEnvironment)
                .Where(a => a.Sex == sex && a.IsActive)
                .ToList();
        }

        public List<AnimalModel> GetAnimalsByProductiveState(string productiveState)
        {
            return _context.Animals
                .Include(a => a.AnimalType)
                .Include(a => a.FormativeEnvironment)
                .Where(a => a.ProductiveState == productiveState && a.IsActive)
                .ToList();
        }

        public bool CreateAnimal(AnimalModel animal)
        {
            try
            {
                // Validar que no exista el codigo:
                if (_context.Animals.Any(a => a.Code == animal.Code))
                    return false;
                _context.Animals.Add(animal);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        // Por nombre (case-insensitive y trim)
        public bool AnimalTypeExistsByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;

            string normalized = name.Trim().ToUpper();
            return _context.AnimalTypes
                .AsNoTracking()
                .Any(a => a.Name != null && a.Name.ToUpper() == normalized);
        }
        public bool CreateAnimalType(AnimalTypeModel type)
        {
            try
            {
                // Validación básica
                if (type == null || string.IsNullOrWhiteSpace(type.Name))
                    return false;

                // Normalizo el nombre de entrada (ignoro mayúsculas/minúsculas)
                string normalized = type.Name.Trim().ToUpperInvariant();

                // Verifico existencia previa (solo lectura)
                bool exists = _context.AnimalTypes
                    .AsNoTracking()
                    .Any(t => t.Name != null && t.Name.ToUpper() == normalized);

                if (exists)
                    return false;

                // Inserto
                _context.AnimalTypes.Add(type);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }


        public bool UpdateAnimal(AnimalModel animal)
        {
            try
            {
                var existingAnimal = _context.Animals.Find(animal.Id);
                if (existingAnimal == null)
                    return false;

                // Validar que el código no exista (excepto el animal actual)
                if (_context.Animals.Any(a => a.Code == animal.Code && a.Id != animal.Id))
                    return false;

                // Actualizar propiedades
                existingAnimal.Code = animal.Code;
                existingAnimal.AnimalType = animal.AnimalType;
                existingAnimal.BirthOrEntryDate = animal.BirthOrEntryDate;
                existingAnimal.Sex = animal.Sex;
                existingAnimal.ProductiveState = animal.ProductiveState;
                existingAnimal.Observations = animal.Observations;
                existingAnimal.IsActive = animal.IsActive;

                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeactivateAnimal(int animalId)
        {
            try
            {
                var animal = _context.Animals.Find(animalId);
                if (animal == null)
                    return false;

                animal.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ActivateAnimal(int animalId)
        {
            try
            {
                var animal = _context.Animals.Find(animalId);
                if (animal == null)
                    return false;

                animal.IsActive = true;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<FormativeEnvironmentModel> GetAllActiveFormativeEnvironments()
        {
            return _context.FormativeEnvironments
                .Where(fe => fe.IsActive)
                .ToList();
        }

        public List<string> GetDistinctAnimalTypes()
        {
            return _context.Animals
                .Include(a => a.AnimalType)
                .Where(a => a.IsActive)
                .Select(a => a.AnimalType.Name)
                .Distinct()
                .ToList();
        }

        public List<string> GetDistinctSexes()
        {
            return _context.Animals
                .Where(a => a.IsActive)
                .Select(a => a.Sex)
                .Distinct()
                .ToList();
        }

        public List<string> GetDistinctProductiveStates()
        {
            return _context.Animals
                .Where(a => a.IsActive)
                .Select(a => a.ProductiveState)
                .Distinct()
                .ToList();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
