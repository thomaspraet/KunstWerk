using KunstWerk.Business.Services.IServices;
using KunstWerk.Models;
using KunstWerk.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


public class ArtistsController : Controller
{
    private readonly IArtistService _artistService;

    public ArtistsController(IArtistService artistService)
    {
        _artistService = artistService;
    }

    // GET: ARTISTS
    public async Task<IActionResult> Index()    
    {
        return View(await _artistService.GetAllArtistsAsync());
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
            await _artistService.CreateArtistAsync(artist);
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

        var artist = await _artistService.GetArtistByIdAsync(id.Value);
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
            await _artistService.UpdateArtistAsync(artist);
            return RedirectToAction(nameof(Index));
        }
        return View(artist);
    }

    // GET: ARTISTS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var artist = await _artistService.GetArtistByIdAsync(id.Value);
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
        await _artistService.DeleteArtistAsync(id.Value);
        return RedirectToAction(nameof(Index));
    }
}
