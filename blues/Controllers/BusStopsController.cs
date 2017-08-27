using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using blues.Data;
using blues.Models;

namespace blues.Controllers
{
    public class BusStopsController : Controller
    {
        private readonly BusContext _context;

        public BusStopsController(BusContext context)
        {
            _context = context;    
        }

        // GET: BusStops
        public async Task<IActionResult> Index()
        {
            return View(await _context.BusStops.ToListAsync());
        }

        // GET: BusStops/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var busStop = await _context.BusStops
                .SingleOrDefaultAsync(m => m.BusStopID == id);
            if (busStop == null)
            {
                return NotFound();
            }

            return View(busStop);
        }

        // GET: BusStops/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BusStops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BusStopID,Name,Address,latitude,longitude")] BusStop busStop)
        {
            if (ModelState.IsValid)
            {
                _context.Add(busStop);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(busStop);
        }

        // GET: BusStops/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var busStop = await _context.BusStops.SingleOrDefaultAsync(m => m.BusStopID == id);
            if (busStop == null)
            {
                return NotFound();
            }
            return View(busStop);
        }

        // POST: BusStops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BusStopID,Name,Address,latitude,longitude")] BusStop busStop)
        {
            if (id != busStop.BusStopID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(busStop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusStopExists(busStop.BusStopID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(busStop);
        }

        // GET: BusStops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var busStop = await _context.BusStops
                .SingleOrDefaultAsync(m => m.BusStopID == id);
            if (busStop == null)
            {
                return NotFound();
            }

            return View(busStop);
        }

        // POST: BusStops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var busStop = await _context.BusStops.SingleOrDefaultAsync(m => m.BusStopID == id);
            _context.BusStops.Remove(busStop);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool BusStopExists(int id)
        {
            return _context.BusStops.Any(e => e.BusStopID == id);
        }
    }
}
