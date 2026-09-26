using KunstWerk.Business.Services.IServices;
using KunstWerk.Models;
using KunstWerk.Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KunstWerk.Business.Services
{
    public class TechService : ITechService
    {
        private readonly ApplicationDbContext _context;
        public TechService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tech>> GetAllTechsAsync()
        {
            return await _context.Technics.ToListAsync();
        }

        public async Task<Tech?> GetTechByIdAsync(int id)
        {
            return await _context.Technics.FindAsync(id);
        }
        


        public async Task<Tech> CreateTechAsync(Tech tech)
        {
            _context.Add(tech);
            await _context.SaveChangesAsync();
            return tech;
        }

        public async Task DeleteTechAsync(int id)
        {
            var tech = await _context.Technics.FindAsync(id);
            if (tech == null)
            {
                throw new KeyNotFoundException($"Tech {id} not found");
            }
            _context.Technics.Remove(tech);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTechAsync(Tech tech)
        {
            _context.Update(tech);
            await _context.SaveChangesAsync();
        }
    }
}
