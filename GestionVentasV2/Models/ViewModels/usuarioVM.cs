using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionVentasV2.Models.ViewModels
{
    public class usuarioVM
    {
        [Key]
        public int id { get; set; }

        //public string UsersId { get; set; }


        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [MaxLength(45, ErrorMessage = "El campo nombre sobrepasa el maximo de caracteres permitidos.")]
        public string nombre { get; set; }


        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        [MaxLength(45, ErrorMessage = "El campo apellido sobrepasa el maximo de caracteres permitidos.")]
        public string apellido { get; set; }


        [Required(ErrorMessage = "El campo correo electrónico es obligatorio")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(200, ErrorMessage = "El campo correo electrónico sobrepasa el maximo de caracteres permitidos.")]
        public string correo { get; set; }


        /*[Required(ErrorMessage = "El campo contraseña es obligatorio")]
        [MaxLength(255, ErrorMessage = "El campo contrase;a sobrepasa el maximo de caracteres permitidos.")]
        public string contrasenia { get; set; }*/


        [MaxLength(150, ErrorMessage = "El campo dirección sobrepasa el maximo de caracteres permitidos.")]
        public string direccion { get; set; }


        [Required(ErrorMessage = "El campo teléfono es obligatorio")]
        [MaxLength(12, ErrorMessage = "El campo teléfono sobrepasa el maximo de caracteres permitidos.")]
        public string telefono { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "El campo fecha Ingreso es obligatorio")]
        public DateTime fechaIngreso { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime fechaRetiro { get; set; }


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

        //[Required(ErrorMessage = "El campo establecimiento es obligatorio")]
        [ForeignKey("establecimiento")]
        public int? establecimiento_id { get; set; }
        public string establecimiento { get; set; }

        [Required(ErrorMessage = "El campo tipoUsuario es obligatorio")]
        [ForeignKey("tipoUsuario")]
        public int tipoUsuario_id { get; set; }
        public string tipoUsuario { get; set; }

        [Required(ErrorMessage = "El campo estados es obligatorio")]
        [ForeignKey("estados")]
        public int estados_id { get; set; }

      
        public int rol_id { get; set; }

        public string rol { get; set; }

       /* [ForeignKey("ApplicationUser")]
        public string user_id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }*/

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Las contraseñas ingresadas no coinciden")]
        public string ConfirmedPassword { get; set; }

        public List<ListaRoles> Roles { get; set; }

      

    }

    public class ListaRoles
    {
        public int id { get; set; }
        public string nombre { get; set; }

    }
}
