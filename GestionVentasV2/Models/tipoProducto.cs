using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models
{
    public class tipoProducto
    {
        [Key]
        public int id { get; set; }


        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [MaxLength(45, ErrorMessage = "El campo nombre sobrepasa el maximo de caracteres permitidos.")]
        public string nombre { get; set; }


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
        public DateTime? fechaActualizacion { get; set; }


        [Required(ErrorMessage = "El campo estados_id es obligatorio")]
        [ForeignKey("estados")]
        public int estados_id { get; set; }
        public estados estados { get; set; }

    }
}
