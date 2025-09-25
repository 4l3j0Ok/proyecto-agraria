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
    public class BuysModel
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime RecordDate { get; set; }

        public decimal TotalCost { get; set; }

        public string? Observation { get; set; }

        [ForeignKey("User")]
        [Required]
        public int UserId { get; set; }
        public UserModel? User { get; set; } = null!;
    }
}
