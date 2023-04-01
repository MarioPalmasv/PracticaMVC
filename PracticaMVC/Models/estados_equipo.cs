using System.ComponentModel.DataAnnotations;
namespace PracticaMVC.Models
{
    
    public class estados_equipo
    {
        [Key]

        [Display(Name = "ID")]
        public int id_estados_equipo { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}
