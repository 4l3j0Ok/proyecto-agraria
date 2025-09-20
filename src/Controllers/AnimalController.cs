using GestionAgraria.data;
using GestionAgraria.models;
using GestionAgraria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                .Where(a => a.IsActive)
                .ToList();
        }

        public AnimalModel? GetAnimalById(int id)
        {
            return _context.Animals
                .FirstOrDefault(a => a.Id == id);
        }

        public AnimalModel? GetAnimalByCode(string code)
        {
            return _context.Animals
                .FirstOrDefault(a => a.Code == code && a.IsActive);
        }

        public List<AnimalModel> GetAnimalsByFormativeEnvironment(int formativeEnvironmentId)
        {
            return _context.Animals
                .ToList();
        }

        public List<AnimalModel> GetAnimalsByType(string animalType)
        {
            return _context.Animals
                .Where(a => a.AnimalType == animalType && a.IsActive)
                .ToList();
        }

        public List<AnimalModel> GetAnimalsBySex(string sex)
        {
            return _context.Animals
                .Where(a => a.Sex == sex && a.IsActive)
                .ToList();
        }

        public List<AnimalModel> GetAnimalsByProductiveState(string productiveState)
        {
            return _context.Animals
                .Where(a => a.ProductiveState == productiveState && a.IsActive)
                .ToList();
        }

        public bool CreateAnimal(AnimalModel animal)
        {
            try
            {
                // Validar que el código no exista
                if (_context.Animals.Any(a => a.Code == animal.Code))
                    return false;
                _context.Animals.Add(animal);
                _context.SaveChanges();
                return true;
            }
            catch
            {
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
                .Include(fe => fe.Responsible)
                .Where(fe => fe.IsActive)
                .ToList();
        }

        public List<string> GetDistinctAnimalTypes()
        {
            return _context.Animals
                .Where(a => a.IsActive)
                .Select(a => a.AnimalType)
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
