using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CG_P.Models;
using Control_Gasto_Publico.Data;

namespace Control_Gasto_Publico.Controllers
{
    public class ServiciosController : Controller
    {
        private readonly Control_Gasto_PublicoContext _context;

        public ServiciosController(Control_Gasto_PublicoContext context)
        {
            _context = context;
        }

        // GET: Servicios
        public async Task<IActionResult> Index()
        {
            List<SelectListItem> tiposServicios = new()
            {
                new SelectListItem { Value = "1", Text = "Agua" },
                new SelectListItem { Value = "2", Text = "Luz" },
                new SelectListItem { Value = "3", Text = "Telefonía" },
                new SelectListItem { Value = "4", Text = "Cable" },
                new SelectListItem { Value = "5", Text = "internet" },
            };
            List<SelectListItem> unidadMedida = new()
            {
                new SelectListItem { Value = "1", Text = "Megas" },
                new SelectListItem { Value = "2", Text = "Watts" },
                new SelectListItem { Value = "3", Text = "Litros" },
                new SelectListItem { Value = "4", Text = "minutos" },
            };

            ViewBag.TiposServicios = tiposServicios;
            ViewBag.UnidadMedida = unidadMedida;
            return _context.Servicio != null ? 
                          View(await _context.Servicio.ToListAsync()) :
                          Problem("Entity set 'Control_Gasto_PublicoContext.Servicio'  is null.");
        }

        // GET: Servicios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            List<SelectListItem> tiposServicios = new()
            {
                new SelectListItem { Value = "1", Text = "Agua" },
                new SelectListItem { Value = "2", Text = "Luz" },
                new SelectListItem { Value = "3", Text = "Telefonía" },
                new SelectListItem { Value = "4", Text = "Cable" },
                new SelectListItem { Value = "5", Text = "internet" },
            };
            List<SelectListItem> unidadMedida = new()
            {
                new SelectListItem { Value = "1", Text = "Megas" },
                new SelectListItem { Value = "2", Text = "Watts" },
                new SelectListItem { Value = "3", Text = "Litros" },
                new SelectListItem { Value = "4", Text = "minutos" },
            };

            ViewBag.TiposServicios = tiposServicios;
            ViewBag.UnidadMedida = unidadMedida;
            if (id == null || _context.Servicio == null)
            {
                return NotFound();
            }

            var servicio = await _context.Servicio
                .FirstOrDefaultAsync(m => m.id == id);
            if (servicio == null)
            {
                return NotFound();
            }

            return View(servicio);
        }

        // GET: Servicios/Create
        public IActionResult Create()
        {
  
            List<SelectListItem> tiposServicios = new()
            {
                new SelectListItem { Value = "1", Text = "Agua" },
                new SelectListItem { Value = "2", Text = "Luz" },
                new SelectListItem { Value = "3", Text = "Telefonía" },
                new SelectListItem { Value = "4", Text = "Cable" },
                new SelectListItem { Value = "5", Text = "internet" },
            };
            List<SelectListItem> unidadMedida = new()
            {
                new SelectListItem { Value = "1", Text = "Megas" },
                new SelectListItem { Value = "2", Text = "Watts" },
                new SelectListItem { Value = "3", Text = "Litros" },
                new SelectListItem { Value = "4", Text = "minutos" },
            };

            ViewBag.TiposServicios = tiposServicios;
            ViewBag.UnidadMedida = unidadMedida;
            // ViewBag.TiposServicios = new SelectList(_context.Tipo_Servicio.ToList(), "id", "nombre");
            //ViewBag.Unidad_Medida = new SelectList(_context.Unidad_Medida.ToList(), "id", "nombre");
            return View();
        }

        // POST: Servicios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nombre,nombre_empresa,tipo_servicio_id,unidad_medida_id")] Servicio servicio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(servicio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(servicio);
        }

        // GET: Servicios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            List<SelectListItem> tiposServicios = new()
            {
                new SelectListItem { Value = "1", Text = "Agua" },
                new SelectListItem { Value = "2", Text = "Luz" },
                new SelectListItem { Value = "3", Text = "Telefonía" },
                new SelectListItem { Value = "4", Text = "Cable" },
                new SelectListItem { Value = "5", Text = "internet" },
            };
            List<SelectListItem> unidadMedida = new()
            {
                new SelectListItem { Value = "1", Text = "Megas" },
                new SelectListItem { Value = "2", Text = "Watts" },
                new SelectListItem { Value = "3", Text = "Litros" },
                new SelectListItem { Value = "4", Text = "minutos" },
            };

            ViewBag.TiposServicios = tiposServicios;
            ViewBag.UnidadMedida = unidadMedida;
            if (id == null || _context.Servicio == null)
            {
                return NotFound();
            }

            var servicio = await _context.Servicio.FindAsync(id);
            if (servicio == null)
            {
                return NotFound();
            }
            return View(servicio);
        }

        // POST: Servicios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nombre,nombre_empresa,tipo_servicio_id,unidad_medida_id")] Servicio servicio)
        {
            if (id != servicio.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServicioExists(servicio.id))
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
            return View(servicio);
        }

        // GET: Servicios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            List<SelectListItem> tiposServicios = new()
            {
                new SelectListItem { Value = "1", Text = "Agua" },
                new SelectListItem { Value = "2", Text = "Luz" },
                new SelectListItem { Value = "3", Text = "Telefonía" },
                new SelectListItem { Value = "4", Text = "Cable" },
                new SelectListItem { Value = "5", Text = "internet" },
            };
            List<SelectListItem> unidadMedida = new()
            {
                new SelectListItem { Value = "1", Text = "Megas" },
                new SelectListItem { Value = "2", Text = "Watts" },
                new SelectListItem { Value = "3", Text = "Litros" },
                new SelectListItem { Value = "4", Text = "minutos" },
            };

            ViewBag.TiposServicios = tiposServicios;
            ViewBag.UnidadMedida = unidadMedida;
            if (id == null || _context.Servicio == null)
            {
                return NotFound();
            }

            var servicio = await _context.Servicio
                .FirstOrDefaultAsync(m => m.id == id);
            if (servicio == null)
            {
                return NotFound();
            }

            return View(servicio);
        }

        // POST: Servicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Servicio == null)
            {
                return Problem("Entity set 'Control_Gasto_PublicoContext.Servicio'  is null.");
            }
            var servicio = await _context.Servicio.FindAsync(id);
            if (servicio != null)
            {
                _context.Servicio.Remove(servicio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServicioExists(int id)
        {
          return (_context.Servicio?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
