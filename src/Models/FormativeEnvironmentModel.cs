using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionAgraria.models
{
    public class FormativeEnvironmentModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Area { get; set; } = string.Empty;

        [ForeignKey("Responsible")]
        public int ResponsibleUserId { get; set; }

        public virtual UserModel? Responsible { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Course { get; set; } = string.Empty;

        [Required]
        public string Group { get; set; } = string.Empty;

        public string? Observations { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
