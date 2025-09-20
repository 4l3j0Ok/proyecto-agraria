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
    public class VegetalController : IDisposable
    {
        private readonly AppDbContext _context;

        public VegetalController()
        {
            _context = new AppDbContext();
        }

        public VegetalController(AppDbContext context)
        {
            _context = context;
        }

        public List<VegetalModel> GetAllVegetables()
        {
            return _context.Vegetables
                .Where(v => v.IsActive)
                .ToList();
        }

        public VegetalModel? GetVegetalById(int id)
        {
            return _context.Vegetables
                .FirstOrDefault(v => v.Id == id);
        }

        public List<VegetalModel> GetVegetalsByPlantType(string plantType)
        {
            return _context.Vegetables
                .Where(v => v.IsActive)
                .ToList();
        }

        public bool CreateVegetal(VegetalModel vegetal)
        {
            try
            {
                // Validar que la cantidad sea positiva
                if (vegetal.Quantity <= 0)
                    return false;

                _context.Vegetables.Add(vegetal);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateVegetal(VegetalModel vegetal)
        {
            try
            {
                var existingVegetal = _context.Vegetables.Find(vegetal.Id);
                if (existingVegetal == null)
                    return false;
                // Validar que la cantidad sea positiva
                if (vegetal.Quantity <= 0)
                    return false;

                // Actualizar propiedades
                existingVegetal.PlantType = vegetal.PlantType;
                existingVegetal.Quantity = vegetal.Quantity;
                existingVegetal.Observations = vegetal.Observations;
                existingVegetal.IsActive = vegetal.IsActive;

                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateVegetalQuantity(int vegetalId, int newQuantity)
        {
            try
            {
                var vegetal = _context.Vegetables.Find(vegetalId);
                if (vegetal == null || newQuantity <= 0)
                    return false;

                vegetal.Quantity = newQuantity;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeactivateVegetal(int vegetalId)
        {
            try
            {
                var vegetal = _context.Vegetables.Find(vegetalId);
                if (vegetal == null)
                    return false;

                vegetal.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ActivateVegetal(int vegetalId)
        {
            try
            {
                var vegetal = _context.Vegetables.Find(vegetalId);
                if (vegetal == null)
                    return false;

                vegetal.IsActive = true;
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

        public List<string> GetDistinctPlantTypes()
        {
            return _context.Vegetables
                .Where(v => v.IsActive)
                .Select(v => v.PlantType)
                .Distinct()
                .ToList();
        }

        public int GetTotalQuantityByPlantType(string plantType)
        {
            return _context.Vegetables
                .Where(v => v.PlantType == plantType && v.IsActive)
                .Sum(v => v.Quantity);
        }

        public int GetTotalQuantityByFormativeEnvironment(int formativeEnvironmentId)
        {
            return _context.Vegetables
                .Where(v => v.IsActive)
                .Sum(v => v.Quantity);
        }

        public List<VegetalModel> GetVegetalsWithLowQuantity(int threshold = 10)
        {
            return _context.Vegetables
                .Where(v => v.Quantity <= threshold && v.IsActive)
                .ToList();
        }

        public Dictionary<string, int> GetPlantTypeQuantitySummary()
        {
            return _context.Vegetables
                .Where(v => v.IsActive)
                .GroupBy(v => v.PlantType)
                .ToDictionary(g => g.Key, g => g.Sum(v => v.Quantity));
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
