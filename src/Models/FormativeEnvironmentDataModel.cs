using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionAgraria.models
{
    public class FormativeEnvironmentDataModel
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("FormativeEnvironment")]
        public int FormativeEnvironmentId { get; set; }

        public virtual FormativeEnvironmentModel? FormativeEnvironment { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Course { get; set; } = string.Empty;

        [Required]
        public string Group { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
