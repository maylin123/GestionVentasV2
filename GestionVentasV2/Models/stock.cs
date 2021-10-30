using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models
{
    public class stock
    {

        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El campo Cantidad es obligatorio")]
        [MaxLength(5, ErrorMessage = "El campo Cantidad sobrepasa el maximo de caracteres permitidos.")]
        public int cantidad { get; set; }


        [Required(ErrorMessage = "El campo precioVenta es obligatorio")]
        [MaxLength(5, ErrorMessage = "El campo precioVenta sobrepasa el maximo de caracteres permitidos.")]
        public decimal precioVenta { get; set; }



        [Required(ErrorMessage = "El campo usuario creacion es obligatorio")]
        [MaxLength(45, ErrorMessage = "El campo usuario creacion sobrepasa el maximo de caracteres permitidos.")]
        public string usuarioCreacion { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo fecha creacion es obligatorio")]
        public DateTime fechaCreacion { get; set; }


        [MaxLength(45, ErrorMessage = "El campo usuario actualización sobrepasa el maximo de caracteres permitidos.")]
        public string usuarioActualizacion { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fechaActualizacion { get; set; }


        [Required(ErrorMessage = "El campo estados_id es obligatorio")]
        [ForeignKey("estados")]
        public int estados_id { get; set; }
        public estados estados { get; set; }


        //[Required(ErrorMessage = "El campo detalleVenta_id es obligatorio")]
        [ForeignKey("detalleVenta")]
        public int? detalleVenta_id { get; set; }
        public detalleVenta detalleVenta { get; set; }


        //Agregar detalle compra
        //[Required(ErrorMessage = "El campo detalleCompra_id es obligatorio")]
        [ForeignKey("detalleCompra")]
        public int? detalleCompra_id { get; set; }
        public  detalleCompra detalleCompra { get; set; }


        //[Required(ErrorMessage = "El campo detalleCompra_id es obligatorio")]
        [ForeignKey("producto")]
        public int producto_id { get; set; }
        public producto producto { get; set; }

        
        [MaxLength(6, ErrorMessage = "El campo Cantidad entrada sobrepasa el maximo de caracteres permitidos.")]
        public int cantidadEntrada { get; set; }

        //[Required(ErrorMessage = "El campo Cantidad es obligatorio")]
        [MaxLength(6, ErrorMessage = "El campo Cantidad  salida sobrepasa el maximo de caracteres permitidos.")]
        public int cantidadSalida { get; set; }

    }
}
