using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models.ViewModels
{
    public class PrePedidoVM
    {
        public int productoId { get; set; }
        public int establecimientoId { get; set; }
        public int cantidad { get; set; }
        public decimal precioVenta { get; set; }
    }
}
