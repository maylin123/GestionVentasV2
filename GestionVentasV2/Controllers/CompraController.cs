using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionVentasV2.Data;
using GestionVentasV2.Models;
using GestionVentasV2.Models.ViewModels;
using Microsoft.AspNetCore.Http;

namespace GestionVentasV2.Controllers
{
    public class CompraController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompraController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Compra
        public async Task<IActionResult> Index()
        {

            int EstablecimientoId = 0;

            if (HttpContext.Session.Get("EstablecimientoId") != null)
            {
                EstablecimientoId = (int)HttpContext.Session.GetInt32("EstablecimientoId");
            }
                

            if (EstablecimientoId > 0)
            {

                var applicationDbContext = _context.compra.Include(c => c.establecimiento).Include(c => c.estados).Include(c => c.usuario).Where(x => x.establecimiento_id == EstablecimientoId);
                ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
                return View(await applicationDbContext.ToListAsync());
            } else
            {
                return Redirect("~/User/Login");
            }
        }

        // GET: Compra/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.compra
                .Include(c => c.establecimiento)
                .Include(c => c.estados)
                .Include(c => c.usuario)
                .FirstOrDefaultAsync(m => m.id == id);
            if (compra == null)
            {
                return NotFound();
            }
            ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
            return View(compra);
        }

        // GET: Compra/Create
        public IActionResult Create()
        {

            int EstablecimientoId = 0;

            if (HttpContext.Session.Get("EstablecimientoId") != null)
            {
                EstablecimientoId = (int)HttpContext.Session.GetInt32("EstablecimientoId");
            }


            if (EstablecimientoId > 0)
            {
                ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "nombreComercial");
                ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre");
                ViewData["usuario_id"] = new SelectList(_context.usuario, "id", "apellido");

                //Obteber el listado de productos
                var _productos= new SelectList(_context.producto.Where(x => x.establecimiento_id == EstablecimientoId), "id", "nombre");

                ViewBag.productos = _productos;
                ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
                return View();
            }
            else
            {
                return Redirect("~/User/Login");
            }
        }

        // POST: Compra/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<Respuesta> Create( compraVM compra)
        {

            compra _compra = new compra();

            if (ModelState.IsValid)
            {
                try
                {

                    //Generar el correlativo
                    var correlativo = _context.compra.Select(x => x.id).ToList();
                    if (correlativo.Count() > 0)
                    {
                        _compra.id = correlativo.Max() + 1;
                    }
                    else
                    {
                        _compra.id = 1;
                    }


                    _compra.fechaCreacion = System.DateTime.Now;
                    _compra.usuarioCreacion = "admin";
                    _compra.estados_id = 1;
                    _compra.noFactura = compra.noFactura;
                    _compra.fecha = compra.fecha;
                    _compra.totalFactura = compra.totalFactura;
                    //_compra.establecimiento_id = compra.establecimiento_id;
                    _compra.establecimiento_id = (int)HttpContext.Session.GetInt32("EstablecimientoId");
                    _compra.usuario_id = compra.usuario_id;
                    _context.Add(_compra);

                    await _context.SaveChangesAsync();

                    //Almacenar los items de la compra (DetalleCompra)

                    foreach (var item in compra.items)
                    {
                        detalleCompra _detalle = new detalleCompra();

                        //Generar el correlativo
                        var correlativoDet = _context.detalleCompra.Select(x => x.id).ToList();
                        if (correlativoDet.Count() > 0)
                        {
                            _detalle.id = correlativoDet.Max() + 1;
                        }
                        else
                        {
                            _detalle.id = 1;
                        }

                        _detalle.compra_id = _compra.id;
                        _detalle.cantidad = item.cantidad;
                        _detalle.precio = item.precio;
                        _detalle.producto_id = item.producto_id;
                        _detalle.estados_id = 1;
                        _detalle.usuarioCreacion = "admin";
                        _detalle.fechaCreacion = System.DateTime.Now;

                        _context.Add(_detalle);


                        //Almacenar productos al stock
                        //Verificar si hay un registro de stock activo para actualizar la informacion y sumar la cantidad
                        var _validarStock = _context.stock
                                            .Where(x => x.producto_id == item.producto_id)
                                            .Where(x => x.estados_id == 1)
                                            .Where(x => x.detalleCompra.compra.establecimiento_id == compra.establecimiento_id)
                                            .FirstOrDefault();

                        int _cantidadActual = 0;
                        //?Si existe un regsitro en stock del producto activo, se actualiza el estado
                        if(_validarStock != null)
                        {
                            _cantidadActual = _validarStock.cantidad;
                            _validarStock.estados_id = 2;
                            _validarStock.usuarioActualizacion = "admin";
                            _validarStock.fechaActualizacion = System.DateTime.Now;
                            _context.Update(_validarStock);

                        }

                        stock _stock = new stock();

                        //Generar el correlativo del stock
                        var correlativoStock = _context.stock.Select(x => x.id).ToList();
                        if (correlativoStock.Count() > 0)
                        {
                            _stock.id = correlativoStock.Max() + 1;
                        }
                        else
                        {
                            _stock.id = 1;
                        }



                        _stock.cantidad = _cantidadActual + item.cantidad;
                        _stock.precioVenta = item.precioVenta;
                        _stock.usuarioCreacion = "admin";
                        _stock.fechaCreacion = System.DateTime.Now;
                        _stock.detalleCompra_id = _detalle.id;
                        _stock.estados_id = 1;
                        _stock.cantidadEntrada = item.cantidad;
                        _stock.producto_id = item.producto_id;


                        _context.Add(_stock);




                       await _context.SaveChangesAsync();

                        

                    }


                   // await _context.SaveChangesAsync();



                    return new Respuesta
                    {
                        Status = 200,
                        Mensaje = "Se ha registrado la compra con éxito.",
                        Datos = null

                    };

                }
                catch (Exception e)
                {
                    return new Respuesta
                    {
                        Status = 500,
                        Mensaje = "Ha ocurrido un error durante el registro de la compra",
                        Datos = null

                    };
                }
            

            }

            return new Respuesta
            {
                Status = 404,
                Mensaje = "Ha ocurrido un error durante el registro de la compra, no se han enviado los datos correctos.",
                Datos = null

            };

            /*ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "correoElectronico", compra.establecimiento_id);
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", compra.estados_id);
            ViewData["usuario_id"] = new SelectList(_context.usuario, "id", "apellido", compra.usuario_id);
            return View(compra);*/
        }

        // GET: Compra/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.compra.FindAsync(id);
            if (compra == null)
            {
                return NotFound();
            }
            ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "correoElectronico", compra.establecimiento_id);
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", compra.estados_id);
            ViewData["usuario_id"] = new SelectList(_context.usuario, "id", "apellido", compra.usuario_id);
            ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
            return View(compra);
        }

        // POST: Compra/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,noFactura,totalFactura,fecha,usuarioCreacion,fechaCreacion,usuarioActualizacion,fechaActualizacion,establecimiento_id,usuario_id,estados_id")] compra compra)
        {
            if (id != compra.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!compraExists(compra.id))
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
            ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "correoElectronico", compra.establecimiento_id);
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", compra.estados_id);
            ViewData["usuario_id"] = new SelectList(_context.usuario, "id", "apellido", compra.usuario_id);
            return View(compra);
        }

        // GET: Compra/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.compra
                .Include(c => c.establecimiento)
                .Include(c => c.estados)
                .Include(c => c.usuario)
                .FirstOrDefaultAsync(m => m.id == id);
            if (compra == null)
            {
                return NotFound();
            }
            ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
            return View(compra);
        }

        // POST: Compra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compra = await _context.compra.FindAsync(id);
            _context.compra.Remove(compra);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool compraExists(int id)
        {
            return _context.compra.Any(e => e.id == id);
        }
    }
}
