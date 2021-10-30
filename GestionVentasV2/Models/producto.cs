using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models
{
    public class producto
    {
        [Key]
        public int id { get; set; }


        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [MaxLength(200, ErrorMessage = "El campo nombre sobrepasa el maximo de caracteres permitidos.")]
        public string nombre { get; set; }


        [Required(ErrorMessage = "El campo descripción es obligatorio")]
        [MaxLength(500, ErrorMessage = "El campo descripción sobrepasa el maximo de caracteres permitidos.")]
        public string descripcion { get; set; }

        [MaxLength(255, ErrorMessage = "El campo Path imagen producto sobrepasa el maximo de caracteres permitidos.")]
        public string pathImagen { get; set; }


        //[Required(ErrorMessage = "El campo usuario creacion es obligatorio")]
        [MaxLength(45, ErrorMessage = "El campo usuario creacion sobrepasa el maximo de caracteres permitidos.")]
        public string usuarioCreacion { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
       // [Required(ErrorMessage = "El campo fecha creacion es obligatorio")]
        public DateTime fechaCreacion { get; set; }


        [MaxLength(45, ErrorMessage = "El campo usuario actualización sobrepasa el maximo de caracteres permitidos.")]
        public string usuarioActualizacion { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fechaActualizacion { get; set; }


        [Required(ErrorMessage = "El campo establedimiento_id es obligatorio")]
        [ForeignKey("establecimiento")]
        public int establecimiento_id { get; set; }
        public establecimiento establecimiento { get; set; }


        [Required(ErrorMessage = "El campo tipoProducto_id es obligatorio")]
        [ForeignKey("tipoProducto")]
        public int tipoProducto_id { get; set; }
        public tipoProducto tipoProducto { get; set; }


        [Required(ErrorMessage = "El campo categoria_id es obligatorio")]
        [ForeignKey("categoria")]
        public int categoria_id { get; set; }
        public categoria categoria { get; set; }


        //[Required(ErrorMessage = "El campo estados_id es obligatorio")]
        [ForeignKey("estados")]
        public int? estados_id { get; set; }
        public estados estados { get; set; }

        public List<stock> stock { get; set; }
    }
}
