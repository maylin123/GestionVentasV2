using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models
{
    public class detalleVenta
    {

        [Key]
        public int id { get; set; }


        [Required(ErrorMessage = "El campo precio venta es obligatorio")]
        [MaxLength(8, ErrorMessage = "El campo precio venta sobrepasa el maximo de caracteres permitidos.")]
        public decimal precioVenta { get; set; }


        [Required(ErrorMessage = "El campo porcentaje venta es obligatorio")]
        [MaxLength(2, ErrorMessage = "El campo porcentaje descuento sobrepasa el maximo de caracteres permitidos.")]
        public decimal porcentajeDescuento { get; set; }

        [Required(ErrorMessage = "El campo cantidad es obligatorio")]
        [MaxLength(8, ErrorMessage = "El campo cantidad sobrepasa el maximo de caracteres permitidos.")]
        public int cantidad { get; set; }

        [Required(ErrorMessage = "El campo usuario creacion es obligatorio")]
        [MaxLength(45, ErrorMessage = "El campo usuario creacion sobrepasa el maximo de caracteres permitidos.")]
        public string usuarioCreacion { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo fecha creacion es obligatorio")]
        public DateTime fechaCreacion { get; set; }


        [MaxLength(45, ErrorMessage = "El campo usuario creacion sobrepasa el maximo de caracteres permitidos.")]
        public string usuarioActualizacion { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fechaActualizacion { get; set; }


        [Required(ErrorMessage = "El campo estados_id es obligatorio")]
        [ForeignKey("estados")]
        public int estados_id { get; set; }
        public estados estados { get; set; }

        [Required(ErrorMessage = "El campo producto es obligatorio")]
        [ForeignKey("producto")]
        public int producto_id { get; set; }
        public producto producto { get; set; }

        [Required(ErrorMessage = "El campo venta_id es obligatorio")]
        [ForeignKey("venta")]
        public int venta_id { get; set; }
        public venta venta { get; set; }



    }
}
