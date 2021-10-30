using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models
{
    public class compra
    {
        [Key]
        public int id { get; set; }


        [Required(ErrorMessage = "El campo No. Factura creacion es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo No. Factura sobrepasa el maximo de caracteres permitidos.")]
        public string noFactura { get; set; }



        [Required(ErrorMessage = "El campo Total Factura creacion es obligatorio")]
        //[MaxLength(8, ErrorMessage = "El campo Total Factura sobrepasa el maximo de caracteres permitidos.")]
        public decimal totalFactura { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "El campo fecha es obligatorio")]
        public DateTime fecha { get; set; }


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


        [Required(ErrorMessage = "El campo establecimiento_id es obligatorio")]
        [ForeignKey("establecimiento")]
        public int establecimiento_id { get; set; }
        public establecimiento establecimiento { get; set; }


        [Required(ErrorMessage = "El campo usuario_id es obligatorio")]
        [ForeignKey("usuario")]
        public int usuario_id { get; set; }
        public usuario usuario { get; set; }


        [Required(ErrorMessage = "El campo estados_id es obligatorio")]
        [ForeignKey("estados")]
        public int estados_id { get; set; }
        public estados estados { get; set; }
    }

}

