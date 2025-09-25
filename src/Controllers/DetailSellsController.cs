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
    public class DetailSellsController : IDisposable
    {
        private readonly AppDbContext _context;
        public DetailSellsController()
        {
            _context = new AppDbContext();
        }

        public DetailSellsController(AppDbContext context)
        {
            _context = context;
        }

        public List<DetailSellsModel> GetAllDetail()
        {
            return _context.DetailSells
                .Include(a => a.Product)
                .Include(a => a.Sells)
                .Include(a => a.SellsId == a.Id)
                .ToList();
        }

        public bool CreateDetailSells(DetailSellsModel detailSells)
        {
            try 
            {
                _context.DetailSells.Add(detailSells);
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)  
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
