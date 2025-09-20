using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestionAgraria.models;

namespace GestionAgraria.Models
{
    public class AnimalModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; } = string.Empty;

        [Required]
        public string AnimalType { get; set; } = string.Empty;

        [Required]
        public DateTime BirthOrEntryDate { get; set; }

        [Required]
        public string Sex { get; set; } = string.Empty;

        [Required]
        public string ProductiveState { get; set; } = string.Empty;
        public string? Observations { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
