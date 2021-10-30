using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models
{
    public class detalleCompra
    {


        [Key]
        public int id { get; set; }


        //cantidad de caracteres
        [Required(ErrorMessage = "El campo cantidad es obligatorio")]
        [MaxLength(5, ErrorMessage = "El campo cantidad sobrepasa el maximo de caracteres permitidos.")]
        public int cantidad { get; set; }


        //cantidad de caracteres
        [Required(ErrorMessage = "El campo precio es obligatorio")]
        [MaxLength(8, ErrorMessage = "El campo precio sobrepasa el maximo de caracteres permitidos.")]
        public decimal precio { get; set; }


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


        [Required(ErrorMessage = "El campo producto_id es obligatorio")]
        [ForeignKey("producto")]
        public int producto_id { get; set; }
        public producto producto { get; set; }



        [Required(ErrorMessage = "El campo compra_id es obligatorio")]
        [ForeignKey("compra")]
        public int compra_id { get; set; }
        public compra compra { get; set; }


    }
}
