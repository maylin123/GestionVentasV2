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
    public class PedidoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PedidoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pedido
        public async Task<IActionResult> Index()
        {

            int EstablecimientoId = 0;

            if (HttpContext.Session.Get("EstablecimientoId") != null)
            {
                EstablecimientoId = (int)HttpContext.Session.GetInt32("EstablecimientoId");
            }


            if (EstablecimientoId > 0)
            {

                var _pedidos = _context.pedido
                                  .Where(x => x.establecimiento_id == EstablecimientoId)
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
                                      nit = x.nit,
                                      direccion = x.direccion,
                                      establecimiento_id = x.establecimiento_id,
                                      total = String.Format("{0:0.00}", _context.detallePedido
                                            .Where(d => d.pedido_id == x.id)
                                            .GroupBy(d => d.pedido_id)
                                            .Select(n => n.Sum(d => (d.precio * d.cantidad)))
                                            .FirstOrDefault())
                                  });
                ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");

                return View(await _pedidos.ToListAsync());
            }
            else
            {
                return Redirect("~/User/Login");
            }


            //var applicationDbContext = _context.pedido.Include(p => p.estados);
            //return View(await applicationDbContext.ToListAsync());

           

            //_context.pedido.ToListAsync()

            
        }


        // GET: Pedido/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.pedido
                .Include(p => p.estados)
                .FirstOrDefaultAsync(m => m.id == id);

            var _detallePedido = await _context.detallePedido
                                              .Where(x => x.pedido_id == id)
                                              .Select(x => new productoVM
                                              {
                                                  id = x.id,
                                                  pathImagen = x.producto.pathImagen,
                                                  cantidad = x.cantidad,
                                                  precioVenta = x.precio,
                                                  subTotal = String.Format("{0:0.00}", (x.precio * x.cantidad)),
                                                  nombre = x.producto.nombre
                                              }).ToListAsync();


            var _totalPedido = await _context.detallePedido
                                             .Where(x => x.pedido_id == id)
                                             .GroupBy(x => x.pedido_id)
                                             .Select(n => n.Sum(m => (m.precio * m.cantidad)))
                                             .FirstOrDefaultAsync();

            if (pedido == null)
            {
                return NotFound();
            }

            ViewBag.detalle = _detallePedido;
            ViewBag.totalPedido = String.Format("{0:0.00}", _totalPedido);
            ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
            return View(pedido);
        }

        // GET: Pedido/Create
        public IActionResult Create()
        {
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre");

            //Obteber el listado de productos
            var _productos = new SelectList(_context.producto, "id", "nombre");
            ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
            ViewBag.productos = _productos;
            return View();
        }

        // POST: Pedido/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<Respuesta> Create(PedidoVM pedido)
        {
            pedido _pedido = new pedido();

            if (ModelState.IsValid)
            {
                try
                {

                    //Generar el correlativo
                    var correlativo = _context.pedido.Select(x => x.id).ToList();
                    if (correlativo.Count() > 0)
                    {
                        _pedido.id = correlativo.Max() + 1;
                    }
                    else
                    {
                        _pedido.id = 1;
                    }


                    _pedido.fechaCreacion = System.DateTime.Now;
                    _pedido.usuarioCreacion = "admin";
                    _pedido.estados_id = 1;
                    //_pedido.establecimiento_id = pedido.establecimiento_id;
                    _pedido.fecha = pedido.fecha;
                    _pedido.direccionEntrega = pedido.direccionEntrega  ;
                    _pedido.nombreCliente = pedido.nombreCliente;
                    _pedido.telefono = pedido.telefono;
                    _pedido.correo = pedido.correo;
                    _pedido.departamento = pedido.departamento;
                    _pedido.municipio = pedido.municipio;
                    _pedido.establecimiento_id = (int)HttpContext.Session.GetInt32("EstablecimientoId");
                    _context.Add(_pedido);

                    await _context.SaveChangesAsync();

                    //Almacenar los items de la compra (DetalleCompra)

                    foreach (var item in pedido.items)
                    {
                        detallePedido _detalle = new detallePedido();

                        //Generar el correlativo
                        var correlativoDet = _context.detallePedido.Select(x => x.id).ToList();
                        if (correlativoDet.Count() > 0)
                        {
                            _detalle.id = correlativoDet.Max() + 1;
                        }
                        else
                        {
                            _detalle.id = 1;
                        }

                        _detalle.pedido_id = _pedido.id;
                        _detalle.producto_id = item.producto_id;
                        _detalle.estados_id = 1;
                        _detalle.cantidad = item.cantidad;
                        _detalle.precio = item.precio;
                        _detalle.usuarioCreacion = "admin";
                        _detalle.fechaCreacion = System.DateTime.Now;

                        _context.Add(_detalle);

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

        }

        // GET: Pedido/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.pedido.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", pedido.estados_id);
            ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
            return View(pedido);
        }

        // POST: Pedido/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,fecha,nombreCliente,direccionEntrega,telefono,correo")] pedido pedido)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var Pedido = _context.pedido.Find(id);
                    if (Pedido != null)
                    {
                        Pedido.fecha = pedido.fecha;
                        Pedido.direccionEntrega = pedido.direccionEntrega;
                        Pedido.nombreCliente = pedido.nombreCliente;
                        Pedido.telefono = pedido.telefono;
                        Pedido.correo = pedido.correo;
                        Pedido.usuarioActualizacion = "admin";
                        Pedido.fechaActualizacion = System.DateTime.Now;
                        _context.Update(Pedido);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!pedidoExists(pedido.id))
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
            return View(pedido);
        }

        // GET: Pedido/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.pedido
                .Include(p => p.estados)
                .FirstOrDefaultAsync(m => m.id == id);
            if (pedido == null)
            {
                return NotFound();
            }
            ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
            return View(pedido);
        }

        // POST: Pedido/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedido = await _context.pedido.FindAsync(id);
            if (pedido.estados_id == 1)
            {
                pedido.estados_id = 21;
            }
            else
            {
                pedido.estados_id = 1;
            }
            _context.pedido.Update(pedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool pedidoExists(int id)
        {
            return _context.pedido.Any(e => e.id == id);
        }


        //Vista para que un cliente genere su pedido de un producto seleccionado
        public async Task<IActionResult> CrearPedido(PrePedidoVM pedido)
        {

            decimal _total = pedido.cantidad * pedido.precioVenta;

            var _producto = _context.producto.Where(x => x.id == pedido.productoId)
                                    .Select( x =>  new productoVM
                                    {
                                        id = x.id,
                                        nombre = x.nombre,
                                        cantidad = pedido.cantidad,
                                        subTotal = Convert.ToString(_total),
                                        pathImagen = x.pathImagen, 
                                        precioVenta = pedido.precioVenta,
                                        establecimientoId = x.establecimiento_id
                                    });


            var _datosEstablecimiento = _context.establecimiento.Where(x => x.id == pedido.establecimientoId).FirstOrDefault();

            //ViewBag.datosProducto = _producto;
            ViewBag.datosEstablecimiento = _datosEstablecimiento;
            return View(await _producto.FirstOrDefaultAsync());

        }

        // POST: Pedido/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegistrarPedido(PedidoVM pedido)
        {
            pedido _pedido = new pedido();

            if (ModelState.IsValid)
            {
                try
                {

                    //Generar el correlativo
                    var correlativo = _context.pedido.Select(x => x.id).ToList();
                    if (correlativo.Count() > 0)
                    {
                        _pedido.id = correlativo.Max() + 1;
                    }
                    else
                    {
                        _pedido.id = 1;
                    }


                    _pedido.fechaCreacion = System.DateTime.Now;
                    _pedido.usuarioCreacion = "admin";
                    _pedido.estados_id = 1;
                    _pedido.establecimiento_id = pedido.establecimiento_id;
                    _pedido.fecha = System.DateTime.Now;
                    _pedido.direccionEntrega = pedido.direccionEntrega;
                    _pedido.nombreCliente = pedido.nombreCliente;
                    _pedido.telefono = pedido.telefono;
                    _pedido.correo = pedido.correo;
                    _pedido.departamento = pedido.departamento;
                    _pedido.municipio = pedido.municipio;
                    _pedido.nit = pedido.nit;
                    _pedido.direccion = pedido.direccion;
                    _context.Add(_pedido);

                    await _context.SaveChangesAsync();

                    //Almacenar los items de la compra (DetalleCompra)


                    detallePedido _detalle = new detallePedido();

                    //Generar el correlativo
                    var correlativoDet = _context.detallePedido.Select(x => x.id).ToList();
                    if (correlativoDet.Count() > 0)
                    {
                        _detalle.id = correlativoDet.Max() + 1;
                    }
                    else
                    {
                        _detalle.id = 1;
                    }

                    _detalle.pedido_id = _pedido.id;
                    _detalle.producto_id = pedido.producto_id;
                    _detalle.estados_id = 1;
                    _detalle.cantidad = pedido.cantidad;
                    _detalle.precio = pedido.precio;
                    _detalle.usuarioCreacion = "admin";
                    _detalle.fechaCreacion = System.DateTime.Now;

                    _context.Add(_detalle);

                    await _context.SaveChangesAsync();


                    return Redirect("~/Establecimiento/Home?EstablecimientoId="+ pedido.establecimiento_id + "&&PedidoRealizado=1");
                    // await _context.SaveChangesAsync();
                    //return RedirectToAction(nameof(CrearPedido));

                }
                catch (Exception e)
                {
                    return RedirectToAction(nameof(CrearPedido));
                }

            }

            return RedirectToAction(nameof(CrearPedido));
        }
    }
}
