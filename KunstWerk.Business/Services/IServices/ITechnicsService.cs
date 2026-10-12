using KunstWerk.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KunstWerk.Business.Services.IServices
{
    public interface ITechnicsService
    {
        Task<Technic?> GetTechnicByIdAsync(int id);
        Task<IEnumerable<Technic>> GetAllTechnicsAsync();
        Task<Technic> CreateTechnicAsync(Technic technic);
        Task UpdateTechnicAsync(Technic technic);
        Task DeleteTechnicAsync(int id);
    }
}
