using GestionAgraria.data;
using GestionAgraria.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAgraria.controllers
{
    public class FormativeEnvironmentController : IDisposable
    {
        private readonly AppDbContext _context;

        public FormativeEnvironmentController()
        {
            _context = new AppDbContext();
        }

        public FormativeEnvironmentController(AppDbContext context)
        {
            _context = context;
        }

        public List<FormativeEnvironmentModel> GetAllFormativeEnvironments()
        {
            return _context.FormativeEnvironments
                .Include(fe => fe.Responsible)
                .Where(fe => fe.IsActive)
                .ToList();
        }

        public FormativeEnvironmentModel? GetFormativeEnvironmentById(int id)
        {
            return _context.FormativeEnvironments
                .Include(fe => fe.Responsible)
                .FirstOrDefault(fe => fe.Id == id);
        }

        public List<FormativeEnvironmentModel> GetFormativeEnvironmentsByResponsible(int responsibleUserId)
        {
            return _context.FormativeEnvironments
                .Include(fe => fe.Responsible)
                .Where(fe => fe.ResponsibleUserId == responsibleUserId && fe.IsActive)
                .ToList();
        }

        public List<FormativeEnvironmentModel> GetFormativeEnvironmentsByYear(int year)
        {
            return _context.FormativeEnvironments
                .Include(fe => fe.Responsible)
                .Where(fe => fe.Year == year && fe.IsActive)
                .ToList();
        }

        public bool CreateFormativeEnvironment(FormativeEnvironmentModel formativeEnvironment)
        {
            try
            {
                // Validar que el responsable exista
                if (!_context.Users.Any(u => u.Id == formativeEnvironment.ResponsibleUserId && u.IsActive))
                    return false;

                // Validar que no exista un entorno con el mismo nombre
                if (_context.FormativeEnvironments.Any(fe =>
                    fe.Name == formativeEnvironment.Name &&
                    fe.IsActive))
                    return false;

              
                formativeEnvironment.Responsible = null;

                _context.FormativeEnvironments.Add(formativeEnvironment);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        public bool UpdateFormativeEnvironment(FormativeEnvironmentModel formativeEnvironment)
        {
            try
            {
                var existingEnvironment = _context.FormativeEnvironments.Find(formativeEnvironment.Id);
                if (existingEnvironment == null)
                    return false;

                // Validar que el responsable exista
                if (!_context.Users.Any(u => u.Id == formativeEnvironment.ResponsibleUserId && u.IsActive))
                    return false;

                // Validar que no exista un entorno con el mismo nombre, área y año (excepto el actual)
                if (_context.FormativeEnvironments.Any(fe =>
                    fe.Name == formativeEnvironment.Name &&
                    fe.Area == formativeEnvironment.Area &&
                    fe.Year == formativeEnvironment.Year &&
                    fe.Id != formativeEnvironment.Id &&
                    fe.IsActive))
                    return false;

                // Actualizar propiedades
                existingEnvironment.Name = formativeEnvironment.Name;
                existingEnvironment.Area = formativeEnvironment.Area;
                existingEnvironment.ResponsibleUserId = formativeEnvironment.ResponsibleUserId;
                existingEnvironment.Year = formativeEnvironment.Year;
                existingEnvironment.Course = formativeEnvironment.Course;
                existingEnvironment.Group = formativeEnvironment.Group;
                existingEnvironment.Observations = formativeEnvironment.Observations;
                existingEnvironment.IsActive = formativeEnvironment.IsActive;

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        public bool DeactivateFormativeEnvironment(int environmentId)
        {
            try
            {
                var environment = _context.FormativeEnvironments.Find(environmentId);
                if (environment == null)
                    return false;

                environment.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        public bool ActivateFormativeEnvironment(int environmentId)
        {
            try
            {
                var environment = _context.FormativeEnvironments.Find(environmentId);
                if (environment == null)
                    return false;

                environment.IsActive = true;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        public List<UserModel> GetAllActiveUsers()
        {
            return _context.Users
                .Include(u => u.Role)
                .Where(u => u.IsActive)
                .ToList();
        }

        public List<string> GetDistinctAreas()
        {
            return _context.FormativeEnvironments
                .Where(fe => fe.IsActive)
                .Select(fe => fe.Area)
                .Distinct()
                .ToList();
        }

        public List<int> GetDistinctYears()
        {
            return _context.FormativeEnvironments
                .Where(fe => fe.IsActive)
                .Select(fe => fe.Year)
                .Distinct()
                .OrderByDescending(y => y)
                .ToList();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
