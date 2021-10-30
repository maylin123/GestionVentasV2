using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models.ViewModels
{
    public class ventaVM
    {
        [Key]
        public int id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
       
        public DateTime fechaEntrega { get; set; }

        
        [MaxLength(8, ErrorMessage = "El campo total venta sobrepasa el maximo de caracteres permitidos.")]
        public string totalVenta { get; set; }

       
        [ForeignKey("establecimiento")]
        public int establecimiento_id { get; set; }
        public establecimiento establecimiento { get; set; }
        
        [ForeignKey("pedido")]
        public int pedido_id { get; set; }
        public pedido pedido { get; set; }

        public string nombreCliente { get; set; }


        [ForeignKey("estados")]
        public int estados_id { get; set; }
        public estados estados { get; set; }
        public string estado { get; set; }


        [ForeignKey("usuario")]
        public int usuario_id { get; set; }
        public usuario usuario { get; set; }
    }
}
