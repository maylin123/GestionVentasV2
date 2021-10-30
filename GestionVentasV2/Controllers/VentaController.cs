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
    public class VentaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VentaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Venta
        public async Task<IActionResult> Index()
        {
            //var applicationDbContext = _context.venta.Include(v => v.cliente).Include(v => v.establecimiento).Include(v => v.estados).Include(v => v.pedido).Include(v => v.usuario);
            int EstablecimientoId = 0;

            if (HttpContext.Session.Get("EstablecimientoId") != null)
            {
                EstablecimientoId = (int)HttpContext.Session.GetInt32("EstablecimientoId");
            }


            if (EstablecimientoId > 0)
            {

                var _ventas = _context.venta
                                 .Where(x => x.establecimiento_id == EstablecimientoId)
                                 .Select(x => new ventaVM
                                 {
                                     id = x.id,
                                     nombreCliente = x.pedido.nombreCliente,
                                     totalVenta = String.Format("{0:0.00}", x.totalVenta),
                                     fechaEntrega = x.fechaEntrega,
                                     estado = x.estados.nombre,
                                     estados_id = x.estados_id

                                 });

                ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
                return View(await _ventas.ToListAsync());

            }
            else
            {
                return Redirect("~/User/Login");
            }

           
        }

        // GET: Venta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.venta
                /* .Select(x =>  new{
                   x.fechaPedido,
                   x.fechaEntrega,
                   x.totalVenta,
                   x.establecimiento.nombreComercial
                  })*/
                //.Include(v => v.cliente)
                .Include(v => v.establecimiento)
                .Include(v => v.estados)
                .Include(v => v.pedido)
                .Include(v => v.usuario)
                .FirstOrDefaultAsync(m => m.id == id);


            var _detalleVenta = _context.detalleVenta
                                              .Where(x => x.venta_id == id)
                                              .Select(x => new productoVM
                                              {
                                                  id = x.id,
                                                  pathImagen = x.producto.pathImagen,
                                                  cantidad = x.cantidad,
                                                  precioVenta = x.precioVenta,
                                                  subTotal = String.Format("{0:0.00}", (x.precioVenta * x.cantidad)),
                                                  nombre = x.producto.nombre
                                              }).ToList();


            if (venta == null)
            {
                return NotFound();
            }

            ViewBag.detalle = _detalleVenta;
            ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
            return View(venta);
        }

        // GET: Venta/Create
        public IActionResult Create()
        {
            ViewData["cliente_id"] = new SelectList(_context.cliente, "id", "apellido");
            ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "correoElectronico");
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre");
            ViewData["pedido_id"] = new SelectList(_context.pedido, "id", "correo");
            ViewData["usuario_id"] = new SelectList(_context.usuario, "id", "apellido");
            return View();
        }

        // POST: Venta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ventaVM venta)
        {

            //!Obtener los datos del pedido
            
            var _pedido = _context.pedido
                                  .Where(x => x.id == venta.pedido_id)
                                   .Select(x => new PedidoVM
                                   {
                                       id = x.id,
                                       fecha = x.fecha,
                                       direccionEntrega = x.direccionEntrega,
                                       departamento = x.departamento,
                                       municipio = x.municipio,
                                       nombreCliente = x.nombreCliente,
                                       telefono = x.telefono,
                                       correo = x.correo,
                                       estados_id = x.estados_id,
                                       estado = x.estados.nombre,
                                       establecimiento_id = x.establecimiento_id,
                                       total = String.Format("{0:0.00}", _context.detallePedido
                                             .Where(d => d.pedido_id == x.id)
                                             .GroupBy(d => d.pedido_id)
                                             .Select(n => n.Sum(d => (d.precio * d.cantidad)))
                                             .FirstOrDefault())
                                   }).FirstOrDefault();

            if (_pedido != null)
            {

                var _detallePedido = _context.detallePedido
                                             .Where(x => x.pedido_id == venta.pedido_id)
                                             .ToList();
                //!Validar que el pedido tenga 1 o mas detalles
                if(_detallePedido.Count() > 0)
                {

                    //!Almacenar la venta
                    var _venta = new venta();

                    _venta.id = 1;
                    var correlativoVenta = _context.venta.Select(x => x.id).ToList();

                    if (correlativoVenta.Count() > 0)
                    {
                        _venta.id = correlativoVenta.Max() + 1;
                    }

                    _venta.fechaPedido = _pedido.fecha;
                    _venta.fechaEntrega = System.DateTime.Now;
                    _venta.establecimiento_id = _pedido.establecimiento_id;
                    _venta.totalVenta = decimal.Parse(_pedido.total);
                    _venta.pedido_id = venta.pedido_id;
                    _venta.estados_id = 10;
                    _venta.usuarioCreacion = "admin";
                    _venta.fechaCreacion = System.DateTime.Now;
                    _venta.usuario_id = 1;
                    _venta.cliente_id = null;

                    _context.Add(_venta);
                    await _context.SaveChangesAsync();

                    //Actualizar el estado del pedido a facturado

                    var _pedidoActualizar = _context.pedido.Where(x => x.id == venta.pedido_id).FirstOrDefault();

                    _pedidoActualizar.estados_id = 20;


                    //!Registrar el detalle de la venta obteniendo los datos de detalle pedido
                    foreach(var _detalle in _detallePedido)
                    {
                        var _detalleVenta = new detalleVenta();

                        _detalleVenta.id = 1;
                        var correlativoDetalle = _context.detalleVenta.Select(x => x.id).ToList();

                        if (correlativoDetalle.Count() > 0)
                        {
                            _detalleVenta.id = correlativoDetalle.Max() + 1;
                        }

                        _detalleVenta.venta_id = _venta.id;
                        _detalleVenta.estados_id = 1;
                        _detalleVenta.producto_id = _detalle.producto_id;
                        _detalleVenta.cantidad = _detalle.cantidad;
                        _detalleVenta.fechaCreacion = System.DateTime.Now;
                        _detalleVenta.usuarioCreacion = "admin";
                        _detalleVenta.precioVenta = _detalle.precio;
                        _detalleVenta.porcentajeDescuento = 0;

                        _context.Add(_detalleVenta);
                        await _context.SaveChangesAsync();
                    }






                }



                return Redirect("~/Pedido");
            } 

            return Redirect("~/Pedido?Estado=404");
        }

        // GET: Venta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.venta.FindAsync(id);
            if (venta == null)
            {
                return NotFound();
            }
            ViewData["cliente_id"] = new SelectList(_context.cliente, "id", "apellido", venta.cliente_id);
            ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "correoElectronico", venta.establecimiento_id);
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", venta.estados_id);
            ViewData["pedido_id"] = new SelectList(_context.pedido, "id", "correo", venta.pedido_id);
            ViewData["usuario_id"] = new SelectList(_context.usuario, "id", "apellido", venta.usuario_id);
            ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
            return View(venta);
        }

        // POST: Venta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,fechaPedido,fechaEntrega,totalVenta,usuarioCreacion,fechaCreacion,usuarioActualizacion,fechaActualizacion,establecimiento_id,pedido_id,cliente_id,estados_id,usuario_id")] venta venta)
        {
            if (id != venta.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(venta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ventaExists(venta.id))
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
            ViewData["cliente_id"] = new SelectList(_context.cliente, "id", "apellido", venta.cliente_id);
            ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "correoElectronico", venta.establecimiento_id);
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", venta.estados_id);
            ViewData["pedido_id"] = new SelectList(_context.pedido, "id", "correo", venta.pedido_id);
            ViewData["usuario_id"] = new SelectList(_context.usuario, "id", "apellido", venta.usuario_id);
            return View(venta);
        }

        // GET: Venta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.venta
                .Include(v => v.cliente)
                .Include(v => v.establecimiento)
                .Include(v => v.estados)
                .Include(v => v.pedido)
                .Include(v => v.usuario)
                .FirstOrDefaultAsync(m => m.id == id);
            if (venta == null)
            {
                return NotFound();
            }
            ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
            return View(venta);
        }

        // POST: Venta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var venta = await _context.venta.FindAsync(id);
            _context.venta.Remove(venta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ventaExists(int id)
        {
            return _context.venta.Any(e => e.id == id);
        }
    }
}
