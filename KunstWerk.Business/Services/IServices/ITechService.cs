using KunstWerk.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KunstWerk.Business.Services.IServices
{
    public interface ITechService
    {
        Task<Tech?> GetTechByIdAsync(int id);
        Task<IEnumerable<Tech>> GetAllTechsAsync();
        Task<Tech> CreateTechAsync(Tech tech);
        Task UpdateTechAsync(Tech tech);
        Task DeleteTechAsync(int id);
    }
}
