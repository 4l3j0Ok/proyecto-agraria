using System.ComponentModel.DataAnnotations;


namespace GestionAgraria.models
{
    public class FormativeEnvironmentModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
