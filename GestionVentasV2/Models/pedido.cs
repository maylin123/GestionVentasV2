using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models
{
    public class pedido
    {
        [Key]
        public int id { get; set; }


        [Required(ErrorMessage = "El campo fecha creacion es obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime fecha { get; set; }

        [MaxLength(12, ErrorMessage = "El campo nit sobrepasa el maximo de caracteres permitidos.")]
            public string nit { get; set; }

        [MaxLength(150, ErrorMessage = "El campo direccion sobrepasa el maximo de caracteres permitidos.")]
        public string direccion { get; set; }


        [Required(ErrorMessage = "El campo nombre cliente es obligatorio")]
        [MaxLength(150, ErrorMessage = "El campo nombre cliente sobrepasa el maximo de caracteres permitidos.")]
        public string nombreCliente { get; set; }


        [Required(ErrorMessage = "El campo dirección entrega es obligatorio")]
        [MaxLength(150, ErrorMessage = "El campo dirección entrega sobrepasa el maximo de caracteres permitidos.")]
        public string direccionEntrega { get; set; }


        [Required(ErrorMessage = "El campo teléfono es obligatorio")]
        [MaxLength(12, ErrorMessage = "El campo teléfono sobrepasa el maximo de caracteres permitidos.")]
        public string telefono { get; set; }


        [Required(ErrorMessage = "El campo correo electrónico es obligatorio")]
        [MaxLength(200, ErrorMessage = "El campo  correo electrónico sobrepasa el maximo de caracteres permitidos.")]
        public string correo { get; set; }

        [Required(ErrorMessage = "El campo departamento es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo departamento sobrepasa el maximo de caracteres permitidos.")]
        public string departamento { get; set; }

        [Required(ErrorMessage = "El campo municipio es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo municipio sobrepasa el maximo de caracteres permitidos.")]
        public string municipio { get; set; }


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


        //[Required(ErrorMessage = "El campo estados_id es obligatorio")]
        [ForeignKey("estados")]
        public int estados_id { get; set; }
        public estados estados { get; set; }

        [ForeignKey("establecimiento")]
        public int establecimiento_id { get; set; }
        public establecimiento establecimiento { get; set; }
    }
}
