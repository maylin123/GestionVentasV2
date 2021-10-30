using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionVentasV2.Data;
using GestionVentasV2.Models;
using Microsoft.AspNetCore.Authorization;

namespace GestionVentasV2.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClienteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cliente
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.cliente.Include(c => c.estados);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Cliente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.cliente
                .Include(c => c.estados)
                .FirstOrDefaultAsync(m => m.id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Cliente/Create
        public IActionResult Create()
        {
            //ViewData["estado_id"] = new SelectList(_context.estados, "id", "nombre");
            return View();

            var viewModel = new cliente
            {
                fechaCreacion = System.DateTime.Now,
                estados_id = 1,
                usuarioCreacion = "admin"

            };
            return View(viewModel);
        }

        // POST: Cliente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nombre,apellido,telefono,direccion,correoElectronico")] cliente cliente)
        {
            if (ModelState.IsValid)
            {
                //Generar el correlativo
                var correlativo = _context.cliente.Select(x => x.id).ToList();
                if (correlativo.Count() > 0)
                {
                    cliente.id = correlativo.Max() + 1;
                }
                else
                {
                    cliente.id = 1;
                }
                cliente.fechaCreacion = System.DateTime.Now;
                cliente.usuarioCreacion = "admin";
                cliente.estados_id = 1;
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["estado_id"] = new SelectList(_context.estados, "id", "nombre", cliente.estado_id);
            return View(cliente);
        }

        // GET: Cliente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", cliente.estados_id);
            return View(cliente);
        }

        // POST: Cliente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nombre,apellido,telefono,direccion,correoElectronico")] cliente cliente)
        {
            if (id != cliente.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    cliente.fechaActualizacion = System.DateTime.Now;
                    cliente.usuarioActualizacion = "admin";
                    cliente.estados_id = 1;
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!clienteExists(cliente.id))
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
            //ViewData["estados_id"] = new SelectList(_context.estados, "id", "nombre", cliente.estados_id);
            return View(cliente);
        }

        // GET: Cliente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.cliente
                .Include(c => c.estados)
                .FirstOrDefaultAsync(m => m.id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.cliente.FindAsync(id);
            if (cliente.estados_id == 1)
            {
                cliente.estados_id = 2;
            }
            else
            {
                cliente.estados_id = 1;
            }
            _context.cliente.Update(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool clienteExists(int id)
        {
            return _context.cliente.Any(e => e.id == id);
        }
    }
}
