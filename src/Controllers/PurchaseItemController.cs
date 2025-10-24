using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAgraria.data;
using GestionAgraria.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionAgraria.Controllers
{
    public class PurchaseItemController : IDisposable
    {
        private readonly AppDbContext _context;

        public PurchaseItemController()
        {
            _context = new AppDbContext();
        }

        public PurchaseItemController(AppDbContext context)
        {
            _context = context;
        }

        public List<PurchaseItemModel> GetAllItems()
        {
            return _context.PurchaseItems
                .Include(i => i.Purchase)
                .ToList();
        }

        public List<PurchaseItemModel> GetItemsByPurchaseId(int purchaseId)
        {
            return _context.PurchaseItems
                .Where(i => i.PurchaseId == purchaseId)
                .ToList();
        }

        public bool CreateItem(PurchaseItemModel item)
        {
            try
            {
                _context.PurchaseItems.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException?.Message ?? ex.Message);
                return false;
            }
        }

        public bool DeleteItem(int itemId)
        {
            try
            {
                var item = _context.PurchaseItems.Find(itemId);
                if (item == null)
                    return false;

                _context.PurchaseItems.Remove(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
