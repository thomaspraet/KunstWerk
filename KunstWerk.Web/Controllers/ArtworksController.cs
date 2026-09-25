
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KunstWerk.Web.Models;
using KunstWerk.Web.Data;

public class ArtworksController : Controller
{
    private readonly ApplicationDbContext _context;

    public ArtworksController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: ARTWORKS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Artwork.ToListAsync());
    }

    // GET: ARTWORKS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: ARTWORKS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Title,Dimensions,ImageUrl")] Artwork artwork)
    {
        if (ModelState.IsValid)
        {
            _context.Add(artwork);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(artwork);
    }

    // GET: ARTWORKS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var artwork = await _context.Artwork.FindAsync(id);
        if (artwork == null)
        {
            return NotFound();
        }
        return View(artwork);
    }

    // POST: ARTWORKS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Title,Dimensions,ImageUrl")] Artwork artwork)
    {
        if (id != artwork.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(artwork);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtworkExists(artwork.Id))
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
        return View(artwork);
    }

    // GET: ARTWORKS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var artwork = await _context.Artwork
            .FirstOrDefaultAsync(m => m.Id == id);
        if (artwork == null)
        {
            return NotFound();
        }

        return View(artwork);
    }

    // POST: ARTWORKS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var artwork = await _context.Artwork.FindAsync(id);
        if (artwork != null)
        {
            _context.Artwork.Remove(artwork);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ArtworkExists(int? id)
    {
        return _context.Artwork.Any(e => e.Id == id);
    }
}
