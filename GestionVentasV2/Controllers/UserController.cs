using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionVentasV2.Data;
using GestionVentasV2.Models;
using Microsoft.AspNetCore.Identity;
using GestionVentasV2.Models.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace GestionVentasV2.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;
        public UserController(ApplicationDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signinManager)
        {
            _context = context;
            _userManager = userManager;
            _signinManager = signinManager;
        }
        public IActionResult Index()
        {
            int EstablecimientoId = 0;

            if (HttpContext.Session.Get("EstablecimientoId") != null)
            {
                EstablecimientoId = (int)HttpContext.Session.GetInt32("EstablecimientoId");

                //var _usuarios = _context. .ToList();
                var _usuarios = _context.usuario.Where(x => x.establecimiento_id == EstablecimientoId).Select(x => new usuarioVM
                {
                    id = x.id,
                    nombre = x.nombre,
                    apellido = x.apellido,
                    correo = x.correo,
                    direccion = x.direccion,
                    telefono = x.telefono,
                    fechaIngreso = x.fechaIngreso,
                    fechaRetiro = x.fechaRetiro,
                    establecimiento = x.establecimiento.nombreComercial,
                    tipoUsuario = x.tipoUsuario.nombre,
                    estados_id = x.estados_id,
                    //UsersId = x.ApplicationUser.Id,
                    Roles = x.rolUsuario.Where(ru => ru.usuario_id == x.id).Select(ru => new ListaRoles { nombre = ru.rol.nombre }).ToList()
                }).ToList();

                // var _usuarios = _userManager.Users;
                // var usuarios = _context
                return View(_usuarios);
            }
            else
            {
                return Redirect("~/User/Login");

            }
        }


        public IActionResult Create()
        {

            int EstablecimientoId = 0;

            if (HttpContext.Session.Get("EstablecimientoId") != null)
            {
                EstablecimientoId = (int)HttpContext.Session.GetInt32("EstablecimientoId");

                ViewData["tipoUsuario_id"] = new SelectList(_context.tipoUsuario.Where(x => x.id == 1), "id", "nombre");
                ViewData["establecimiento_id"] = new SelectList(_context.establecimiento.Where(x => x.id == EstablecimientoId), "id", "nombreComercial");
                //ViewData["rol_id"] = new SelectList(_context.rol, "id", "nombre");

                //Obteber el listado de roles
                var _roles = new SelectList(_context.rol.Where(x => x.id > 1), "id", "nombre");
                ViewBag.roles = _roles;
                return View();
            }
            else
            {
                return Redirect("~/User/Login");

            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(usuarioVM usuario)
        {
            if (ModelState.IsValid)
            {
                var _user = new IdentityUser()
                {
                    UserName = usuario.correo,
                    Email = usuario.correo

                };

                var result = await _userManager.CreateAsync(_user, usuario.Password);

                if (result.Succeeded)
                {

                    usuario _usuario = new usuario();

                    //Generar el correlativo
                    var correlativo = _context.usuario.Select(x => x.id).ToList();
                    if (correlativo.Count() > 0)
                    {
                        _usuario.id = correlativo.Max() + 1;
                    }
                    else
                    {
                        _usuario.id = 1;
                    }

                    _usuario.user_id = _user.Id;
                    _usuario.fechaCreacion = System.DateTime.Now;
                    _usuario.usuarioCreacion = "admin";
                    _usuario.estados_id = 1;
                    _usuario.nombre = usuario.nombre;
                    _usuario.apellido = usuario.apellido;
                    _usuario.correo = usuario.correo;




                    _usuario.direccion = usuario.direccion;
                    _usuario.telefono = usuario.telefono;
                    _usuario.fechaIngreso = usuario.fechaIngreso;

                    if (usuario.establecimiento_id == 0)
                        _usuario.establecimiento_id = null;
                    else
                        _usuario.establecimiento_id = (int)HttpContext.Session.GetInt32("EstablecimientoId");


                    _usuario.tipoUsuario_id = usuario.tipoUsuario_id;
                    _usuario.contrasenia = usuario.Password;



                    //await _userManager.CreateAsync(_usuario, usuario.contrasenia);

                    _context.Add(_usuario);
                    await _context.SaveChangesAsync();

                    //Asginar el Rol


                    rolUsuario _rolUsuario = new rolUsuario();

                    //Generar el correlativo de rolusuario
                    var correlativoRol = _context.rolUsuario.Select(x => x.id).ToList();
                    if (correlativoRol.Count() > 0)
                    {
                        _rolUsuario.id = correlativo.Max() + 1;
                    }
                    else
                    {
                        _rolUsuario.id = 1;
                    }

                    _rolUsuario.rol_id = usuario.rol_id;
                    _rolUsuario.estados_id = 1;
                    _rolUsuario.usuario_id = Convert.ToInt32(_usuario.id);
                    _rolUsuario.fechaCreacion = System.DateTime.Now;
                    _rolUsuario.usuarioCreacion = "admin";

                    _context.Add(_rolUsuario);

                    await _context.SaveChangesAsync();

                    return Redirect("~/User/Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);

                }
                return View();
            }


            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(userLoginVM usuario)
        {
            if (ModelState.IsValid)
            {
                var result = await _signinManager.PasswordSignInAsync(usuario.Email, usuario.Password, false, false);

                if (result.Succeeded)
                {

                    //!Obtener el id del usuario logueado (tabla users)
                    // var _currentUser = await _userManager.GetUserAsync(HttpContext.User);
                    // var _currentUserId = _currentUser.Id;
                    var _currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                    var user = await _userManager.FindByNameAsync(usuario.Email);

                    //!Obtener datos y roles del usuario
                    var _datosUsuario = _context.usuario
                                                .Where(x => x.user_id == user.Id)
                                                .FirstOrDefault();

                    var _currentRoles = _context.rolUsuario
                                                .Where(x => x.usuario_id == _datosUsuario.id)
                                                .FirstOrDefault();

                    if (_currentRoles != null)
                    {

                        if (_currentRoles.rol_id == 2)
                        {
                            var Establecimiento = _context.establecimiento.Where(x => x.id == _datosUsuario.establecimiento_id).FirstOrDefault();

                            HttpContext.Session.SetInt32("EstablecimientoId", (int)_datosUsuario.establecimiento_id);
                            HttpContext.Session.SetString("EstablecimientoNombre", Establecimiento.nombreComercial);
                            return Redirect("~/AdminEstablecimiento/Index");
                        }

                    }


                    return Redirect("~/Administracion/Index");
                }

                ModelState.AddModelError("", "Usuario o contraseña incorrecto");
                return RedirectToAction(nameof(Login));

            }
            ModelState.AddModelError("", "Usuario o contraseña incorrecto");
            return RedirectToAction(nameof(Login));
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signinManager.SignOutAsync();
            HttpContext.Session.Remove("EstablecimientoId");
            HttpContext.Session.Remove("EstablecimientoNombre");
            return Redirect("~/");
        }

       
    }
}
