using KunstWerk.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KunstWerk.Business.Services
{
    public class ArtistsService : IServices.IArtistsService
    {
        public Task<Artist> CreateArtistAsync(Artist artist)
        {
            throw new NotImplementedException();
        }

        public Task DeleteArtistAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Artist>> GetAllArtistsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Artist?> GetArtistByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateArtistAsync(Artist artist)
        {
            throw new NotImplementedException();
        }
    }
}
