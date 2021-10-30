using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models
{
    public class venta
    {
        [Key]
        public int id { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo fecha pedido es obligatorio")]
        public DateTime fechaPedido { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo fecha Entrega es obligatorio")]
        public DateTime fechaEntrega { get; set; }

        


        [Required(ErrorMessage = "El campo total venta creacion es obligatorio")]
        [MaxLength(8, ErrorMessage = "El campo total venta sobrepasa el maximo de caracteres permitidos.")]
        public decimal totalVenta { get; set; }


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


        [Required(ErrorMessage = "El campo establecimiento es obligatorio")]
        [ForeignKey("establecimiento")]
        public int establecimiento_id { get; set; }
        public establecimiento establecimiento { get; set; }


        [Required(ErrorMessage = "El campo pedido es obligatorio")]
        [ForeignKey("pedido")]
        public int pedido_id { get; set; }
        public pedido pedido { get; set; }

       // [Required(ErrorMessage = "El campo cliente es obligatorio")]
        [ForeignKey("cliente")]
        public int? cliente_id { get; set; }
        public cliente cliente { get; set; }


        [Required(ErrorMessage = "El campo estados_id es obligatorio")]
        [ForeignKey("estados")]
        public int estados_id { get; set; }
        public estados estados { get; set; }
      


        [Required(ErrorMessage = "El campo usuario_id es obligatorio")]
        [ForeignKey("usuario")]
        public int usuario_id { get; set; }
        public usuario usuario { get; set; }
    }
}
