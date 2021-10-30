using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models.ViewModels
{
    public class PedidoVM
    {
        [Key]
        public int id { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "El campo fecha es obligatorio")]
        public DateTime fecha { get; set; }


        [MaxLength(12, ErrorMessage = "El campo nit sobrepasa el maximo de caracteres permitidos.")]
        public string nit { get; set; }

        [MaxLength(150, ErrorMessage = "El campo direccion sobrepasa el maximo de caracteres permitidos.")]
        public string direccion { get; set; }


        [Required(ErrorMessage = "El campo usuario creacion es obligatorio")]
        [MaxLength(45, ErrorMessage = "El campo Direccion Entrega sobrepasa el maximo de caracteres permitidos.")]
        public string direccionEntrega { get; set; }

        [Required(ErrorMessage = "El campo Nombre Cliente es obligatorio")]
        [MaxLength(150, ErrorMessage = "El campo Nombre Cliente  sobrepasa el maximo de caracteres permitidos.")]
        public string nombreCliente { get; set; }

        [Required(ErrorMessage = "El campo Teléfono es obligatorio")]
        [MaxLength(10, ErrorMessage = "El campo Teléfono sobrepasa el maximo de caracteres permitidos.")]
        public string telefono { get; set; }

        [Required(ErrorMessage = "El campo Correo Electrónico es obligatorio")]
        [MaxLength(150, ErrorMessage = "El campo Correo Electrónico sobrepasa el maximo de caracteres permitidos.")]
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
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        //[Required(ErrorMessage = "El campo fecha creacion es obligatorio")]
        public DateTime fechaCreacion { get; set; }


        [MaxLength(45, ErrorMessage = "El campo usuario actualización sobrepasa el maximo de caracteres permitidos.")]
        public string usuarioActualizacion { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fechaActualizacion { get; set; }

        //[Required(ErrorMessage = "El campo estados_id es obligatorio")]
        [ForeignKey("estados")]
        public int estados_id { get; set; }
        public estados estados { get; set; }

        public string estado { get; set; }

        [ForeignKey("establecimiento")]
        public int establecimiento_id { get; set; }
        public establecimiento establecimiento { get; set; }

        public string total { get; set; }


        public List<ListaDetallePedido> items { get; set; }

        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal totalPedido { get; set; }
        public int pedido_id { get; set; }
        public int producto_id { get; set; }



    }

    public class ListaDetallePedido
    {
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal totalPedido { get; set; }
        public int pedido_id { get; set; }
        public int producto_id { get; set; }
        public int estados_id { get; set; }

    }
}
