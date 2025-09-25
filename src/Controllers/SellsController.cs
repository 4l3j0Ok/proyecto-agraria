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
    public class SellsController : IDisposable
    {
        public AppDbContext _context;

        public SellsController()
        {
            _context = new AppDbContext();
        }

        public SellsController(AppDbContext context)
        {
            _context = context;
        }

        public List<SellsModel> GetAllSells() 
        { 
            return _context.Sells
                .Include(a => a.User)
                .ToList();        
        }

        public SellsModel? getSellsById(int id)
        {
            return _context.Sells
                .Include (a => a.User)
                .FirstOrDefault(a => a.Id == id);
        }

        public SellsModel? GetLastSell()
        {
            return _context.Sells
                .Include(a => a.User)
                .OrderByDescending(a => a.Id)
                .FirstOrDefault();
        }

        public List<SellsModel> GetSellsByUser(int userId)
        {
            return _context.Sells
                .Include (a => a.User)
                .ToList();
        }

        public bool CreateSells(SellsModel sells)
        {
            try
            {
                _context.Sells.Add(sells);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool UpdateSells(SellsModel sells)
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
