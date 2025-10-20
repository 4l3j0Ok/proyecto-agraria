using GestionAgraria.data;
using GestionAgraria.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
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

        public List<FormativeEnvironmentModel> GetFormativeEnvironments(int estado,string? area = null,string? searchText = null)
        {
            var query = _context.FormativeEnvironments
                .Include(fe => fe.Responsible)
                .Include(fe => fe.AcademicData.Where(ad => ad.IsActive))
                .AsQueryable();

            // 📌 Filtro por estado
            if (estado == 0) // activos
                query = query.Where(fe => fe.IsActive);
            else if (estado == 1) // inactivos
                query = query.Where(fe => !fe.IsActive);
            // estado == 2 → todos

            // 📌 Filtro por área
            if (!string.IsNullOrEmpty(area))
                query = query.Where(fe => fe.Area == area);

            // 📌 Filtro por texto (responsable o nombre de entorno)
            if (!string.IsNullOrEmpty(searchText))
            {
                string lowerText = searchText.ToLower();
                query = query.Where(fe =>
                    fe.Name.ToLower().Contains(lowerText) || // nombre de entorno
                    fe.Responsible.Name.ToLower().Contains(lowerText) // responsable
                );
            }

            return query.ToList();
        }
        public List<FormativeEnvironmentModel> GetAllFormativeEnvironmentsActive()
        {
            return _context.FormativeEnvironments
                .Include(fe => fe.Responsible)
                .Include(fe => fe.AcademicData.Where(ad => ad.IsActive))
                .Where(fe => fe.IsActive)
            .ToList();
        }
        public List<FormativeEnvironmentModel> GetAllFormativeEnvironmentsInactive()
        {
            return _context.FormativeEnvironments
                .Include(fe => fe.Responsible)
                .Include(fe => fe.AcademicData.Where(ad => ad.IsActive))
                .Where(fe => !fe.IsActive)
            .ToList();
        }
        public List<FormativeEnvironmentModel> GetAllFormativeEnvironments()
        {
            return _context.FormativeEnvironments
                .Include(fe => fe.Responsible)
                .Include(fe => fe.AcademicData.Where(ad => ad.IsActive))
                .ToList();
        }

        public FormativeEnvironmentModel? GetFormativeEnvironmentById(int id)
        {
            return _context.FormativeEnvironments
                .Include(fe => fe.Responsible)
                .Include(fe => fe.AcademicData.Where(ad => ad.IsActive))
                .FirstOrDefault(fe => fe.Id == id);
        }

        public List<FormativeEnvironmentModel> GetFormativeEnvironmentsByResponsible(int responsibleUserId)
        {
            return _context.FormativeEnvironments
                .Include(fe => fe.Responsible)
                .Include(fe => fe.AcademicData.Where(ad => ad.IsActive))
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

                // Si hay datos académicos, agregarlos
                if (formativeEnvironment.AcademicData != null && formativeEnvironment.AcademicData.Any())
                {
                    foreach (var academicData in formativeEnvironment.AcademicData)
                    {
                        academicData.FormativeEnvironmentId = formativeEnvironment.Id;
                        academicData.FormativeEnvironment = null;
                    }
                    _context.FormativeEnvironmentData.AddRange(formativeEnvironment.AcademicData);
                    _context.SaveChanges();
                }

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
                var existingEnvironment = _context.FormativeEnvironments
                    .Include(fe => fe.AcademicData)
                    .FirstOrDefault(fe => fe.Id == formativeEnvironment.Id);
                
                if (existingEnvironment == null)
                    return false;

                // Validar que el responsable exista
                if (!_context.Users.Any(u => u.Id == formativeEnvironment.ResponsibleUserId && u.IsActive))
                    return false;

                // Validar que no exista un entorno con el mismo nombre (excepto el actual)
                if (_context.FormativeEnvironments.Any(fe =>
                    fe.Name == formativeEnvironment.Name &&
                    fe.Area == formativeEnvironment.Area &&
                    fe.Id != formativeEnvironment.Id &&
                    fe.IsActive))
                    return false;

                // Actualizar propiedades básicas
                existingEnvironment.Name = formativeEnvironment.Name;
                existingEnvironment.Area = formativeEnvironment.Area;
                existingEnvironment.ResponsibleUserId = formativeEnvironment.ResponsibleUserId;
                existingEnvironment.Observations = formativeEnvironment.Observations;
                existingEnvironment.IsActive = formativeEnvironment.IsActive;

                // Actualizar datos académicos
                // Primero marcar como inactivos los existentes
                foreach (var existing in existingEnvironment.AcademicData)
                {
                    existing.IsActive = false;
                }

                // Agregar los nuevos datos académicos
                if (formativeEnvironment.AcademicData != null && formativeEnvironment.AcademicData.Any())
                {
                    foreach (var academicData in formativeEnvironment.AcademicData)
                    {
                        if (academicData.Id == 0) // Nuevo registro
                        {
                            academicData.FormativeEnvironmentId = formativeEnvironment.Id;
                            academicData.FormativeEnvironment = null;
                            _context.FormativeEnvironmentData.Add(academicData);
                        }
                        else // Actualizar existente
                        {
                            var existingData = existingEnvironment.AcademicData.FirstOrDefault(ad => ad.Id == academicData.Id);
                            if (existingData != null)
                            {
                                existingData.Year = academicData.Year;
                                existingData.Course = academicData.Course;
                                existingData.Group = academicData.Group;
                                existingData.IsActive = true;
                            }
                        }
                    }
                }

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
            var yearsFromAcademicData = _context.FormativeEnvironmentData
                .Where(fed => fed.IsActive && fed.FormativeEnvironment!.IsActive)
                .Select(fed => fed.Year)
                .Distinct();

            var yearsFromFormativeEnvironments = _context.FormativeEnvironments
                .Where(fe => fe.IsActive)
#pragma warning disable CS0618 // Type or member is obsolete
                .Select(fe => fe.Year)
#pragma warning restore CS0618 // Type or member is obsolete
                .Distinct();

            return yearsFromAcademicData
                .Union(yearsFromFormativeEnvironments)
                .OrderByDescending(y => y)
                .ToList();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
