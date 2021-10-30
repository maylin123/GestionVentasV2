using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionVentasV2.Data;
using GestionVentasV2.Models;
using GestionVentasV2.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace GestionVentasV2.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        private const int SaltSize = 24;

        private const int HashSize = 64;

        //private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UsuarioController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager) //IMapper mapper
        {
            _context = context;

           // _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: Usuario
        public async Task<IActionResult> Index()
        {

            var usuarios = _context.usuario.Select(x => new usuarioVM
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
                Roles = x.rolUsuario.Where(ru => ru.usuario_id == x.id).Select(ru => new ListaRoles { nombre = ru.rol.nombre }).ToList()
            }).ToList();

            //var usuarios = _context.usuario.Include(u => u.establecimiento).Include(u => u.tipoUsuario).Select(x => new {rolUsuario = x.rol);

            return View(usuarios);
        }

        // GET: Usuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.usuario
                .FirstOrDefaultAsync(m => m.id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        /// <summary>
        /// Devolver la vista para registrar un usuario
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            ViewData["tipoUsuario_id"] = new SelectList(_context.Set<tipoUsuario>(), "id", "nombre");
            ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "nombreComercial");
            //ViewData["rol_id"] = new SelectList(_context.rol, "id", "nombre");

            //Obteber el listado de roles
            var _roles = new SelectList(_context.rol, "id", "nombre");

            ViewBag.roles = _roles;


            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nombre,apellido,correo,contrasenia,direccion,telefono,fechaIngreso,rol_id,establecimiento_id,tipoUsuario_id")] usuarioVM usuario)
        {
            usuario _usuario = new usuario();
            if (ModelState.IsValid)
            {

                //Validar que el correo a registrar no exista
                var _validar = _context.usuario.Where(x => x.correo == usuario.correo).ToList();

                if (_validar.Count > 0)
                {
                    return StatusCode(400, "El correo electrónico que desea registrar ya se encuentra en el sistema.");

                } else
                {


                    
                    
                    

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


                    _usuario.fechaCreacion = System.DateTime.Now;
                    _usuario.usuarioCreacion = "admin";
                    _usuario.estados_id = 1;
                    _usuario.nombre = usuario.nombre;
                    _usuario.apellido = usuario.apellido;
                    _usuario.correo = usuario.correo;
                    

                    /*/Crear el hash para almacenar la contraseña
                    byte[] salt;
                    new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);
                    //Crear el hash
                    var pbkdf2 = new Rfc2898DeriveBytes(usuario.contrasenia, salt, 10000);
                    var hash = pbkdf2.GetBytes(HashSize);


                    //Combiar salt y hash
                    var hashBytes = new Byte[SaltSize + HashSize];
                    Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                    Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

                    //Convertir a base64
                    var base64Hash = Convert.ToBase64String(hashBytes);

                    var newPass = string.Format("$GESTIONVENTAS$V2${0}${1}", 10000, base64Hash);

                    //Asignar la contraseña ya encriptada
                    _usuario.contrasenia = newPass;*/

                    _usuario.direccion = usuario.direccion;
                    _usuario.telefono = usuario.telefono;
                    _usuario.fechaIngreso = usuario.fechaIngreso;
                    _usuario.establecimiento_id = usuario.establecimiento_id;
                    _usuario.tipoUsuario_id = usuario.tipoUsuario_id;




                    //await _userManager.CreateAsync(_usuario, usuario.contrasenia);

                    _context.Add(_usuario);


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
                    return RedirectToAction(nameof(Index));
                }

               
            }
            return View(_usuario);
        }

        // GET: Usuario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var usuario = await _context.usuario.FindAsync(id);



            var usuario = _context.usuario.Where(x => x.id == id)
                                          .Select(x => new usuarioVM
                                          {
                                              id=x.id,
                                              nombre=x.nombre,
                                              apellido = x.apellido,
                                              correo = x.correo,
                                              direccion = x.direccion,
                                              telefono=x.telefono,
                                              fechaIngreso=x.fechaIngreso,
                                              fechaRetiro=x.fechaRetiro,
                                              establecimiento_id=x.establecimiento_id,
                                              tipoUsuario_id=x.tipoUsuario_id,
                                              estados_id=x.estados_id,
                                              rol_id = x.rolUsuario.Where(r => r.usuario_id == id).Select(r => r.rol_id).FirstOrDefault()
                                          }).FirstOrDefault();



            if (usuario == null)
            {
                return NotFound();
            }

            ViewData["tipoUsuario_id"] = new SelectList(_context.Set<tipoUsuario>(), "id", "nombre");
            ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "nombreComercial");

            ViewData["rol_id"] = new SelectList(_context.rol, "id", "nombre");

            //Obteber el listado de roles
           // var _roles = new SelectList(_context.rol, "id", "nombre");

           // ViewBag.roles = _roles;

            

            return View(usuario);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nombre,apellido,correo,direccion,telefono,fechaIngreso,rol_id,establecimiento_id,tipoUsuario_id")] usuarioVMEdit usuario)
        {
            if (id != usuario.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var _usuario = _context.usuario.Find(id);
                    if (_usuario != null)
                    {

                        //Actualizar datos del usuario
                        _usuario.fechaActualizacion = System.DateTime.Now;
                        _usuario.usuarioActualizacion = "admin";
                        //_usuario.estados_id = 1;
                        _usuario.nombre = usuario.nombre;
                        _usuario.apellido = usuario.apellido;
                        _usuario.correo = usuario.correo;
                        _usuario.direccion = usuario.direccion;
                        _usuario.telefono = usuario.telefono;
                        _usuario.fechaIngreso = usuario.fechaIngreso;
                        _usuario.establecimiento_id = usuario.establecimiento_id;
                        _usuario.tipoUsuario_id = usuario.tipoUsuario_id;
                        //_producto.estados_id = 1;
                        _context.Update(_usuario);


                        //Actualizar datos de asignacion de rol
                        //Buscar la asignacion del rol por id del usuario
                        var _asignacionRol = _context.rolUsuario.Where(x => x.usuario_id == id).FirstOrDefault();

                        _asignacionRol.rol_id = usuario.rol_id;
                        _asignacionRol.fechaActualizacion = System.DateTime.Now;
                        _asignacionRol.usuarioActualizacion = "admin";

                        _context.Update(_asignacionRol);


                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!usuarioExists(usuario.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.usuario
                .FirstOrDefaultAsync(m => m.id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var usuario = await _context.usuario.FindAsync(id);

            if (usuario.estados_id == 1)
            {
                usuario.estados_id = 2;
            }
            else
            {
                usuario.estados_id = 1;
            }

            _context.usuario.Update(usuario);

            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        private bool usuarioExists(int id)
        {
            return _context.usuario.Any(e => e.id == id);
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UsuarioLogin userModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userModel);
            }
            var result = await _signInManager.PasswordSignInAsync(userModel.correo, userModel.contrasenia, userModel.recordarme, false);
            if (result.Succeeded)
            {
                return RedirectToLocal(returnUrl);
            }
            else
            {
                ModelState.AddModelError("", "Invalid UserName or Password");
                return View();
            }
        }*/
    }
}
