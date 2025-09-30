using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAgraria.data;
using GestionAgraria.models;
using GestionAgraria.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionAgraria.Controllers
{
    public class SellController : IDisposable
    {
        public AppDbContext _context;

        public SellController()
        {
            _context = new AppDbContext();
        }

        public SellController(AppDbContext context)
        {
            _context = context;
        }

        public List<SellModel> GetAllSells() 
        { 
            return _context.Sells
                .Include(a => a.User)
                .ToList();        
        }

        public SellModel? getSellsById(int id)
        {
            return _context.Sells
                .Include (a => a.User)
                .FirstOrDefault(a => a.Id == id);
        }

        public SellModel? GetLastSell()
        {
                return _context.Sells
                    .Include(s => s.User)
                    .OrderByDescending(s => s.Id)
                    .FirstOrDefault();
        }

        public List<SellModel> GetSellsByUser(int userId)
        {
            return _context.Sells
                .Include (a => a.User)
                .ToList();
        }

        public bool CreateSells(SellModel sells)
        {
            SellModel se = new SellModel();
            se.RecordDate = DateTime.Today;
            se.TotalCost = sells.TotalCost;
            se.Observation = sells.Observation;
            se.UserId = sells.UserId;

            try
            {
                _context.Sells.Add(se);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException?.Message ?? ex.Message);
                return false;
            }
        }

        public bool UpdateSells(SellModel sells)
        {
            try
            {
                var existingSells = _context.Sells.Find(sells.Id);
                if (existingSells != null)
                {
                    return false;
                }

                existingSells.User = sells.User;
                existingSells.UserId = sells.UserId;
                existingSells.TotalCost = sells.TotalCost;
                existingSells.Observation = sells.Observation;

                _context.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<ProductModel> GetAllActiveProduct()
        {
            return _context.Product
                .Where(fe => fe.IsActive)
                .ToList();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
