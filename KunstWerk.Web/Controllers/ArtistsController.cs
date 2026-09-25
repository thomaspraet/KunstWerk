
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KunstWerk.Models;
using KunstWerk.Web.Data;

public class ArtistsController : Controller
{
    private readonly ApplicationDbContext _context;

    public ArtistsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: ARTISTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Artists.ToListAsync());
    }

    // GET: ARTISTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: ARTISTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,PlaceOfBirth,YearOfBirth")] Artist artist)
    {
        if (ModelState.IsValid)
        {
            _context.Add(artist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(artist);
    }

    // GET: ARTISTS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var artist = await _context.Artists.FindAsync(id);
        if (artist == null)
        {
            return NotFound();
        }
        return View(artist);
    }

    // POST: ARTISTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,FirstName,LastName,PlaceOfBirth,YearOfBirth")] Artist artist)
    {
        if (id != artist.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(artist);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtistExists(artist.Id))
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
        return View(artist);
    }

    // GET: ARTISTS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var artist = await _context.Artists
            .FirstOrDefaultAsync(m => m.Id == id);
        if (artist == null)
        {
            return NotFound();
        }

        return View(artist);
    }

    // POST: ARTISTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var artist = await _context.Artists.FindAsync(id);
        if (artist != null)
        {
            _context.Artists.Remove(artist);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ArtistExists(int? id)
    {
        return _context.Artists.Any(e => e.Id == id);
    }
}
