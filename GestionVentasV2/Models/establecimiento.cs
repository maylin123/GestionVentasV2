using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models
{
    public class establecimiento
    {
        [Key]
        public int id { get; set; }

        [MaxLength(150, ErrorMessage = "El campo razon social sobrepasa el maximo de caracteres permitidos.")]
        public string razonSocial { get; set; }


        [Required(ErrorMessage = "El campo nombre comercial es obligatorio")]
        [MaxLength(150, ErrorMessage = "El campo nombre comercial sobrepasa el maximo de caracteres permitidos.")]
        public string nombreComercial { get; set; }

        
        [MaxLength(45, ErrorMessage = "El campo nit sobrepasa el maximo de caracteres permitidos.")]
        public string nit { get; set; }

        [Required(ErrorMessage = "El campo correo electronico es obligatorio")]
        [MaxLength(200, ErrorMessage = "El campo correo electronico sobrepasa el maximo de caracteres permitidos.")]
        public string correoElectronico { get; set; }

        [MaxLength(200, ErrorMessage = "El campo direccion fiscal sobrepasa el maximo de caracteres permitidos.")]
        public string direccionFiscal { get; set; }

        [Required(ErrorMessage = "El campo direccion mobiliaria es obligatorio")]
        [MaxLength(200, ErrorMessage = "El campo direccion mobiliaria sobrepasa el maximo de caracteres permitidos.")]
        public string direccionMobiliaria { get; set; }

        [Required(ErrorMessage = "El campo telefono es obligatorio")]
        [MaxLength(12, ErrorMessage = "El campo telefono sobrepasa el maximo de caracteres permitidos.")]
        public string telefono { get; set; }

        //[Required(ErrorMessage = "El campo Imagen es obligatorio")]
        [MaxLength(255, ErrorMessage = "El campo Imagen sobrepasa el maximo de caracteres permitidos.")]
        public string pathImagen { get; set; }

        //[Required(ErrorMessage = "El campo estados_id es obligatorio")]
        [ForeignKey("estados")]
        public int? estados_id { get; set; }
        public estados estados { get; set; }


        [Required(ErrorMessage = "El campo tipo establecimiento es obligatorio")]

        [ForeignKey("tipoEstablecimiento")]
        public int? tipoEstablecimiento_id { get; set; }
        public tipoEstablecimiento tipoEstablecimiento { get; set; }


        //[Required(ErrorMessage = "El campo usuario creacion es obligatorio")]
        [MaxLength(45, ErrorMessage = "El campo usuario creacion sobrepasa el maximo de caracteres permitidos.")]
        public string? usuarioCreacion { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo fecha creacion es obligatorio")]
        public DateTime fechaCreacion { get; set; }


        [MaxLength(45, ErrorMessage = "El campo usuario creacion sobrepasa el maximo de caracteres permitidos.")]
        public string usuarioActualizacion { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fechaActualizacion { get; set; }


        [MaxLength(1000, ErrorMessage = "El campo descripción general sobrepasa el maximo de caracteres permitidos.")]
        public string? descripcionGeneral { get; set; }
    }
}
