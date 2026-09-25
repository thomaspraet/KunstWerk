using KunstWerk.Models;
using KunstWerk.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace KunstWerk.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<KunstWerk.Web.Models.Artwork> Artwork { get; set; } = default!;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Tech> Technics { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Artwork> Artworks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tech>().HasData(
                new Tech { Id = 1, Techniek = "Acryl" },
                new Tech { Id = 2, Techniek = "Aquarel" },
                new Tech { Id = 3, Techniek = "Aquarel & fineliner" },
                new Tech { Id = 4, Techniek = "Aquatint" },
                new Tech { Id = 5, Techniek = "Bister" },
                new Tech { Id = 6, Techniek = "Balpen & markers" },
                new Tech { Id = 7, Techniek = "Cement" },
                new Tech { Id = 8, Techniek = "Ets" },
                new Tech { Id = 9, Techniek = "Ets, droge naald" },
                new Tech { Id = 10, Techniek = "Gemengde techniek" },
                new Tech { Id = 11, Techniek = "Gouache" },
                new Tech { Id = 12, Techniek = "Houtsnede" },
                new Tech { Id = 13, Techniek = "Keramiek" },
                new Tech { Id = 14, Techniek = "Klei" },
                new Tech { Id = 15, Techniek = "Kleurpotlood" },
                new Tech { Id = 16, Techniek = "Linosnede" },
                new Tech { Id = 17, Techniek = "Nagellak" },
                new Tech { Id = 18, Techniek = "Litho" },
                new Tech { Id = 19, Techniek = "Offset druk" },
                new Tech { Id = 20, Techniek = "Olieverf" },
                new Tech { Id = 21, Techniek = "Oostindische inkt" },
                new Tech { Id = 22, Techniek = "Opgehoogde zeefdruk" },
                new Tech { Id = 23, Techniek = "PC grafiek" },
                new Tech { Id = 24, Techniek = "Print op doek" },
                new Tech { Id = 25, Techniek = "Print op fotopapier" },
                new Tech { Id = 26, Techniek = "Resin" },
                new Tech { Id = 27, Techniek = "Zeefdruk" }

                );


            modelBuilder.Entity<Artist>().HasData(
                new Artist { Id = 1, FirstName = "Nancy", LastName = "Bailleux", PlaceOfBirth = "Antwerpen", YearOfBirth = "1964" }
                );

            modelBuilder.Entity<Artwork>().HasData(
                new Artwork { Id = 1, Title = "Zonder titel", Dimensions = "90 x 65", ImageUrl = ""}
                );
        }
    }
}
