using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GazeteSitesi.Data;
using GazeteSitesi.Models;

namespace GazeteSitesi.Controllers
{
    public class HaberlersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HaberlersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Haberlers
        public async Task<IActionResult> Index()
        {
              return _context.haberlers != null ? 
                          View(await _context.haberlers.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.haberlers'  is null.");
        }

        // GET: Haberlers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.haberlers == null)
            {
                return NotFound();
            }

            var haberler = await _context.haberlers
                .FirstOrDefaultAsync(m => m.HaberId == id);
            if (haberler == null)
            {
                return NotFound();
            }

            return View(haberler);
        }

        // GET: Haberlers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Haberlers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HaberId,HaberBaslik,HaberKonu,HaberIcerik,ResimId,KategoriId,YazarId,HaberTarih,HaberManset,KonumId")] Haberler haberler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(haberler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(haberler);
        }

        // GET: Haberlers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.haberlers == null)
            {
                return NotFound();
            }

            var haberler = await _context.haberlers.FindAsync(id);
            if (haberler == null)
            {
                return NotFound();
            }
            return View(haberler);
        }

        // POST: Haberlers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HaberId,HaberBaslik,HaberKonu,HaberIcerik,ResimId,KategoriId,YazarId,HaberTarih,HaberManset,KonumId")] Haberler haberler)
        {
            if (id != haberler.HaberId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(haberler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HaberlerExists(haberler.HaberId))
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
            return View(haberler);
        }

        // GET: Haberlers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.haberlers == null)
            {
                return NotFound();
            }

            var haberler = await _context.haberlers
                .FirstOrDefaultAsync(m => m.HaberId == id);
            if (haberler == null)
            {
                return NotFound();
            }

            return View(haberler);
        }

        // POST: Haberlers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.haberlers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.haberlers'  is null.");
            }
            var haberler = await _context.haberlers.FindAsync(id);
            if (haberler != null)
            {
                _context.haberlers.Remove(haberler);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HaberlerExists(int id)
        {
          return (_context.haberlers?.Any(e => e.HaberId == id)).GetValueOrDefault();
        }
    }
}
