using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestionAgraria.models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GestionAgraria.Models
{
    public class PurchaseDetailModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Quatity { get; set; }

        [Required]
        public decimal PriceUnit { get; set; }

        [ForeignKey("Product")]
        [Required]
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }

        [ForeignKey("Purchases")]
        [Required]
        public int PurchasesId { get; set; }
        public PurchaseModel Purchases { get; set; }
    }
}
