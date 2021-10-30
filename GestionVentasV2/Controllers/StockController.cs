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

namespace GestionVentasV2.Controllers
{
    public class StockController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StockController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Obtener el precio y cantidad de un producto de stock
        [HttpGet]
        [Route("Stock/Producto/{ProductoId:int}")]
        public async Task<Respuesta> ObtenerProductoStock(int ProductoId)
        {
            try
            {
                //Hacer la consulta a stock
                var _producto = _context.stock.Where(x => x.producto_id == ProductoId)
                                              .Where(x => x.estados_id == 1)
                                              .Select(x => new
                                              {
                                                  x.id,
                                                  x.cantidad,
                                                  x.producto.nombre,
                                                  x.precioVenta
                                              })
                                              .FirstOrDefault();

                if(_producto != null)
                {
                    return new Respuesta
                    {
                        Status = 200,
                        Mensaje = "Se ha obtenido el producto del stock con exito",
                        Datos = _producto

                    };
                }

                return new Respuesta
                {
                    Status = 404,
                    Mensaje = "El producto se encuentra disponible",
                    Datos = null

                };

            } catch (Exception e)
            {
                return new Respuesta
                {
                    Status = 500,
                    Mensaje = "Ha ocurrido un error interno.",
                    Datos = null

                };
            }
            

        }

        // GET: Stock
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.stock.Include(s => s.detalleCompra).Include(s => s.detalleVenta).Include(s => s.estados).Include(s => s.producto);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Stock/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock = await _context.stock
                .Include(s => s.detalleCompra)
                .Include(s => s.detalleVenta)
                .Include(s => s.estados)
                .Include(s => s.producto)
                .FirstOrDefaultAsync(m => m.id == id);
            if (stock == null)
            {
                return NotFound();
            }

            return View(stock);
        }

        // GET: Stock/Create
        public IActionResult Create()
        {
            ViewData["detalleCompra_id"] = new SelectList(_context.detalleCompra, "id", "usuarioCreacion");
            ViewData["detalleVenta_id"] = new SelectList(_context.Set<detalleVenta>(), "id", "usuarioCreacion");
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre");
            ViewData["producto_id"] = new SelectList(_context.detalleCompra, "id", "usuarioCreacion");
            return View();
        }

        // POST: Stock/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,cantidad,precioVenta,usuarioCreacion,fechaCreacion,usuarioActualizacion,fechaActualizacion,estados_id,detalleVenta_id,detalleCompra_id,producto_id,cantidadEntrada,cantidadSalida")] stock stock)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["detalleCompra_id"] = new SelectList(_context.detalleCompra, "id", "usuarioCreacion", stock.detalleCompra_id);
            ViewData["detalleVenta_id"] = new SelectList(_context.Set<detalleVenta>(), "id", "usuarioCreacion", stock.detalleVenta_id);
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", stock.estados_id);
            ViewData["producto_id"] = new SelectList(_context.detalleCompra, "id", "usuarioCreacion", stock.producto_id);
            return View(stock);
        }

        // GET: Stock/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock = await _context.stock.FindAsync(id);
            if (stock == null)
            {
                return NotFound();
            }
            ViewData["detalleCompra_id"] = new SelectList(_context.detalleCompra, "id", "usuarioCreacion", stock.detalleCompra_id);
            ViewData["detalleVenta_id"] = new SelectList(_context.Set<detalleVenta>(), "id", "usuarioCreacion", stock.detalleVenta_id);
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", stock.estados_id);
            ViewData["producto_id"] = new SelectList(_context.detalleCompra, "id", "usuarioCreacion", stock.producto_id);
            return View(stock);
        }

        // POST: Stock/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,cantidad,precioVenta,usuarioCreacion,fechaCreacion,usuarioActualizacion,fechaActualizacion,estados_id,detalleVenta_id,detalleCompra_id,producto_id,cantidadEntrada,cantidadSalida")] stock stock)
        {
            if (id != stock.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!stockExists(stock.id))
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
            ViewData["detalleCompra_id"] = new SelectList(_context.detalleCompra, "id", "usuarioCreacion", stock.detalleCompra_id);
            ViewData["detalleVenta_id"] = new SelectList(_context.Set<detalleVenta>(), "id", "usuarioCreacion", stock.detalleVenta_id);
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", stock.estados_id);
            ViewData["producto_id"] = new SelectList(_context.detalleCompra, "id", "usuarioCreacion", stock.producto_id);
            return View(stock);
        }

        // GET: Stock/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock = await _context.stock
                .Include(s => s.detalleCompra)
                .Include(s => s.detalleVenta)
                .Include(s => s.estados)
                .Include(s => s.producto)
                .FirstOrDefaultAsync(m => m.id == id);
            if (stock == null)
            {
                return NotFound();
            }

            return View(stock);
        }

        // POST: Stock/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stock = await _context.stock.FindAsync(id);
            _context.stock.Remove(stock);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool stockExists(int id)
        {
            return _context.stock.Any(e => e.id == id);
        }
    }
}
