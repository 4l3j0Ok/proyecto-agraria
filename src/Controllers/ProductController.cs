using GestionAgraria.data;
using GestionAgraria.models;
using GestionAgraria.Models;
using GestionAgraria.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAgraria.Controllers
{
    public class ProductController : IDisposable
    {
        private readonly AppDbContext _context;

        public ProductController()
        {
            _context = new AppDbContext();
        }

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public bool CreateProduct(ProductModel product)
        {
            try
            {
                // Validar que no exista el codigo:
                if (_context.Product.Any(a => a.Id == product.Id))
                    return false;
                _context.Product.Add(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool UpdateProduct(ProductModel product)
        {
            try
            {
                var existingProduct = _context.Product.Find(product.Id);
                if (existingProduct == null)
                    return false;

                // Validar que el código no exista (excepto el animal actual)
                if (_context.Product.Any(a => a.Code == product.Code && a.Id != product.Id))
                    return false;

                // Actualizar propiedades
                existingProduct.Id = product.Id;
                existingProduct.Code = product.Code;
                existingProduct.Name = product.Name;
                existingProduct.Stock = product.Stock;
                existingProduct.Description = product.Description;
                existingProduct.IsActive = product.IsActive;

                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool DeactivateProduct(int productId)
        {
            try
            {
                var product = _context.Product.Find(productId);
                if (product == null)
                    return false;

                product.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ProductModel> GetAllProduct()
        {
            return _context.Product
                .Where(a => a.IsActive)
                .ToList();
        }
        public ProductModel? GetProductById(int id)
        {
            return _context.Product
                .Include(a => a.Name)
                .FirstOrDefault(a => a.Id == id);
        }

        public ProductModel? GetProductByCode(string code)
        {
            return _context.Product
                .FirstOrDefault(a => a.Code == code && a.IsActive);
        }

        public List<ProductModel> GetProductsForFiltro(int estado, string? entorno = null, string? searchText = null, int page = 1, int pageSize = 20)
        {
            var query = _context.Product
                .AsQueryable();

            // 📌 Filtro por estado
            if (estado == 0) // Activos
                query = query.Where(p => p.IsActive);
            else if (estado == 1) // Inactivos
                query = query.Where(p => !p.IsActive);
            // estado == 2 → Todos (sin filtro)

            // 📌 Filtro por búsqueda (code o name)
            if (!string.IsNullOrEmpty(searchText))
            {
                string lowerText = searchText.ToLower();
                query = query.Where(p =>
                    p.Code.ToLower().Contains(lowerText) ||
                    p.Name.ToLower().Contains(lowerText)
                );
            }

            // 📌 Pagination
            return query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public int GetProductsCountForFilter(int estado, string? entorno = null, string? searchText = null)
        {
            var query = _context.Product.AsQueryable();

            // 📌 Filtro por estado
            if (estado == 0) // Activos
                query = query.Where(p => p.IsActive);
            else if (estado == 1) // Inactivos
                query = query.Where(p => !p.IsActive);

            // 📌 Filtro por búsqueda
            if (!string.IsNullOrEmpty(searchText))
            {
                string lowerText = searchText.ToLower();
                query = query.Where(p =>
                    p.Code.ToLower().Contains(lowerText) ||
                    p.Name.ToLower().Contains(lowerText)
                );
            }

            return query.Count();
        }

        public List<FormativeEnvironmentModel> GetAllActiveFormativeEnvironments()
        {
            return _context.FormativeEnvironments
                .Where(fe => fe.IsActive)
                .ToList();
        }

        public void PrintProductReport(int productId)
        {
            var product = GetProductById(productId);
            if (product != null)
            {
                var printController = new PrintController();
                printController.PrintProduct(product);
            }
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
