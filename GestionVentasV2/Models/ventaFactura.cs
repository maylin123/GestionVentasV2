using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models
{
    public class ventaFactura
    {

        [Key]
        public int id { get; set; }


        [Required(ErrorMessage = "El campo Razon Social es obligatorio")]
        [MaxLength(150, ErrorMessage = "El campo Razon Social sobrepasa el maximo de caracteres permitidos.")]
        public string razonSocial { get; set; }


        [Required(ErrorMessage = "El campo Nit  es obligatorio")]
        [MaxLength(45, ErrorMessage = "El campo Nit sobrepasa el maximo de caracteres permitidos.")]
        public string nit { get; set; }

    
        [MaxLength(200, ErrorMessage = "El campo dirección sobrepasa el maximo de caracteres permitidos.")]
        public string direccion { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo fecha Emisión es obligatorio")]
        public DateTime fechaEmision { get; set; }


        [Required(ErrorMessage = "El campo cantidad es obligatorio")]
        [MaxLength(5, ErrorMessage = "El campo cantidad sobrepasa el maximo de caracteres permitidos.")]
        public int cantidad { get; set; }


        [Required(ErrorMessage = "El campo Total es obligatorio")]
        [MaxLength(5, ErrorMessage = "El campo Total sobrepasa el maximo de caracteres permitidos.")]
        public decimal total { get; set; }


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


    }
}
