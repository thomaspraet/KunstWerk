using KunstWerk.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace KunstWerk.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Tech> Technics { get; set; }
    }
}
