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

        public List<BlackBoardModel> GetAllBlackBoards()
        {
            return _context.BlackBoards
                .ToList();
        }

        public BlackBoardModel? GetBlackBoardById(int id)
        {
            return _context.BlackBoards
                .FirstOrDefault(bb => bb.Id == id);
        }

        public List<BlackBoardModel> GetBlackBoardsByEntorno(string entorno)
        {
            return _context.BlackBoards
                .Where(bb => bb.entorno == entorno)
                .ToList();
        }

        public List<BlackBoardModel> GetBlackBoardsByDateRecord(int dateRecord)
        {
            return _context.BlackBoards
                .Where(bb => bb.dateRecord == dateRecord)
                .ToList();
        }

        public List<BlackBoardModel> GetBlackBoardsByTraining(string idTraining)
        {
            return _context.BlackBoards
                .Where(bb => bb.idTraining == idTraining)
                .ToList();
        }

        public bool CreateBlackBoard(BlackBoardModel blackBoard)
        {
            try
            {
                // Validar que no exista una pizarra con el mismo título
                if (_context.BlackBoards.Any(bb => bb.title == blackBoard.title))
                    return false;

                _context.BlackBoards.Add(blackBoard);
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
                var existingBlackBoard = _context.BlackBoards.Find(blackBoard.Id);
                if (existingBlackBoard == null)
                    return false;

                // Validar que no exista una pizarra con el mismo título (excepto la actual)
                if (_context.BlackBoards.Any(bb =>
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
                var blackBoard = _context.BlackBoards.Find(blackBoardId);
                if (blackBoard == null)
                    return false;

                _context.BlackBoards.Remove(blackBoard);
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
            return _context.BlackBoards
                .Select(bb => bb.entorno)
                .Where(e => !string.IsNullOrEmpty(e))
                .Distinct()
                .ToList();
        }

        public List<int> GetDistinctDateRecords()
        {
            return _context.BlackBoards
                .Select(bb => bb.dateRecord)
                .Distinct()
                .OrderByDescending(d => d)
                .ToList();
        }

        public List<string> GetDistinctTrainings()
        {
            return _context.BlackBoards
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
