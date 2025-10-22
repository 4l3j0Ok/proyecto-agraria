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
    public class VegetableController : IDisposable
    {
        private readonly AppDbContext _context;

        public VegetableController()
        {
            _context = new AppDbContext();
        }

        public VegetableController(AppDbContext context)
        {
            _context = context;
        }

        public List<VegetableModel> GetAllVegetables()
        {
            return _context.Vegetables
                .Include(v => v.FormativeEnvironment)
                .Where(v => v.IsActive)
                .ToList();
        }

        public List<VegetableModel> GetVegetablesForFiltro(int estado, string? entorno = null, string? searchText = null, int page = 1, int pageSize = 20)
        {
            var query = _context.Vegetables
        .Include(v => v.FormativeEnvironment) // ?? Incluimos el entorno
        .AsQueryable();

            // ?? Filtro por estado
            if (estado == 0) // Activos
                query = query.Where(v => v.IsActive);
            else if (estado == 1) // Inactivos
                query = query.Where(v => !v.IsActive);
            // estado == 2 ? Todos (sin filtro)

            // ?? Filtro por entorno
            if (!string.IsNullOrEmpty(entorno))
                query = query.Where(v => v.FormativeEnvironment.Name == entorno);

            // ?? Filtro por texto (ej: tipo de planta o descripción)
            if (!string.IsNullOrEmpty(searchText))
            {
                string lowerText = searchText.ToLower();
                query = query.Where(v =>
                    v.PlantType.ToLower().Contains(lowerText) ||
                    v.Observations.ToLower().Contains(lowerText)
                );
            }

            // ?? Pagination
            return query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public int GetVegetablesCountForFilter(int estado, string? entorno = null, string? searchText = null)
        {
            var query = _context.Vegetables.AsQueryable();

            // ?? Filtro por estado
            if (estado == 0) // Activos
                query = query.Where(v => v.IsActive);
            else if (estado == 1) // Inactivos
                query = query.Where(v => !v.IsActive);

            // ?? Filtro por entorno
            if (!string.IsNullOrEmpty(entorno))
                query = query.Where(v => v.FormativeEnvironment.Name == entorno);

            // ?? Filtro por texto
            if (!string.IsNullOrEmpty(searchText))
            {
                string lowerText = searchText.ToLower();
                query = query.Where(v =>
                    v.PlantType.ToLower().Contains(lowerText) ||
                    v.Observations.ToLower().Contains(lowerText)
                );
            }

            return query.Count();
        }

        public VegetableModel? GetVegetalById(int id)
        {
            return _context.Vegetables
                .FirstOrDefault(v => v.Id == id);
        }

        public List<VegetableModel> GetVegetalsByPlantType(string plantType)
        {
            return _context.Vegetables
                .Where(v => v.IsActive)
                .ToList();
        }

        public bool CreateVegetal(VegetableModel vegetal)
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

        public bool UpdateVegetal(VegetableModel vegetal)
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
                existingVegetal.FormativeEnvironmentId = vegetal.FormativeEnvironmentId;
                existingVegetal.FormativeEnvironment = vegetal.FormativeEnvironment;

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

        public List<VegetableModel> GetVegetalsWithLowQuantity(int threshold = 10)
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
