using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CG_P.Models
{
    public class Servicio
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string nombre { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        [Display(Name = "Empresa")]

        public string nombre_empresa { get; set; } = string.Empty;
        [Display(Name = "Tipo de servicio")]
        public int tipo_servicio_id { get; set; }
        [Display(Name = "Unidad de medida")]
        public int unidad_medida_id { get; set; }

    }
}
