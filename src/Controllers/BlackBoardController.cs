using GestionAgraria.data;
using GestionAgraria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAgraria.controllers
{
    public class BlackBoardController : IDisposable
    {
        private readonly AppDbContext _context;

        public BlackBoardController()
        {
            _context = new AppDbContext();
        }

        public BlackBoardController(AppDbContext context)
        {
            _context = context;
        }

        public List<BlackBoardModel> GetAllBlackBoards(int page = 1, int pageSize = 20)
        {
            return _context.BlackBoard
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public int GetBlackBoardsCount()
        {
            return _context.BlackBoard.Count();
        }

        public BlackBoardModel? GetBlackBoardById(int id)
        {
            return _context.BlackBoard
                .FirstOrDefault(bb => bb.Id == id);
        }

        public List<BlackBoardModel> GetBlackBoardByEntorno(string entorno)
        {
            return _context.BlackBoard
                .Where(bb => bb.entorno == entorno)
                .ToList();
        }

        public List<BlackBoardModel> GetBlackBoardByDateRecord(int dateRecord)
        {
            return _context.BlackBoard
                .Where(bb => bb.dateRecord == dateRecord)
                .ToList();
        }

        public List<BlackBoardModel> GetBlackBoardByTraining(string idTraining)
        {
            return _context.BlackBoard
                .Where(bb => bb.idTraining == idTraining)
                .ToList();
        }

        public bool CreateBlackBoard(BlackBoardModel blackBoard)
        {
            try
            {
                // Validar que no exista una pizarra con el mismo título
                if (_context.BlackBoard.Any(bb => bb.title == blackBoard.title))
                    return false;

                _context.BlackBoard.Add(blackBoard);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        public bool UpdateBlackBoard(BlackBoardModel blackBoard)
        {
            try
            {
                var existingBlackBoard = _context.BlackBoard.Find(blackBoard.Id);
                if (existingBlackBoard == null)
                    return false;

                // Validar que no exista una pizarra con el mismo título (excepto la actual)
                if (_context.BlackBoard.Any(bb =>
                    bb.title == blackBoard.title &&
                    bb.Id != blackBoard.Id))
                    return false;

                // Actualizar propiedades
                existingBlackBoard.title = blackBoard.title;
                existingBlackBoard.entorno = blackBoard.entorno;
                existingBlackBoard.observaciones = blackBoard.observaciones;
                existingBlackBoard.dateRecord = blackBoard.dateRecord;
                existingBlackBoard.idTraining = blackBoard.idTraining;

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        public bool DeleteBlackBoard(int blackBoardId)
        {
            try
            {
                var blackBoard = _context.BlackBoard.Find(blackBoardId);
                if (blackBoard == null)
                    return false;

                _context.BlackBoard.Remove(blackBoard);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        public List<string> GetDistinctEntornos()
        {
            return _context.BlackBoard
                .Select(bb => bb.entorno)
                .Where(e => !string.IsNullOrEmpty(e))
                .Distinct()
                .ToList();
        }

        public List<int> GetDistinctDateRecords()
        {
            return _context.BlackBoard
                .Select(bb => bb.dateRecord)
                .Distinct()
                .OrderByDescending(d => d)
                .ToList();
        }

        public List<string> GetDistinctTrainings()
        {
            return _context.BlackBoard
                .Select(bb => bb.idTraining)
                .Where(t => !string.IsNullOrEmpty(t))
                .Distinct()
                .ToList();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
