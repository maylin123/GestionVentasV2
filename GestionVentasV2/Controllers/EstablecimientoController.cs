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
    public class EstablecimientoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstablecimientoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Establecimiento
        public async Task<IActionResult> Index()
        {
            return View(await _context.establecimiento.ToListAsync());
        }

        // GET: Establecimiento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var establecimiento = await _context.establecimiento
                .Include(c => c.estados)
                .FirstOrDefaultAsync(m => m.id == id);
            if (establecimiento == null)
            {
                return NotFound();
            }

            return View(establecimiento);
        }

        // GET: Establecimiento/Create
        public IActionResult Create()
        {
            ViewData["tipoEstablecimiento_id"] = new SelectList(_context.Set<tipoEstablecimiento>(), "id", "nombre");

            var viewModel = new establecimiento {
                fechaCreacion = System.DateTime.Now,
                estados_id = 1,
                usuarioCreacion = "admin"
            
            };
            return View(viewModel);
        }

        // POST: Establecimiento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,razonSocial,nombreComercial,nit,correoElectronico,direccionFiscal,direccionMobiliaria,telefono, tipoEstablecimiento_id,pathImagen,estados_id, ,usuarioCreacion,fechaCreacion,usuarioActualizacion,fechaActualizacion, descripcionGeneral")] establecimiento establecimiento)
        {
            if (ModelState.IsValid)
            {
                //Generar el correlativo
                var correlativo = _context.establecimiento.Select(x => x.id).ToList();
                if(correlativo.Count() > 0)
                {
                    establecimiento.id = correlativo.Max() + 1;
                } else
                {
                    establecimiento.id = 1;
                }
                string path = "establecimientos/logos/default.jpg";

                if (!String.IsNullOrEmpty(establecimiento.pathImagen))
                {
                    path = establecimiento.pathImagen;
                }

                establecimiento.pathImagen = path;
                establecimiento.fechaCreacion = System.DateTime.Now;
                establecimiento.usuarioCreacion = "admin";
                establecimiento.estados_id = 1;
                _context.Add(establecimiento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(establecimiento);
        }

        // GET: Establecimiento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["tipoEstablecimiento_id"] = new SelectList(_context.Set<tipoEstablecimiento>(), "id", "nombre");
            var establecimiento = await _context.establecimiento.FindAsync(id);
            if (establecimiento == null)
            {
                return NotFound();
            }
            return View(establecimiento);
        }

        // POST: Establecimiento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,razonSocial,nombreComercial,nit,correoElectronico,direccionFiscal,direccionMobiliaria,telefono, pathImagen, tipoEstablecimiento_id, descripcionGeneral")] establecimiento establecimiento)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var estab = _context.establecimiento.Find(id);
                    if(estab!=null)
                    {
                        string path = "establecimientos/logos/default.jpg";

                        if (!String.IsNullOrEmpty(establecimiento.pathImagen))
                        {
                            path = establecimiento.pathImagen;
                        }

                        estab.tipoEstablecimiento_id = establecimiento.tipoEstablecimiento_id;
                        estab.pathImagen = path;
                        estab.razonSocial = establecimiento.razonSocial;
                        estab.nombreComercial = establecimiento.nombreComercial;
                        estab.nit = establecimiento.nit;
                        estab.correoElectronico = establecimiento.correoElectronico;
                        estab.direccionFiscal = establecimiento.direccionFiscal;
                        estab.direccionMobiliaria = establecimiento.direccionMobiliaria;
                        estab.telefono = establecimiento.telefono;
                        estab.descripcionGeneral = establecimiento.descripcionGeneral;
                        //estab.pathImagen = establecimiento.pathImagen;
                        estab.usuarioActualizacion = "admin";
                        estab.fechaActualizacion = System.DateTime.Now;
                        //estab.estados_id = 1;
                        _context.Update(estab);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!establecimientoExists(establecimiento.id))
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
            ViewData["tipoEstablecimiento_id"] = new SelectList(_context.Set<tipoEstablecimiento>(), "id", "nombre");

            return View(establecimiento);
        }

        // GET: Establecimiento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var establecimiento = await _context.establecimiento
                .FirstOrDefaultAsync(m => m.id == id);
            if (establecimiento == null)
            {
                return NotFound();
            }

            return View(establecimiento);
        }

        // POST: Establecimiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var establecimiento = await _context.establecimiento.FindAsync(id);

            if(establecimiento.estados_id == 1)
            {
                establecimiento.estados_id = 2;
            } else
            {
                establecimiento.estados_id = 1;
            }

            _context.establecimiento.Update(establecimiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool establecimientoExists(int id)
        {
            return _context.establecimiento.Any(e => e.id == id);
        }



        //Metodos publicos

        //Mostar la pantalla de inicio de un establecimiento
        public async Task<IActionResult> Home(int EstablecimientoId)
        {


            //Datos del establecimiento
            var _datosEstablecimiento = _context.establecimiento.Where(x => x.id == EstablecimientoId).FirstOrDefault();

            var _listaProductos = _context.producto
                                  .Where(x => x.estados_id == 1 && x.establecimiento_id == EstablecimientoId)
                                  .SelectMany(s => s.stock.Where(s1 => s1.estados_id==1), (x, s) => new productoVM
                                  {
                                      id = x.id,
                                      nombre = x.nombre,
                                      pathImagen = x.pathImagen,
                                      descripcion = x.descripcion,
                                      nombreCategoria = x.categoria.nombre,
                                      precioVenta = s.precioVenta,
                                  });


            ViewBag.datosEstablecimiento = _datosEstablecimiento;
            /*var _listaProductos = _context.producto.Where(x => x.estados_id == 1 && x.establecimiento_id == EstablecimientoId)
                .SelectMany(p => p.stock.DefaultIfEmpty(), (p, b) => new
                .Select(x => new productoVM
                {
                    id = x.id,
                    nombre = x.nombre,
                    pathImagen = x.pathImagen,
                    descripcion = x.descripcion,
                    nombreCategoria = x.categoria.nombre
                });*/

            return View(await _listaProductos.ToListAsync());
        }


    }
}
