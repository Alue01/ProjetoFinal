using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalAlue.Models;

namespace ProjetoFinalAlue.Controllers
{
    public class ProcedimentosController : Controller
    {
        private readonly Contexto _context;

        public ProcedimentosController(Contexto context)
        {
            _context = context;
        }

        // GET: Procedimentos
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Procedimentos.Include(p => p.TipoProcedimento);
            return View(await contexto.ToListAsync());
        }

        // GET: Procedimentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Procedimentos == null)
            {
                return NotFound();
            }

            var procedimentos = await _context.Procedimentos
                .Include(p => p.TipoProcedimento)
                .FirstOrDefaultAsync(m => m.ProcedimentosId == id);
            if (procedimentos == null)
            {
                return NotFound();
            }

            return View(procedimentos);
        }

        // GET: Procedimentos/Create
        public IActionResult Create()
        {
            ViewData["TipoProcedimentoId"] = new SelectList(_context.TipoProcedimento, "Id", "TipoProcedimentoNome");
            return View();
        }

        // POST: Procedimentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProcedimentosId,ProcedimentoNome,ProcedimentoObservacao,TipoProcedimentoId")] Procedimentos procedimentos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(procedimentos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoProcedimentoId"] = new SelectList(_context.TipoProcedimento, "Id", "TipoProcedimentoNome", procedimentos.TipoProcedimentoId);
            return View(procedimentos);
        }

        // GET: Procedimentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Procedimentos == null)
            {
                return NotFound();
            }

            var procedimentos = await _context.Procedimentos.FindAsync(id);
            if (procedimentos == null)
            {
                return NotFound();
            }
            ViewData["TipoProcedimentoId"] = new SelectList(_context.TipoProcedimento, "Id", "TipoProcedimentoNome", procedimentos.TipoProcedimentoId);
            return View(procedimentos);
        }

        // POST: Procedimentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProcedimentosId,ProcedimentoNome,ProcedimentoObservacao,TipoProcedimentoId")] Procedimentos procedimentos)
        {
            if (id != procedimentos.ProcedimentosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(procedimentos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcedimentosExists(procedimentos.ProcedimentosId))
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
            ViewData["TipoProcedimentoId"] = new SelectList(_context.TipoProcedimento, "Id", "TipoProcedimentoNome", procedimentos.TipoProcedimentoId);
            return View(procedimentos);
        }

        // GET: Procedimentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Procedimentos == null)
            {
                return NotFound();
            }

            var procedimentos = await _context.Procedimentos
                .Include(p => p.TipoProcedimento)
                .FirstOrDefaultAsync(m => m.ProcedimentosId == id);
            if (procedimentos == null)
            {
                return NotFound();
            }

            return View(procedimentos);
        }

        // POST: Procedimentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Procedimentos == null)
            {
                return Problem("Entity set 'Contexto.Procedimentos'  is null.");
            }
            var procedimentos = await _context.Procedimentos.FindAsync(id);
            if (procedimentos != null)
            {
                _context.Procedimentos.Remove(procedimentos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcedimentosExists(int id)
        {
          return (_context.Procedimentos?.Any(e => e.ProcedimentosId == id)).GetValueOrDefault();
        }
    }
}
