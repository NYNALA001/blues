using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using blues.Data;
using blues.Models;

namespace blues.Controllers
{
    public class RouteBusStopTimesController : Controller
    {
        private readonly BusContext _context;

        public RouteBusStopTimesController(BusContext context)
        {
            _context = context;    
        }

        // GET: RouteBusStopTimes
        public async Task<IActionResult> Index()
        {
            return View(await _context.RouteBusStopTimes.ToListAsync());
        }

        // GET: RouteBusStopTimes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var routeBusStopTime = await _context.RouteBusStopTimes
                .SingleOrDefaultAsync(m => m.RouteBusStopTimeID == id);
            if (routeBusStopTime == null)
            {
                return NotFound();
            }

            return View(routeBusStopTime);
        }

        // GET: RouteBusStopTimes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RouteBusStopTimes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RouteBusStopTimeID,BusStopId,RouteID,TimeSheetId,OrderIndex")] RouteBusStopTime routeBusStopTime)
        {
            if (ModelState.IsValid)
            {
                _context.Add(routeBusStopTime);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(routeBusStopTime);
        }

        // GET: RouteBusStopTimes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var routeBusStopTime = await _context.RouteBusStopTimes.SingleOrDefaultAsync(m => m.RouteBusStopTimeID == id);
            if (routeBusStopTime == null)
            {
                return NotFound();
            }
            return View(routeBusStopTime);
        }

        // POST: RouteBusStopTimes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RouteBusStopTimeID,BusStopId,RouteID,TimeSheetId,OrderIndex")] RouteBusStopTime routeBusStopTime)
        {
            if (id != routeBusStopTime.RouteBusStopTimeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(routeBusStopTime);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RouteBusStopTimeExists(routeBusStopTime.RouteBusStopTimeID))
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
            return View(routeBusStopTime);
        }

        // GET: RouteBusStopTimes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var routeBusStopTime = await _context.RouteBusStopTimes
                .SingleOrDefaultAsync(m => m.RouteBusStopTimeID == id);
            if (routeBusStopTime == null)
            {
                return NotFound();
            }

            return View(routeBusStopTime);
        }

        // POST: RouteBusStopTimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var routeBusStopTime = await _context.RouteBusStopTimes.SingleOrDefaultAsync(m => m.RouteBusStopTimeID == id);
            _context.RouteBusStopTimes.Remove(routeBusStopTime);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool RouteBusStopTimeExists(int id)
        {
            return _context.RouteBusStopTimes.Any(e => e.RouteBusStopTimeID == id);
        }
    }
}
