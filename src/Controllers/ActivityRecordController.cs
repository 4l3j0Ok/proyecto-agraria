using System;
using System.Collections.Generic;
using GestionAgraria.data;
using GestionAgraria.models;
using GestionAgraria.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace GestionAgraria.Controllers
{
    public class ActivityRecordController
    {
        private readonly AppDbContext _context;

        public ActivityRecordController()
        {
            _context = new AppDbContext();
        }

        public ActivityRecordController(AppDbContext context)
        {
            _context = context;
        }

        // 📌 Obtener todas las actividades activas
        public List<ActivityRecordModel> GetAllActivities()
        {
            return _context.ActivityRecords
                .Include(a => a.FormativeEnvironment)
                .Include(a => a.User)
                .Where(a => a.IsActive)
                .ToList();
        }

        // 📌 Obtener actividades filtradas con paginación
        public List<ActivityRecordModel> GetActivitiesForFiltro(
    int estado,
    string? entorno = null,
    string? searchText = null,
    string? stateActivity = null,
    string? usuario = null,   // ✅ Nuevo parámetro
    int page = 1,
    int pageSize = 20)
        {
            var query = _context.ActivityRecords
                .Include(a => a.FormativeEnvironment)
                .Include(a => a.User)
                .AsQueryable();

            // Filtro por estado (Activo/Inactivo)
            if (estado == 0)
                query = query.Where(a => a.IsActive);
            else if (estado == 1)
                query = query.Where(a => !a.IsActive);

            // Filtro por entorno
            if (!string.IsNullOrEmpty(entorno))
                query = query.Where(a => a.FormativeEnvironment.Name == entorno);

            // Filtro por estado de actividad
            if (!string.IsNullOrEmpty(stateActivity))
                query = query.Where(a => a.StateActivity == stateActivity);

            // ✅ Filtro por usuario (puede ser por nombre o por ID)
            if (!string.IsNullOrEmpty(usuario))
                query = query.Where(a => a.User != null && a.User.Username == usuario);

            // Filtro por texto (título u observaciones)
            if (!string.IsNullOrEmpty(searchText))
            {
                string lowerText = searchText.ToLower();
                query = query.Where(a =>
                    a.Titulo.ToLower().Contains(lowerText) ||
                    (a.Observations != null && a.Observations.ToLower().Contains(lowerText)) ||
                    a.StateActivity.ToLower().Contains(lowerText)
                );
            }

            // Paginación
            return query
                .OrderByDescending(a => a.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        // 📌 Obtener el total para paginación
        public int GetActivitiesCountForFilter(
     int estado,
     string? entorno = null,
     string? searchText = null,
     string? stateActivity = null,
     string? usuario = null)   // ✅ Nuevo parámetro
        {
            var query = _context.ActivityRecords.AsQueryable();

            if (estado == 0) query = query.Where(a => a.IsActive);
            else if (estado == 1) query = query.Where(a => !a.IsActive);

            if (!string.IsNullOrEmpty(entorno))
                query = query.Where(a => a.FormativeEnvironment.Name == entorno);

            if (!string.IsNullOrEmpty(stateActivity))
                query = query.Where(a => a.StateActivity == stateActivity);

            // ✅ Filtro por usuario
            if (!string.IsNullOrEmpty(usuario))
                query = query.Where(a => a.User != null && a.User.Username == usuario);

            if (!string.IsNullOrEmpty(searchText))
            {
                string lowerText = searchText.ToLower();
                query = query.Where(a =>
                    a.Titulo.ToLower().Contains(lowerText) ||
                    (a.Observations != null && a.Observations.ToLower().Contains(lowerText)) ||
                    a.StateActivity.ToLower().Contains(lowerText)
                );
            }

            return query.Count();
        }
        public List<FormativeEnvironmentModel> GetAllActiveFormativeEnvironments()
        {
            return _context.FormativeEnvironments
                .Where(fe => fe.IsActive)
                .ToList();
        }


        // 📌 Crear nueva actividad
        public bool CreateActivity(ActivityRecordModel activity)
        {
            try
            {
                _context.ActivityRecords.Add(activity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("❌ Error al guardar actividad: " + ex.Message);

                if (ex.InnerException != null)
                    Debug.WriteLine("➡ InnerException: " + ex.InnerException.Message);

                return false;
            }
        }


        // 📌 Actualizar actividad existente
        public bool UpdateActivity(ActivityRecordModel activity)
        {
            try
            {
                var existingActivity = _context.ActivityRecords.Find(activity.Id);
                if (existingActivity == null)
                    return false;

                existingActivity.Titulo = activity.Titulo;
                existingActivity.FormativeEnvironmentId = activity.FormativeEnvironmentId;
                existingActivity.UserId = activity.UserId;
                existingActivity.StateActivity = activity.StateActivity;
                existingActivity.Observations = activity.Observations;
                existingActivity.IsActive = activity.IsActive;

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        // 📌 Desactivar actividad
        public bool DeactivateActivity(int id)
        {
            try
            {
                var activity = _context.ActivityRecords.Find(id);
                if (activity == null) return false;

                activity.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // 📌 Activar actividad
        public bool ActivateActivity(int id)
        {
            try
            {
                var activity = _context.ActivityRecords.Find(id);
                if (activity == null) return false;

                activity.IsActive = true;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
