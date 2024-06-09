using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CanadianResidencyStatus.Data;

namespace CanadianResidencyStatus.Controllers
{
    public class ResidentsController : Controller
    {
        private readonly CanadianRecidencyStatusDbContext _context;

        public ResidentsController(CanadianRecidencyStatusDbContext context)
        {
            _context = context;
        }

        // GET: Residents
        public async Task<IActionResult> Index()
        {
            var canadianRecidencyStatusDbContext = _context.residents.Include(r => r.country).Include(r => r.job).Include(r => r.status);
            return View(await canadianRecidencyStatusDbContext.ToListAsync());
        }

        // GET: Residents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resident = await _context.residents
                .Include(r => r.country)
                .Include(r => r.job)
                .Include(r => r.status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resident == null)
            {
                return NotFound();
            }

            return View(resident);
        }

        // GET: Residents/Create
        public IActionResult Create()
        {
            ViewData["CountryId"] = new SelectList(_context.countries, "Id", "Id");
            ViewData["JobId"] = new SelectList(_context.jobs, "Id", "Id");
            ViewData["StatusId"] = new SelectList(_context.statusInCanada, "Id", "Id");
            return View();
        }

        // POST: Residents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address,City,Province,PostalCode,SIN,DateOfEntry,CountryId,JobId,StatusId")] Resident resident)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resident);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(_context.countries, "Id", "Id", resident.CountryId);
            ViewData["JobId"] = new SelectList(_context.jobs, "Id", "Id", resident.JobId);
            ViewData["StatusId"] = new SelectList(_context.statusInCanada, "Id", "Id", resident.StatusId);
            return View(resident);
        }

        // GET: Residents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resident = await _context.residents.FindAsync(id);
            if (resident == null)
            {
                return NotFound();
            }
            ViewData["CountryId"] = new SelectList(_context.countries, "Id", "Id", resident.CountryId);
            ViewData["JobId"] = new SelectList(_context.jobs, "Id", "Id", resident.JobId);
            ViewData["StatusId"] = new SelectList(_context.statusInCanada, "Id", "Id", resident.StatusId);
            return View(resident);
        }

        // POST: Residents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address,City,Province,PostalCode,SIN,DateOfEntry,CountryId,JobId,StatusId")] Resident resident)
        {
            if (id != resident.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resident);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResidentExists(resident.Id))
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
            ViewData["CountryId"] = new SelectList(_context.countries, "Id", "Id", resident.CountryId);
            ViewData["JobId"] = new SelectList(_context.jobs, "Id", "Id", resident.JobId);
            ViewData["StatusId"] = new SelectList(_context.statusInCanada, "Id", "Id", resident.StatusId);
            return View(resident);
        }

        // GET: Residents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resident = await _context.residents
                .Include(r => r.country)
                .Include(r => r.job)
                .Include(r => r.status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resident == null)
            {
                return NotFound();
            }

            return View(resident);
        }

        // POST: Residents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resident = await _context.residents.FindAsync(id);
            if (resident != null)
            {
                _context.residents.Remove(resident);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResidentExists(int id)
        {
            return _context.residents.Any(e => e.Id == id);
        }
    }
}
