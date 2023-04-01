using System.ComponentModel.DataAnnotations;
namespace PracticaMVC.Models
{
    public class equipos
    {
        [Key]

        [Display(Name = "ID_equipo")]
        public int id_equipos { get; set; }

        [Display(Name = "nombre")]
        public string nombre { get; set; }

        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }

        [Display(Name = "Tipo_equipo")]
        public int tipo_equipo_id { get; set; }

        [Display(Name = "ID_marca")]
        public int marca_id { get; set; }

        [Display(Name = "Modelo")]
        public string modelo { get; set; }

        //[Display(Name = "anio_compra")]
        public int anio_compra { get; set; }
        public decimal costo { get; set; }
        public int? vida_util { get; set; }

        [Display(Name = "ID_estado_equipo")]
        public int? estado_equipo_id { get; set; }
        public string estado { get; set; }
    }
}
