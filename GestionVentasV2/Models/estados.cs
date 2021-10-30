using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models
{
    public class estados
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="El campo nombre es obligatorio")]
        [MaxLength(45, ErrorMessage = "El campo nombre sobrepasa el maximo de caracteres permitidos.")]
        public string nombre { get; set; }

        public List<establecimiento> establecimiento { get; set; }
    }
}
