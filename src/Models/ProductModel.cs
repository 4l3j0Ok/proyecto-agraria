using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestionAgraria.models;
namespace GestionAgraria.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string code { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string? Observations { get; set; }

        [ForeignKey("FormativeEnvironment")]
        [Required]
        public int FormativeEnvironmentId { get; set; }
        public FormativeEnvironmentModel FormativeEnvironment { get; set; } = null!;
        public bool IsActive { get; set; } = true;
    }
}
