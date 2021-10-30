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
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Producto
        public async Task<IActionResult> Index()
        {
            int EstablecimientoId = 0;

            if (HttpContext.Session.Get("EstablecimientoId") != null)
            {
                EstablecimientoId = (int)HttpContext.Session.GetInt32("EstablecimientoId");
            }
                

            if (EstablecimientoId > 0) {
                ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
                var applicationDbContext = _context.producto.Include(p => p.categoria).Include(p => p.establecimiento).Include(p => p.estados).Include(p => p.tipoProducto).Where(x => x.establecimiento_id == EstablecimientoId);
                return View(await applicationDbContext.ToListAsync());
            } else
            {
                return Redirect("~/User/Login");
            }

            
        }

        // GET: Producto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            int EstablecimientoId = 0;

            if (HttpContext.Session.Get("EstablecimientoId") != null)
            {
                EstablecimientoId = (int)HttpContext.Session.GetInt32("EstablecimientoId");
            }


            if (EstablecimientoId > 0)
            {
                ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
                var producto = await _context.producto
               .Include(p => p.categoria)
               .Include(p => p.establecimiento)
               .Include(p => p.estados)
               .Include(p => p.tipoProducto)
               .FirstOrDefaultAsync(m => m.id == id);
                if (producto == null)
                {
                    return NotFound();
                }

                return View(producto);
            }
            else
            {
                return Redirect("~/User/Login");
            }

           
        }

        // GET: Producto/Create
        public IActionResult Create()
        {

            int EstablecimientoId = 0;

            if (HttpContext.Session.Get("EstablecimientoId") != null)
            {
                EstablecimientoId = (int)HttpContext.Session.GetInt32("EstablecimientoId");
            

                ViewData["categoria_id"] = new SelectList(_context.Set<categoria>(), "id", "nombre");
                ViewData["establecimiento_id"] = new SelectList(_context.establecimiento.Where(x => x.id == EstablecimientoId), "id", "nombreComercial");
                //ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre");
                ViewData["tipoProducto_id"] = new SelectList(_context.Set<tipoProducto>(), "id", "nombre");

                ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");


                return View();
            } else
            {
                return Redirect("~/User/Login");

            }
        }

        // POST: Producto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nombre,descripcion,pathImagen,establecimiento_id,tipoProducto_id,categoria_id")] producto producto)
        {
            if (ModelState.IsValid)
            {

                //Generar el correlativo
                var correlativo = _context.producto.Select(x => x.id).ToList();
                if (correlativo.Count() > 0)
                {
                    producto.id = correlativo.Max() + 1;
                }
                else
                {
                    producto.id = 1;
                }
                if(producto.pathImagen == String.Empty || producto.pathImagen == null)
                {
                    producto.pathImagen = "imagenes/productos/default.jpg";
                }
                producto.fechaCreacion = System.DateTime.Now;
                producto.usuarioCreacion = "admin";
                producto.estados_id = 1;
                producto.establecimiento_id = (int)HttpContext.Session.GetInt32("EstablecimientoId");
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["categoria_id"] = new SelectList(_context.Set<categoria>(), "id", "nombre", producto.categoria_id);
            ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "nombreComercial", producto.establecimiento_id);
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", producto.estados_id);
            ViewData["tipoProducto_id"] = new SelectList(_context.Set<tipoProducto>(), "id", "nombre", producto.tipoProducto_id);
            return View(producto);
        }

        // GET: Producto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            int EstablecimientoId = 0;

            if (HttpContext.Session.Get("EstablecimientoId") != null)
            {
                EstablecimientoId = (int)HttpContext.Session.GetInt32("EstablecimientoId");


                var producto = await _context.producto.FindAsync(id);
                if (producto == null)
                {
                    return NotFound();
                }
                ViewData["categoria_id"] = new SelectList(_context.Set<categoria>(), "id", "nombre", producto.categoria_id);
                ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "nombreComercial", producto.establecimiento_id);
                ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", producto.estados_id);
                ViewData["tipoProducto_id"] = new SelectList(_context.Set<tipoProducto>(), "id", "nombre", producto.tipoProducto_id);
                return View(producto);

                ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");


              
            }
            else
            {
                return Redirect("~/User/Login");
            }

        }

        // POST: Producto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nombre,descripcion,pathImagen,establecimiento_id,tipoProducto_id,categoria_id")] producto producto)
        {
           
            if (ModelState.IsValid)
            {
                try
                {
                    var _producto = _context.producto.Find(id);
                    if (_producto != null)
                    {
                        _producto.nombre = producto.nombre;
                        _producto.descripcion = producto.descripcion;
                        //_producto.establecimiento_id = producto.establecimiento_id;
                        _producto.tipoProducto_id = producto.tipoProducto_id;
                        _producto.categoria_id = producto.categoria_id;
                        _producto.usuarioActualizacion = "admin";
                        _producto.fechaActualizacion = System.DateTime.Now;
                        //_producto.estados_id = 1;
                        if (producto.pathImagen == String.Empty || producto.pathImagen == null)
                        {
                            _producto.pathImagen = "imagenes/productos/default.jpg";
                        }
                        _context.Update(_producto);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        return NotFound();
                    }
                   
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!productoExists(producto.id))
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
            ViewData["categoria_id"] = new SelectList(_context.Set<categoria>(), "id", "nombre", producto.categoria_id);
            ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "nombreComercial", producto.establecimiento_id);
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", producto.estados_id);
            ViewData["tipoProducto_id"] = new SelectList(_context.Set<tipoProducto>(), "id", "nombre", producto.tipoProducto_id);
            return View(producto);
        }

        // GET: Producto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.producto
                .Include(p => p.categoria)
                .Include(p => p.establecimiento)
                .Include(p => p.estados)
                .Include(p => p.tipoProducto)
                .FirstOrDefaultAsync(m => m.id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           // var producto = await _context.producto.FindAsync(id);
           // _context.producto.Remove(producto);


            var producto = await _context.producto.FindAsync(id);

            if (producto.estados_id == 1)
            {
                producto.estados_id = 2;
            }
            else
            {
                producto.estados_id = 1;
            }

            _context.producto.Update(producto);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool productoExists(int id)
        {
            return _context.producto.Any(e => e.id == id);
        }



        //Mostar un producto especifico del establecimiento por id
        public async Task<IActionResult> ProductoEstablecimiento(int ProductoId)
        {

            var _producto = _context.producto
                                    .Where(x => x.id == ProductoId)
                                    .SelectMany(s => s.stock.Where(s1 => s1.estados_id == 1), (x, s) => new productoVM
                                    {
                                        id = x.id,
                                        nombre = x.nombre,
                                        nombreCategoria = x.categoria.nombre,
                                        descripcion = x.descripcion,
                                        pathImagen = x.pathImagen,
                                        precioVenta = s.precioVenta,
                                        nombreEstablecimiento = x.establecimiento.nombreComercial,
                                        idEstablecimiento = x.establecimiento_id,
                                        pathEstablecimientoImagen = x.establecimiento.pathImagen

                                    });

            return View(await _producto.FirstOrDefaultAsync());
        }



    }
}
