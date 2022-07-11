using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CG_P.Models
{
    public class Agregar_servicio
    {
        [Key]
        public int id { get; set; }

        public int id_edificio { get; set; }
        public int id_servicio { get; set; }
        public DateTime fecha_servicio { get; set; }
    }
}
