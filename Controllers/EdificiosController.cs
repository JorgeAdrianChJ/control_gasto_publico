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
    public class EdificiosController : Controller
    {
        private readonly Control_Gasto_PublicoContext _context;

        public EdificiosController(Control_Gasto_PublicoContext context)
        {
            _context = context;
        }

        // GET: Edificios
        public async Task<IActionResult> Index()
        {
            return _context.Edificio != null ?
                        View(await _context.Edificio.ToListAsync()) :
                        Problem("Entity set 'Control_Gasto_PublicoContext.Edificio'  is null.");
        }

        // GET: Edificios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Edificio == null)
            {
                return NotFound();
            }

            var edificio = await _context.Edificio
                .FirstOrDefaultAsync(m => m.id == id);
            if (edificio == null)
            {
                return NotFound();
            }

            return View(edificio);
        }

        // GET: Edificios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Edificios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nombre,cantidad_personas,fecha_alquiler,id_provincia,id_canton,id_destrito,tipo_edificio,fecha_final_alquiler")] Edificio edificio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(edificio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(edificio);
        }

        // GET: Edificios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Edificio == null)
            {
                return NotFound();
            }

            var edificio = await _context.Edificio.FindAsync(id);
            if (edificio == null)
            {
                return NotFound();
            }
            return View(edificio);
        }

        // POST: Edificios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nombre,cantidad_personas,fecha_alquiler,id_provincia,id_canton,id_destrito,tipo_edificio,fecha_final_alquiler")] Edificio edificio)
        {
            if (id != edificio.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(edificio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EdificioExists(edificio.id))
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
            return View(edificio);
        }

        // GET: Edificios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Edificio == null)
            {
                return NotFound();
            }

            var edificio = await _context.Edificio
                .FirstOrDefaultAsync(m => m.id == id);
            if (edificio == null)
            {
                return NotFound();
            }

            return View(edificio);
        }

        // POST: Edificios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Edificio == null)
            {
                return Problem("Entity set 'Control_Gasto_PublicoContext.Edificio'  is null.");
            }
            var edificio = await _context.Edificio.FindAsync(id);
            if (edificio != null)
            {
                _context.Edificio.Remove(edificio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EdificioExists(int id)
        {
            return (_context.Edificio?.Any(e => e.id == id)).GetValueOrDefault();
        }

        public async Task<IActionResult> Add_Service(int? id)
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
            if (id == null || _context.Edificio == null)
            {
                return NotFound();
            }

            var edificio = await _context.Edificio
                .FirstOrDefaultAsync(m => m.id == id);



           var servicios = await _context.Servicio.Where(servicio =>
                _context.agregar_servicio.Any(agregarServicio => agregarServicio.id_edificio == edificio.id && agregarServicio.id_servicio == servicio.id)
            )
            .ToListAsync();
            var agregar_servicio = new Agregar_servicio();

            ViewBag.Servicios = servicios;
            var listaServicios  = await _context.Servicio.ToListAsync();
            ViewBag.NewServicios = new SelectList(listaServicios, "id", "nombre");
            if (edificio == null)
            {
                return NotFound();
            }
            return View(agregar_servicio);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add_Service(int id, [Bind("id_edificio,id_servicio,fecha_servicio")] Agregar_servicio agregar_servicio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agregar_servicio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agregar_servicio);
        }
    }
}
