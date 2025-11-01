using System.ComponentModel.DataAnnotations;


namespace GestionAgraria.models
{
    public enum AccessLevel
    {
        None = 'N',
        Read = 'R',
        Write = 'W',
        Admin = 'A'
    }
    public class RoleModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int Level { get; set; }

        [Required]
        public AccessLevel AnimalsAccess { get; set; } = AccessLevel.None;
        [Required]
        public AccessLevel VegetablesAccess { get; set; } = AccessLevel.None;
        [Required]
        public AccessLevel IndustriesAccess { get; set; } = AccessLevel.None;
        [Required]
        public AccessLevel UsersAccess { get; set; } = AccessLevel.None;
        [Required]
        public AccessLevel ActivitiesAccess { get; set; } = AccessLevel.None;
        [Required]
        public AccessLevel FormativeEnvironmentsAccess { get; set; } = AccessLevel.None;
    }
}
