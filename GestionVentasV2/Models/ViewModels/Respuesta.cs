using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models.ViewModels
{
    public class Respuesta
    {
        public int Status { get; set; }
        public string Mensaje { get; set; }
        public object Datos { get; set;  }
    }
}
