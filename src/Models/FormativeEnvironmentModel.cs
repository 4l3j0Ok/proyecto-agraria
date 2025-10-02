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

        // Datos académicos relacionados
        public virtual ICollection<FormativeEnvironmentDataModel> AcademicData { get; set; } = new List<FormativeEnvironmentDataModel>();

        // Mantener propiedades para compatibilidad con código existente (deprecated)
        [Obsolete("Use AcademicData collection instead")]
        public int Year { get; set; }

        [Obsolete("Use AcademicData collection instead")]
        public string Course { get; set; } = string.Empty;

        [Obsolete("Use AcademicData collection instead")]
        public string Group { get; set; } = string.Empty;

        public string? Observations { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
