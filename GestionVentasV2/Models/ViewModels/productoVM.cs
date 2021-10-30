using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models.ViewModels
{
    public class productoVM
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string nombreCategoria { get; set; }
        public string descripcion { get; set; }
        public string pathImagen { get; set; }
        public decimal precioVenta { get; set; }
        public string nombreEstablecimiento { get; set; }
        public int idEstablecimiento { get; set; }
        public string pathEstablecimientoImagen { get; set; }
        public int establecimientoId { get; set; }
        public int cantidad { get; set; }
        public string subTotal { get; set; }
    }
}
