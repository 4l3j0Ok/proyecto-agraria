using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionAgraria.Models
{
    public class PurchaseItemModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Cost { get; set; }

        [ForeignKey("Purchase")]
        [Required]
        public int PurchaseId { get; set; }
        public PurchaseModel Purchase { get; set; } = null!;
    }
}
