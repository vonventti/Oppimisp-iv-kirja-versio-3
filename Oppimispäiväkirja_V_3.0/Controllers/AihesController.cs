using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oppimispäiväkirja_V_3._0.Data;
using Oppimispäiväkirja_V_3._0.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Oppimispäiväkirja_V_3._0.Controllers
{
    public class AihesController : Controller
    {
        private readonly Oppimispäiväkirja_V_3_0Context _context;

        public AihesController(Oppimispäiväkirja_V_3_0Context context)
        {
            _context = context;
        }

        // GET: Aihes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Aihe.ToListAsync());
        }

        // GET: ShowSearchForm
        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }

        // Post: ShowSearchResults ID
        public async Task<IActionResult> ShowSearcResults(int SearchPhrase)
        {
            return View("Index", await _context.Aihe.Where(j => j.Id == SearchPhrase).ToListAsync());
        }

        // Post: ShowSearchResults Title
        public async Task<IActionResult> ShowSearcResults1(string SearchPhrase)
        {
            return View("Index", await _context.Aihe.Where(j => j.Title.Contains(SearchPhrase)).ToListAsync());
        }

        // GET: Aihes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aihe = await _context.Aihe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aihe == null)
            {
                return NotFound();
            }

            return View(aihe);
        }

        // GET: Aihes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aihes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,TimeToMaster,TimeSpent,Source,StartLearningDate,InProgress,CompletionDate")] Aihe aihe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aihe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aihe);
        }

        // GET: Aihes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aihe = await _context.Aihe.FindAsync(id);
            if (aihe == null)
            {
                return NotFound();
            }
            return View(aihe);
        }

        // POST: Aihes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,TimeToMaster,TimeSpent,Source,StartLearningDate,InProgress,CompletionDate")] Aihe aihe)
        {
            if (id != aihe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aihe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AiheExists(aihe.Id))
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
            return View(aihe);
        }

        // GET: Aihes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aihe = await _context.Aihe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aihe == null)
            {
                return NotFound();
            }

            return View(aihe);
        }

        // POST: Aihes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aihe = await _context.Aihe.FindAsync(id);
            _context.Aihe.Remove(aihe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AiheExists(int id)
        {
            return _context.Aihe.Any(e => e.Id == id);
        }
    }
}
