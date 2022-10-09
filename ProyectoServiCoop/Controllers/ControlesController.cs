using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoServiCoop.Models;
using ProyectoServiCoop.Models1;

namespace ProyectoServiCoop.Controllers
{
    public class ControlesController : Controller
    {
        private readonly appDBcontext _context;

        public ControlesController(appDBcontext context)
        {
            _context = context;
        }

        // GET: Controles
        public async Task<IActionResult> Index()
        {
            return View(await _context.controle.ToListAsync());
        }

        // GET: Controles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var controle = await _context.controle
                .FirstOrDefaultAsync(m => m.ID == id);
            if (controle == null)
            {
                return NotFound();
            }

            return View(controle);
        }

        // GET: Controles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Controles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,marca,tipo,fecharealizada,km,opinion,realizado,supervisor")] Controle controle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(controle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(controle);
        }

        // GET: Controles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var controle = await _context.controle.FindAsync(id);
            if (controle == null)
            {
                return NotFound();
            }
            return View(controle);
        }

        // POST: Controles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,marca,tipo,fecharealizada,km,opinion,realizado,supervisor")] Controle controle)
        {
            if (id != controle.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(controle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ControleExists(controle.ID))
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
            return View(controle);
        }

        // GET: Controles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var controle = await _context.controle
                .FirstOrDefaultAsync(m => m.ID == id);
            if (controle == null)
            {
                return NotFound();
            }

            return View(controle);
        }

        // POST: Controles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var controle = await _context.controle.FindAsync(id);
            _context.controle.Remove(controle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ControleExists(int id)
        {
            return _context.controle.Any(e => e.ID == id);
        }
    }
}
