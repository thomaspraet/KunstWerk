
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KunstWerk.Models;
using KunstWerk.Web.Data;

public class TechController : Controller
{
    private readonly ApplicationDbContext _context;

    public TechController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: TECHS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Technics.ToListAsync());
    }

    // GET: TECHS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: TECHS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Techniek")] Tech tech)
    {
        if (ModelState.IsValid)
        {
            _context.Add(tech);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(tech);
    }

    // GET: TECHS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var tech = await _context.Technics.FindAsync(id);
        if (tech == null)
        {
            return NotFound();
        }
        return View(tech);
    }

    // POST: TECHS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Techniek")] Tech tech)
    {
        if (id != tech.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(tech);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TechExists(tech.Id))
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
        return View(tech);
    }

    // GET: TECHS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var tech = await _context.Technics
            .FirstOrDefaultAsync(m => m.Id == id);
        if (tech == null)
        {
            return NotFound();
        }

        return View(tech);
    }

    // POST: TECHS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var tech = await _context.Technics.FindAsync(id);
        if (tech != null)
        {
            _context.Technics.Remove(tech);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool TechExists(int? id)
    {
        return _context.Technics.Any(e => e.Id == id);
    }
}
