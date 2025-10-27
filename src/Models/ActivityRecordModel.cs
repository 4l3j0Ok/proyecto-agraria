using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAgraria.models;

namespace GestionAgraria.Models
{
    public class ActivityRecordModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; } = string.Empty;

        [ForeignKey("FormativeEnvironment")]
        [Required]
        public int FormativeEnvironmentId { get; set; }
        public FormativeEnvironmentModel FormativeEnvironment { get; set; } = null!;

        [ForeignKey("User")]
        [Required]
        public int UserId { get; set; }
        public UserModel User { get; set; } = null!;
        public string StateActivity { get; set; } = string.Empty;
        public DateTime RecordDate { get; set; }
        public string? Observations { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
