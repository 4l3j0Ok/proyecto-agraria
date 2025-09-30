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
    public class SellDetailController : IDisposable
    {
        private readonly AppDbContext _context;
        public SellDetailController()
        {
            _context = new AppDbContext();
        }

        public SellDetailController(AppDbContext context)
        {
            _context = context;
        }

        public List<SellDetailModel> GetAllDetail()
        {
            return _context.SellDetail
                .Include(a => a.Product)
                .Include(a => a.Sells)
                .Include(a => a.SellsId == a.Id)
                .ToList();
        }

        public bool CreateDetailSells(SellDetailModel detailSells)
        {
            try 
            {
                _context.SellDetail.Add(detailSells);
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)  
            {
                Debug.WriteLine(ex.InnerException?.Message ?? ex.Message);
                return false;
            }
        }
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
