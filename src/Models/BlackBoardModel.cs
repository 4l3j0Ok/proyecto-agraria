using GestionAgraria.models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestionAgraria.Models
{
    public class BlackBoardModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string title { get; set; }

        public string entorno { get; set; }
        public string observaciones { get; set; }
        public int dateRecord {  get; set; }
        public string idTraining { get; set; }

    }
}
