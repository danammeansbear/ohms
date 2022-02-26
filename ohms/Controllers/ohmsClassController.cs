#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ohms.Data;
using ohms.Models;

namespace ohms.Controllers
{
    public class ohmsClassesController : Controller
    {
        private readonly ohmsContext _context;

        public ohmsClassesController(ohmsContext context)
        {
            _context = context;
        }

        // GET: ohmsClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.ohmsClass.ToListAsync());
        }

        // GET: ohmsClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ohmsClass = await _context.ohmsClass
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ohmsClass == null)
            {
                return NotFound();
            }

            return View(ohmsClass);
        }

        // GET: ohmsClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ohmsClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Code,RAL,SigFig,Multiplier,Multiplier2,Percent,Letter,Ppmk,TCLetter")] ohmsClass ohmsClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ohmsClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ohmsClass);
        }

        // GET: ohmsClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ohmsClass = await _context.ohmsClass.FindAsync(id);
            if (ohmsClass == null)
            {
                return NotFound();
            }
            return View(ohmsClass);
        }

        // POST: ohmsClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Code,RAL,SigFig,Multiplier,Multiplier2,Percent,Letter,Ppmk,TCLetter")] ohmsClass ohmsClass)
        {
            if (id != ohmsClass.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ohmsClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ohmsClassExists(ohmsClass.Id))
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
            return View(ohmsClass);
        }

        // GET: ohmsClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ohmsClass = await _context.ohmsClass
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ohmsClass == null)
            {
                return NotFound();
            }

            return View(ohmsClass);
        }

        // POST: ohmsClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ohmsClass = await _context.ohmsClass.FindAsync(id);
            _context.ohmsClass.Remove(ohmsClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ohmsClassExists(int id)
        {
            return _context.ohmsClass.Any(e => e.Id == id);
        }
    }
}
