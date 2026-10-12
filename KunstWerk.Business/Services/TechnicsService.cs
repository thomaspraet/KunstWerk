using KunstWerk.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KunstWerk.Business.Services
{
    public class TechnicsService : IServices.ITechnicsService
    {
        public Task<IEnumerable<Technic>> GetAllTechnicsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Technic?> GetTechnicByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Technic> CreateTechnicAsync(Technic technic)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTechnicAsync(int id)
        {
            throw new NotImplementedException();
        }

        
        public Task UpdateTechnicAsync(Technic technic)
        {
            throw new NotImplementedException();
        }
    }
}
