
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KunstWerk.DataAccess.Data;
using KunstWerk.Models;

public class TechnicsController : Controller
{
    private readonly ApplicationDbContext _context;

    public TechnicsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: TECHNICS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Technic.ToListAsync());
    }

    // GET: TECHNICS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: TECHNICS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name")] Technic technic)
    {
        if (ModelState.IsValid)
        {
            _context.Add(technic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(technic);
    }

    // GET: TECHNICS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var technic = await _context.Technic.FindAsync(id);
        if (technic == null)
        {
            return NotFound();
        }
        return View(technic);
    }

    // POST: TECHNICS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Name")] Technic technic)
    {
        if (id != technic.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(technic);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TechnicExists(technic.Id))
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
        return View(technic);
    }

    // GET: TECHNICS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var technic = await _context.Technic
            .FirstOrDefaultAsync(m => m.Id == id);
        if (technic == null)
        {
            return NotFound();
        }

        return View(technic);
    }

    // POST: TECHNICS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var technic = await _context.Technic.FindAsync(id);
        if (technic != null)
        {
            _context.Technic.Remove(technic);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool TechnicExists(int? id)
    {
        return _context.Technic.Any(e => e.Id == id);
    }
}
