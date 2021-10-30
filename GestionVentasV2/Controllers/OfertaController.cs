using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionVentasV2.Data;
using GestionVentasV2.Models;

namespace GestionVentasV2.Controllers
{
    public class OfertaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OfertaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Oferta
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.oferta.Include(o => o.establecimiento).Include(o => o.estados);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Oferta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oferta = await _context.oferta
                .Include(o => o.establecimiento)
                .Include(o => o.estados)
                .FirstOrDefaultAsync(m => m.id == id);
            if (oferta == null)
            {
                return NotFound();
            }

            return View(oferta);
        }

        // GET: Oferta/Create
        public IActionResult Create()
        {
            ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "nombreComercial");
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre");
            return View();
        }

        // POST: Oferta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nombre,descripcion,imagen,fechaApertura,fechaCierre, estados_id, establecimiento_id, porcentajeDescuento,usuarioCreacion,fechaCreacion,usuarioActualizacion,fechaActualizacion")] oferta oferta)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(oferta);
                //await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                var correlativo = _context.oferta.Select(x => x.id).ToList();
                if (correlativo.Count() > 0)
                {
                    oferta.id = correlativo.Max() + 1;
                }
                else
                {
                    oferta.id = 1;
                }

                oferta.fechaCreacion = System.DateTime.Now;
                oferta.usuarioCreacion = "admin";
                oferta.estados_id = 1;
                _context.Add(oferta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "nombreComercial", oferta.establecimiento_id);
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", oferta.estados_id);
            return View(oferta);
        }

        // GET: Oferta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oferta = await _context.oferta.FindAsync(id);
            if (oferta == null)
            {
                return NotFound();
            }
            ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "nombreComercial", oferta.establecimiento_id);
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", oferta.estados_id);
            return View(oferta);
        }

        // POST: Oferta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nombre,descripcion,imagen,fechaApertura,fechaCierre, porcentajeDescuento, establecimiento_id")] oferta oferta)
        {
            if (id != oferta.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var _oferta = _context.oferta.Find(id);
                    if (_oferta != null)
                    {
                        _oferta.nombre = oferta.nombre;
                        _oferta.descripcion = oferta.descripcion;
                        _oferta.imagen = oferta.imagen;
                        _oferta.fechaApertura = oferta.fechaApertura;
                        _oferta.fechaCierre = oferta.fechaCierre;
                        _oferta.porcentajeDescuento = oferta.porcentajeDescuento;
                        _oferta.fechaActualizacion = System.DateTime.Now;
                        _oferta.usuarioActualizacion = "admin";
                        _context.Update(_oferta);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ofertaExists(oferta.id))
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
            ViewData["establecimiento_id"] = new SelectList(_context.establecimiento, "id", "nombreComercial", oferta.establecimiento_id);
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", oferta.estados_id);
            return View(oferta);
        }

        // GET: Oferta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oferta = await _context.oferta
                .Include(o => o.establecimiento)
                .Include(o => o.estados)
                .FirstOrDefaultAsync(m => m.id == id);
            if (oferta == null)
            {
                return NotFound();
            }

            return View(oferta);
        }

        // POST: Oferta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var oferta = await _context.oferta.FindAsync(id);
            if (oferta.estados_id == 1)
            {
                oferta.estados_id = 2;
            }
            else
            {
                oferta.estados_id = 1;
            }

            _context.oferta.Update(oferta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ofertaExists(int id)
        {
            return _context.oferta.Any(e => e.id == id);
        }
    }
}
