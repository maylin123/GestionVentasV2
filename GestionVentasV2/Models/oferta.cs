using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models
{
    public class oferta
    {
        [Key]
        public int id { get; set; }


   
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [MaxLength(300, ErrorMessage = "El campo nombre sobrepasa el maximo de caracteres permitidos.")]
        public string nombre { get; set; }


        [Required(ErrorMessage = "El campo descripción es obligatorio")]
        [MaxLength(500, ErrorMessage = "El campo descripción sobrepasa el maximo de caracteres permitidos.")]
        public string descripcion { get; set; }


        [Required(ErrorMessage = "El campo imagen es obligatorio")]
        [MaxLength(256, ErrorMessage = "El campo imagen sobrepasa el maximo de caracteres permitidos.")]
        public string imagen { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "El campo fecha Apertura es obligatorio")]
        public DateTime fechaApertura { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "El campo fecha Cierre es obligatorio")]
        public DateTime fechaCierre { get; set; }


        [Range(0,99, ErrorMessage = "El campo Porcentaje Descuento debe ser un número entre 0 y 99.")]
        public int porcentajeDescuento { get; set; }


        //[Required(ErrorMessage = "El campo usuario creacion es obligatorio")]
        [MaxLength(45, ErrorMessage = "El campo usuario creacion sobrepasa el maximo de caracteres permitidos.")]
        public string usuarioCreacion { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        //[Required(ErrorMessage = "El campo fecha creacion es obligatorio")]
        public DateTime fechaCreacion { get; set; }


        [MaxLength(45, ErrorMessage = "El campo usuario actualización sobrepasa el maximo de caracteres permitidos.")]
        public string usuarioActualizacion { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime fechaActualizacion { get; set; }


        [Required(ErrorMessage = "El campo establecimiento es obligatorio")]
        [ForeignKey("establecimiento")]
        public int establecimiento_id { get; set; }
        public establecimiento establecimiento { get; set; }



        //[Required(ErrorMessage = "El campo estados_id es obligatorio")]
        [ForeignKey("estados")]
        public int estados_id { get; set; }
        public estados estados { get; set; }

    }
}
