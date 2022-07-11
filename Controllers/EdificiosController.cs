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
            List<SelectListItem> provincias = new()
            {
                new SelectListItem { Value = "1", Text = "San José" },
                new SelectListItem { Value = "2", Text = "Alajuela" },
                new SelectListItem { Value = "3", Text = "Heredia" },
                new SelectListItem { Value = "4", Text = "Cartago" },
                new SelectListItem { Value = "5", Text = "Puntarenas" },
                new SelectListItem { Value = "6", Text = "Guanacaste" },
                new SelectListItem { Value = "7", Text = "Limon" },
            };

            ViewBag.Provincias = provincias;
            List<SelectListItem> cantones = new()
            {
                new SelectListItem { Value = "1", Text = "San José" },
                new SelectListItem { Value = "2", Text = "Talamanca" },
                new SelectListItem { Value = "3", Text = "Buenos Aires" },
                new SelectListItem { Value = "4", Text = "Pococí" },
                new SelectListItem { Value = "5", Text = "Sarapiquí" },
                new SelectListItem { Value = "6", Text = "Osa" },
                new SelectListItem { Value = "7", Text = "Pérez Zeledón" },
            };

            ViewBag.Cantones = cantones;
            List<SelectListItem> distritos = new()
            {
                new SelectListItem { Value = "1", Text = "Carmen" },
                new SelectListItem { Value = "2", Text = "Merced" },
                new SelectListItem { Value = "3", Text = "Hospital" },
                new SelectListItem { Value = "4", Text = "Catedral" },
                new SelectListItem { Value = "5", Text = "Zapote" },
                new SelectListItem { Value = "6", Text = "La Uruca" },
            };

            ViewBag.Distritos = distritos;

            List<SelectListItem> tipos = new()
            {
                new SelectListItem { Value = "1", Text = "Adquirido" },
                new SelectListItem { Value = "2", Text = "Alquilado" },
            };
            ViewBag.TipoEdificio = tipos;
            return _context.Edificio != null ?
                        View(await _context.Edificio.ToListAsync()) :
                        Problem("Entity set 'Control_Gasto_PublicoContext.Edificio'  is null.");
        }

        // GET: Edificios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            List<SelectListItem> provincias = new()
            {
                new SelectListItem { Value = "1", Text = "San José" },
                new SelectListItem { Value = "2", Text = "Alajuela" },
                new SelectListItem { Value = "3", Text = "Heredia" },
                new SelectListItem { Value = "4", Text = "Cartago" },
                new SelectListItem { Value = "5", Text = "Puntarenas" },
                new SelectListItem { Value = "6", Text = "Guanacaste" },
                new SelectListItem { Value = "7", Text = "Limon" },
            };

            ViewBag.Provincias = provincias;
            List<SelectListItem> cantones = new()
            {
                new SelectListItem { Value = "1", Text = "San José" },
                new SelectListItem { Value = "2", Text = "Talamanca" },
                new SelectListItem { Value = "3", Text = "Buenos Aires" },
                new SelectListItem { Value = "4", Text = "Pococí" },
                new SelectListItem { Value = "5", Text = "Sarapiquí" },
                new SelectListItem { Value = "6", Text = "Osa" },
                new SelectListItem { Value = "7", Text = "Pérez Zeledón" },
            };

            ViewBag.Cantones = cantones;
            List<SelectListItem> distritos = new()
            {
                new SelectListItem { Value = "1", Text = "Carmen" },
                new SelectListItem { Value = "2", Text = "Merced" },
                new SelectListItem { Value = "3", Text = "Hospital" },
                new SelectListItem { Value = "4", Text = "Catedral" },
                new SelectListItem { Value = "5", Text = "Zapote" },
                new SelectListItem { Value = "6", Text = "La Uruca" },
            };

            ViewBag.Distritos = distritos;

            List<SelectListItem> tipos = new()
            {
                new SelectListItem { Value = "1", Text = "Adquirido" },
                new SelectListItem { Value = "2", Text = "Alquilado" },
            };
            ViewBag.TipoEdificio = tipos;
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
            List<SelectListItem> provincias = new()
            {
                new SelectListItem { Value = "1", Text = "San José" },
                new SelectListItem { Value = "2", Text = "Alajuela" },
                new SelectListItem { Value = "3", Text = "Heredia" },
                new SelectListItem { Value = "4", Text = "Cartago" },
                new SelectListItem { Value = "5", Text = "Puntarenas" },
                new SelectListItem { Value = "6", Text = "Guanacaste" },
                new SelectListItem { Value = "7", Text = "Limon" },
            };

            ViewBag.Provincias = provincias;
            List<SelectListItem> cantones = new()
            {
                new SelectListItem { Value = "1", Text = "San José" },
                new SelectListItem { Value = "2", Text = "Talamanca" },
                new SelectListItem { Value = "3", Text = "Buenos Aires" },
                new SelectListItem { Value = "4", Text = "Pococí" },
                new SelectListItem { Value = "5", Text = "Sarapiquí" },
                new SelectListItem { Value = "6", Text = "Osa" },
                new SelectListItem { Value = "7", Text = "Pérez Zeledón" },
            };

            ViewBag.Cantones = cantones;
            List<SelectListItem> distritos = new()
            {
                new SelectListItem { Value = "1", Text = "Carmen" },
                new SelectListItem { Value = "2", Text = "Merced" },
                new SelectListItem { Value = "3", Text = "Hospital" },
                new SelectListItem { Value = "4", Text = "Catedral" },
                new SelectListItem { Value = "5", Text = "Zapote" },
                new SelectListItem { Value = "6", Text = "La Uruca" },
            };

            ViewBag.Distritos = distritos;

            List<SelectListItem> tipos = new()
            {
                new SelectListItem { Value = "1", Text = "Adquirido" },
                new SelectListItem { Value = "2", Text = "Alquilado" },
            };
            ViewBag.TipoEdificio = tipos;
            return View();
        }

        // POST: Edificios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nombre,cantidad_personas,fecha_alquiler,id_provincia,id_canton,id_destrito,tipo_edificio,fecha_final_alquiler")] Edificio edificio)
        {
            List<SelectListItem> provincias = new()
            {
                new SelectListItem { Value = "1", Text = "San José" },
                new SelectListItem { Value = "2", Text = "Alajuela" },
                new SelectListItem { Value = "3", Text = "Heredia" },
                new SelectListItem { Value = "4", Text = "Cartago" },
                new SelectListItem { Value = "5", Text = "Puntarenas" },
                new SelectListItem { Value = "6", Text = "Guanacaste" },
                new SelectListItem { Value = "7", Text = "Limon" },
            };

            ViewBag.Provincias = provincias;
            List<SelectListItem> cantones = new()
            {
                new SelectListItem { Value = "1", Text = "San José" },
                new SelectListItem { Value = "2", Text = "Talamanca" },
                new SelectListItem { Value = "3", Text = "Buenos Aires" },
                new SelectListItem { Value = "4", Text = "Pococí" },
                new SelectListItem { Value = "5", Text = "Sarapiquí" },
                new SelectListItem { Value = "6", Text = "Osa" },
                new SelectListItem { Value = "7", Text = "Pérez Zeledón" },
            };

            ViewBag.Cantones = cantones;
            List<SelectListItem> distritos = new()
            {
                new SelectListItem { Value = "1", Text = "Carmen" },
                new SelectListItem { Value = "2", Text = "Merced" },
                new SelectListItem { Value = "3", Text = "Hospital" },
                new SelectListItem { Value = "4", Text = "Catedral" },
                new SelectListItem { Value = "5", Text = "Zapote" },
                new SelectListItem { Value = "6", Text = "La Uruca" },
            };

            ViewBag.Distritos = distritos;

            List<SelectListItem> tipos = new()
            {
                new SelectListItem { Value = "1", Text = "Adquirido" },
                new SelectListItem { Value = "2", Text = "Alquilado" },
            };
            ViewBag.TipoEdificio = tipos;
            if (ModelState.IsValid)
            {
                _context.Edificio.Add(edificio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(edificio);
        }

        // GET: Edificios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            List<SelectListItem> provincias = new()
            {
                new SelectListItem { Value = "1", Text = "San José" },
                new SelectListItem { Value = "2", Text = "Alajuela" },
                new SelectListItem { Value = "3", Text = "Heredia" },
                new SelectListItem { Value = "4", Text = "Cartago" },
                new SelectListItem { Value = "5", Text = "Puntarenas" },
                new SelectListItem { Value = "6", Text = "Guanacaste" },
                new SelectListItem { Value = "7", Text = "Limon" },
            };

            ViewBag.Provincias = provincias;
            List<SelectListItem> cantones = new()
            {
                new SelectListItem { Value = "1", Text = "San José" },
                new SelectListItem { Value = "2", Text = "Talamanca" },
                new SelectListItem { Value = "3", Text = "Buenos Aires" },
                new SelectListItem { Value = "4", Text = "Pococí" },
                new SelectListItem { Value = "5", Text = "Sarapiquí" },
                new SelectListItem { Value = "6", Text = "Osa" },
                new SelectListItem { Value = "7", Text = "Pérez Zeledón" },
            };

            ViewBag.Cantones = cantones;
            List<SelectListItem> distritos = new()
            {
                new SelectListItem { Value = "1", Text = "Carmen" },
                new SelectListItem { Value = "2", Text = "Merced" },
                new SelectListItem { Value = "3", Text = "Hospital" },
                new SelectListItem { Value = "4", Text = "Catedral" },
                new SelectListItem { Value = "5", Text = "Zapote" },
                new SelectListItem { Value = "6", Text = "La Uruca" },
            };

            ViewBag.Distritos = distritos;

            List<SelectListItem> tipos = new()
            {
                new SelectListItem { Value = "1", Text = "Adquirido" },
                new SelectListItem { Value = "2", Text = "Alquilado" },
            };
            ViewBag.TipoEdificio = tipos;
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
            List<SelectListItem> provincias = new()
            {
                new SelectListItem { Value = "1", Text = "San José" },
                new SelectListItem { Value = "2", Text = "Alajuela" },
                new SelectListItem { Value = "3", Text = "Heredia" },
                new SelectListItem { Value = "4", Text = "Cartago" },
                new SelectListItem { Value = "5", Text = "Puntarenas" },
                new SelectListItem { Value = "6", Text = "Guanacaste" },
                new SelectListItem { Value = "7", Text = "Limon" },
            };

            ViewBag.Provincias = provincias;
            List<SelectListItem> cantones = new()
            {
                new SelectListItem { Value = "1", Text = "San José" },
                new SelectListItem { Value = "2", Text = "Talamanca" },
                new SelectListItem { Value = "3", Text = "Buenos Aires" },
                new SelectListItem { Value = "4", Text = "Pococí" },
                new SelectListItem { Value = "5", Text = "Sarapiquí" },
                new SelectListItem { Value = "6", Text = "Osa" },
                new SelectListItem { Value = "7", Text = "Pérez Zeledón" },
            };

            ViewBag.Cantones = cantones;
            List<SelectListItem> distritos = new()
            {
                new SelectListItem { Value = "1", Text = "Carmen" },
                new SelectListItem { Value = "2", Text = "Merced" },
                new SelectListItem { Value = "3", Text = "Hospital" },
                new SelectListItem { Value = "4", Text = "Catedral" },
                new SelectListItem { Value = "5", Text = "Zapote" },
                new SelectListItem { Value = "6", Text = "La Uruca" },
            };

            ViewBag.Distritos = distritos;

            List<SelectListItem> tipos = new()
            {
                new SelectListItem { Value = "1", Text = "Adquirido" },
                new SelectListItem { Value = "2", Text = "Alquilado" },
            };
            ViewBag.TipoEdificio = tipos;
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

        public async Task<IActionResult> Add_Service(int? id, int? filter)
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
                 _context.Agregar_servicio.Any(agregarServicio => agregarServicio.id_edificio == edificio.id && agregarServicio.id_servicio == servicio.id)
             )
             .ToListAsync();
            var agregar_servicio = new Agregar_servicio();
            agregar_servicio.id_edificio = edificio.id;
            ViewBag.Servicios = servicios;
            if (filter != null) { 
            var listaServicios = await _context.Servicio.Where(x =>x.tipo_servicio_id == filter).ToListAsync();
            ViewBag.NewServicios = new SelectList(listaServicios, "id", "nombre");
            }
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

            if (agregar_servicio.id_edificio == null)
            {
                return NotFound();
            }

            var edificio = await _context.Edificio
                .FirstOrDefaultAsync(m => m.id == agregar_servicio.id_edificio);


            var servicios = await _context.Servicio.Where(servicio =>
                 _context.Agregar_servicio.Any(agregarServicio => agregarServicio.id_edificio == edificio.id && agregarServicio.id_servicio == servicio.id)
             )
             .ToListAsync();

            ViewBag.Servicios = servicios;

            if (ModelState.IsValid)
            {
                _context.Agregar_servicio.Add(agregar_servicio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agregar_servicio);
        }
        [HttpGet]
        public async Task<IActionResult> Delete2(int id)
        {
            var addservices = await _context.Agregar_servicio.FindAsync(id);
            if (addservices != null)
            {
                _context.Agregar_servicio.Remove(addservices);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        [Produces("application/json")]
        public JsonResult ObtenerServicios(int tipo)
        {
            return Json(new { });
        }
        [HttpGet]
        [Produces("application/json")]
        public JsonResult ObtenerCantones(int codProvincia)
        {
            return Json(new { });
        }

        [HttpGet]
        [Produces("application/json")]
        public JsonResult ObtenerDistritos(int codCanton)
        {
            return Json(new { });
        }
    }
}
