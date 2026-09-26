using KunstWerk.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KunstWerk.Models;
using KunstWerk.Business.Services.IServices;

public class TechController : Controller
{
    private readonly ITechService _techService;

    public TechController(ITechService techService)
    {
        _techService = techService;
    }

    // GET: TECHS
    public async Task<IActionResult> Index()    
    {
        return View(await _techService.GetAllTechsAsync());
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
            await _techService.CreateTechAsync(tech);
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

        var tech = await _techService.GetTechByIdAsync(id.Value);
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
            await _techService.UpdateTechAsync(tech);
            return RedirectToAction(nameof(Index));
        }
        return View(tech);
    }

    // GET: TECHS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var tech = await _techService.GetTechByIdAsync(id.Value);
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
        await _techService.DeleteTechAsync(id.Value);
        return RedirectToAction(nameof(Index));
    }
}
