using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestionAgraria.models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GestionAgraria.Models
{
    public class AnimalModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; } = string.Empty;

        [ForeignKey("AnimalType")]
        [Required]
        public int AnimalTypeId { get; set; }
        public AnimalTypeModel AnimalType { get; set; } = null!;

        [ForeignKey("FormativeEnvironment")]
        [Required]
        public int FormativeEnvironmentId { get; set; }
        public FormativeEnvironmentModel FormativeEnvironment { get; set; } = null!;

        [Required]
        public DateTime BirthOrEntryDate { get; set; }
        public string Sex { get; set; } = string.Empty;

        [Required]
        public string ProductiveState { get; set; } = string.Empty;
        public string? Observations { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
