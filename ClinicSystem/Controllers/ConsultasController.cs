using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicSystem.Data;
using ClinicSystem.Models;

namespace ClinicSystem.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly SystemClinicContext _context;

        public ConsultasController(SystemClinicContext context)
        {
            _context = context;
        }

        // GET: Consultas
        public async Task<IActionResult> Index()
        {
            var systemClinicContext = _context.Consultas.Include(c => c.Medico).Include(c => c.Paciente).Include(c => c.Tipo);
            return View(await systemClinicContext.ToListAsync());
        }

        // GET: Consultas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .Include(c => c.Medico)
                .Include(c => c.Paciente)
                .Include(c => c.Tipo)
                .FirstOrDefaultAsync(m => m.ConsultaId == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // GET: Consultas/Create
        public IActionResult Create()
        {
            ViewData["NumMatricula"] = new SelectList(_context.Medicos, "NumMatricula", "NumMatricula");
            ViewData["NumHistoriaClinica"] = new SelectList(_context.Pacientes, "NumHistoriaClinica", "NumHistoriaClinica");
            ViewData["TipoId"] = new SelectList(_context.Tipos, "TipoId", "TipoId");
            return View();
        }

        // POST: Consultas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConsultaId,NumMatricula,NumHistoriaClinica,TipoId,Fecha,Costo,CostoMatDescartable,Descripcion,Active")] Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consulta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NumMatricula"] = new SelectList(_context.Medicos, "NumMatricula", "NumMatricula", consulta.NumMatricula);
            ViewData["NumHistoriaClinica"] = new SelectList(_context.Pacientes, "NumHistoriaClinica", "NumHistoriaClinica", consulta.NumHistoriaClinica);
            ViewData["TipoId"] = new SelectList(_context.Tipos, "TipoId", "TipoId", consulta.TipoId);
            return View(consulta);
        }

        // GET: Consultas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta == null)
            {
                return NotFound();
            }
            ViewData["NumMatricula"] = new SelectList(_context.Medicos, "NumMatricula", "NumMatricula", consulta.NumMatricula);
            ViewData["NumHistoriaClinica"] = new SelectList(_context.Pacientes, "NumHistoriaClinica", "NumHistoriaClinica", consulta.NumHistoriaClinica);
            ViewData["TipoId"] = new SelectList(_context.Tipos, "TipoId", "TipoId", consulta.TipoId);
            return View(consulta);
        }

        // POST: Consultas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ConsultaId,NumMatricula,NumHistoriaClinica,TipoId,Fecha,Costo,CostoMatDescartable,Descripcion,Active")] Consulta consulta)
        {
            if (id != consulta.ConsultaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consulta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultaExists(consulta.ConsultaId))
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
            ViewData["NumMatricula"] = new SelectList(_context.Medicos, "NumMatricula", "NumMatricula", consulta.NumMatricula);
            ViewData["NumHistoriaClinica"] = new SelectList(_context.Pacientes, "NumHistoriaClinica", "NumHistoriaClinica", consulta.NumHistoriaClinica);
            ViewData["TipoId"] = new SelectList(_context.Tipos, "TipoId", "TipoId", consulta.TipoId);
            return View(consulta);
        }

        // GET: Consultas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .Include(c => c.Medico)
                .Include(c => c.Paciente)
                .Include(c => c.Tipo)
                .FirstOrDefaultAsync(m => m.ConsultaId == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // POST: Consultas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consulta = await _context.Consultas.FindAsync(id);
            _context.Consultas.Remove(consulta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultaExists(int id)
        {
            return _context.Consultas.Any(e => e.ConsultaId == id);
        }
    }
}
