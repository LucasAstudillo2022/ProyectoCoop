using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoServiCoop.Models;

namespace ProyectoServiCoop.Controllers
{
    public class ServisController : Controller
    {
        private readonly appDBcontext _context;

        public ServisController(appDBcontext context)
        {
            _context = context;
        }

        // GET: Servis
        public async Task<IActionResult> Index()
        {
            return View(await _context.servi.ToListAsync());
        }

        // GET: Servis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servi = await _context.servi
                .FirstOrDefaultAsync(m => m.ID == id);
            if (servi == null)
            {
                return NotFound();
            }

            return View(servi);
        }

        // GET: Servis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Servis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,marca,tipo,fecharealizada,km,proxservi,realizado")] Servi servi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(servi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(servi);
        }

        // GET: Servis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servi = await _context.servi.FindAsync(id);
            if (servi == null)
            {
                return NotFound();
            }
            return View(servi);
        }

        // POST: Servis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,marca,tipo,fecharealizada,km,proxservi,realizado")] Servi servi)
        {
            if (id != servi.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiExists(servi.ID))
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
            return View(servi);
        }

        // GET: Servis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servi = await _context.servi
                .FirstOrDefaultAsync(m => m.ID == id);
            if (servi == null)
            {
                return NotFound();
            }

            return View(servi);
        }

        // POST: Servis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var servi = await _context.servi.FindAsync(id);
            _context.servi.Remove(servi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiExists(int id)
        {
            return _context.servi.Any(e => e.ID == id);
        }
    }
}
