using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAgraria.data;
using GestionAgraria.models;
using GestionAgraria.Models;
using GestionAgraria.Core;
using Microsoft.EntityFrameworkCore;

namespace GestionAgraria.Controllers
{
    public class PurchaseController : IDisposable
    {
        private readonly AppDbContext _context;

        public PurchaseController()
        {
            _context = new AppDbContext();
        }

        public PurchaseController(AppDbContext context)
        {
            _context = context;
        }

        public List<PurchaseModel> GetAllPurchases()
        {
            return _context.Purchases
                .Include(p => p.User)
                .ToList();
        }

        public List<PurchaseModel> GetPurchasesForFiltro(
        string? usuario = null,
        string? searchText = null)
        {
            var query = _context.Purchases
                .Include(p => p.User) // Incluimos el usuario relacionado
                .AsQueryable();


            // Filtro por usuario
            if (!string.IsNullOrEmpty(usuario))
                query = query.Where(p => p.User.Name == usuario);

            //Filtro por búsqueda (ej: código de compra o algún campo relevante)
            if (!string.IsNullOrEmpty(searchText))
            {
                string lowerText = searchText.ToLower();
                query = query.Where(p =>
                    //p..ToLower().Contains(lowerText) ||   // suponiendo que tenés un campo Code
                    p.Observation.ToLower().Contains(lowerText) // o descripción/observaciones
                );
            }

            return query.ToList();
        }


        public PurchaseModel? GetPurchaseById(int id)
        {
            return _context.Purchases
                .Include(p => p.User)
                .FirstOrDefault(p => p.Id == id);
        }

        public int GetPurchasesCount()
        {
            return _context.Purchases.Count();
        }

        public PurchaseModel? GetLastPurchase()
        {
            return _context.Purchases
                .Include(p => p.User)
                .OrderByDescending(p => p.Id)
                .FirstOrDefault();
        }

        public bool CreatePurchase(PurchaseModel purchase)
        {
            try
            {
                PurchaseModel newPurchase = new PurchaseModel
                {
                    RecordDate = DateTime.Today,
                    TotalCost = purchase.TotalCost,
                    Observation = purchase.Observation,
                    UserId = purchase.UserId
                };

                _context.Purchases.Add(newPurchase);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException?.Message ?? ex.Message);
                return false;
            }
        }

        public bool UpdatePurchase(PurchaseModel purchase)
        {
            try
            {
                var existingPurchase = _context.Purchases.Find(purchase.Id);
                if (existingPurchase == null)
                    return false;

                existingPurchase.RecordDate = purchase.RecordDate;
                existingPurchase.TotalCost = purchase.TotalCost;
                existingPurchase.Observation = purchase.Observation;
                existingPurchase.UserId = purchase.UserId;

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public void PrintPurchaseReport(int purchaseId)
        {
            var purchase = GetPurchaseById(purchaseId);
            if (purchase != null)
            {
                var items = _context.PurchaseItems
                    .Where(i => i.PurchaseId == purchaseId)
                    .ToList();
                var printController = new PrintController();
                printController.PrintPurchase(purchase, items);
            }
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
