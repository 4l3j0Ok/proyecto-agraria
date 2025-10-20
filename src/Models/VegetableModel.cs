using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestionAgraria.models;

namespace GestionAgraria.Models
{
    public class VegetableModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PlantType { get; set; } = string.Empty;

        [ForeignKey("FormativeEnvironment")]
        [Required]
        public int FormativeEnvironmentId { get; set; }
        public FormativeEnvironmentModel FormativeEnvironment { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }

        public string? Observations { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
