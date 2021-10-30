using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models
{
    public class UsuarioLogin
    {
        [Required]
        [EmailAddress]
        public string correo { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string contrasenia { get; set; }
        [Display(Name = "Recordar credenciales?")]
        public bool recordarme { get; set; }
    }
}
