﻿using System;
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
    public class YazarlarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public YazarlarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Yazarlars
        public async Task<IActionResult> Index()
        {
              return _context.Yazarlars != null ? 
                          View(await _context.Yazarlars.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Yazarlars'  is null.");
        }

        // GET: Yazarlars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Yazarlars == null)
            {
                return NotFound();
            }

            var yazarlar = await _context.Yazarlars
                .FirstOrDefaultAsync(m => m.YazarId == id);
            if (yazarlar == null)
            {
                return NotFound();
            }

            return View(yazarlar);
        }

        // GET: Yazarlars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Yazarlars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("YazarId,YazarAd,YazarResim,YazarEmail,YazarSifre")] Yazarlar yazarlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yazarlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(yazarlar);
        }

        // GET: Yazarlars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Yazarlars == null)
            {
                return NotFound();
            }

            var yazarlar = await _context.Yazarlars.FindAsync(id);
            if (yazarlar == null)
            {
                return NotFound();
            }
            return View(yazarlar);
        }

        // POST: Yazarlars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("YazarId,YazarAd,YazarResim,YazarEmail,YazarSifre")] Yazarlar yazarlar)
        {
            if (id != yazarlar.YazarId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yazarlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YazarlarExists(yazarlar.YazarId))
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
            return View(yazarlar);
        }

        // GET: Yazarlars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Yazarlars == null)
            {
                return NotFound();
            }

            var yazarlar = await _context.Yazarlars
                .FirstOrDefaultAsync(m => m.YazarId == id);
            if (yazarlar == null)
            {
                return NotFound();
            }

            return View(yazarlar);
        }

        // POST: Yazarlars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Yazarlars == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Yazarlars'  is null.");
            }
            var yazarlar = await _context.Yazarlars.FindAsync(id);
            if (yazarlar != null)
            {
                _context.Yazarlars.Remove(yazarlar);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YazarlarExists(int id)
        {
          return (_context.Yazarlars?.Any(e => e.YazarId == id)).GetValueOrDefault();
        }
    }
}
