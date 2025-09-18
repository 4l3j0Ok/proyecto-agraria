using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestionAgraria.models;

namespace GestionAgraria.Models
{
    public class VegetalModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PlantType { get; set; } = string.Empty;

        [Required]
        public int Quantity { get; set; }

        [ForeignKey("FormativeEnvironment")]
        public int FormativeEnvironmentId { get; set; }
        public FormativeEnvironmentModel FormativeEnvironment { get; set; } = null!;

        public string? Observations { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [ForeignKey("CreatedBy")]
        public int CreatedByUserId { get; set; }
        public UserModel CreatedBy { get; set; } = null!;

        public bool IsActive { get; set; } = true;
    }
}
