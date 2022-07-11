using System.ComponentModel.DataAnnotations;
namespace CG_P.Models
{
    public class Edificio
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Nombre")]
        public string nombre { get; set; } = string.Empty;
        [Display(Name = "Capacidad")]
        public int cantidad_personas { get; set; }
        [Display(Name = "Fecha de alquiler")]

        [DataType(DataType.Date)]
        public DateTime fecha_alquiler { get; set; }
        [Display(Name = "Provincia")]
        public int id_provincia { get; set; }
        [Display(Name = "Cantón")]
        public int id_canton { get; set; }
        [Display(Name = "Distrito")]
        public int id_destrito { get; set; }
        [Display(Name = "Tipo")]

        public int tipo_edificio { get; set; }
        [Display(Name = "Fecha Final")]
        [DataType(DataType.Date)]
        public DateTime fecha_final_alquiler { get; set; }
    }
}
