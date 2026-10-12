using KunstWerk.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KunstWerk.Business.Services.IServices
{
    public interface IArtistsService
    {
        Task<Artist?> GetArtistByIdAsync(int id);
        Task<IEnumerable<Artist>> GetAllArtistsAsync();
        Task<Artist> CreateArtistAsync(Artist artist);
        Task UpdateArtistAsync(Artist artist);
        Task DeleteArtistAsync(int id);
    }
}
