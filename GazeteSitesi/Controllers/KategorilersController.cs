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
    public class KategorilersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KategorilersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Kategorilers
        public async Task<IActionResult> Index()
        {
              return _context.Kategorilers != null ? 
                          View(await _context.Kategorilers.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Kategorilers'  is null.");
        }

        // GET: Kategorilers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Kategorilers == null)
            {
                return NotFound();
            }

            var kategoriler = await _context.Kategorilers
                .FirstOrDefaultAsync(m => m.KategoriId == id);
            if (kategoriler == null)
            {
                return NotFound();
            }

            return View(kategoriler);
        }

        // GET: Kategorilers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kategorilers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KategoriId,KategoriAdi")] Kategoriler kategoriler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kategoriler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kategoriler);
        }

        // GET: Kategorilers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Kategorilers == null)
            {
                return NotFound();
            }

            var kategoriler = await _context.Kategorilers.FindAsync(id);
            if (kategoriler == null)
            {
                return NotFound();
            }
            return View(kategoriler);
        }

        // POST: Kategorilers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KategoriId,KategoriAdi")] Kategoriler kategoriler)
        {
            if (id != kategoriler.KategoriId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kategoriler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KategorilerExists(kategoriler.KategoriId))
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
            return View(kategoriler);
        }

        // GET: Kategorilers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Kategorilers == null)
            {
                return NotFound();
            }

            var kategoriler = await _context.Kategorilers
                .FirstOrDefaultAsync(m => m.KategoriId == id);
            if (kategoriler == null)
            {
                return NotFound();
            }

            return View(kategoriler);
        }

        // POST: Kategorilers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Kategorilers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Kategorilers'  is null.");
            }
            var kategoriler = await _context.Kategorilers.FindAsync(id);
            if (kategoriler != null)
            {
                _context.Kategorilers.Remove(kategoriler);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KategorilerExists(int id)
        {
          return (_context.Kategorilers?.Any(e => e.KategoriId == id)).GetValueOrDefault();
        }
    }
}
