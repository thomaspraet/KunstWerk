using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KunstWerk.Models;

namespace KunstWerk.DataAccess.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<KunstWerk.Models.Artist> Artist { get; set; } = default!;
        public DbSet<KunstWerk.Models.Technic> Technic { get; set; } = default!;


        public DbSet<Artist> Artists { get; set; }
        public DbSet<Technic> Technics { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Artist>().HasData(
                new Artist { Id = 1, FirstName = "Nancy", LastName = "Bailleux", BirthPlace = "Antwerpen", BirthYear = 1964 },
                new Artist { Id = 2, LastName = "Banksy", BirthPlace = "Yate (UK)", BirthYear = 1974 },
                new Artist { Id = 3, FirstName = "Gerrit", LastName = "Baten", BirthPlace = "Aalst", BirthYear = 1959 },
                new Artist { Id = 4, FirstName = "Etienne", LastName = "Bauwens", BirthPlace = "Aalst", BirthYear = 1930 },
                new Artist { Id = 5, FirstName = "Geert", LastName = "Bauwens", BirthPlace = "Aalst", BirthYear = 1961 },
                new Artist { Id = 6, FirstName = "René", LastName = "Bekaert", BirthPlace = "Aalst", BirthYear = 1938 },
                new Artist { Id = 7, FirstName = "André", LastName = "Berner", BirthPlace = "Vilvoorde", BirthYear = 1955 },
                new Artist { Id = 8, FirstName = "Walter", LastName = "Brems", BirthPlace = "Reet", BirthYear = 1947 },
                new Artist { Id = 9, FirstName = "Pedro", LastName = "Brugada", BirthPlace = "Girona (ESP)", BirthYear = 1952 },
                new Artist { Id = 10, FirstName = "André", LastName = "Bruylandt", BirthPlace = "Onkerzele", BirthYear = 1944 },
                new Artist { Id = 11, FirstName = "Randall", LastName = "Casaer", BirthPlace = "", BirthYear = 1967 },
                new Artist { Id = 12, FirstName = "Roland", LastName = "Cobbaut", BirthPlace = "" },
                new Artist { Id = 13, FirstName = "Claire", LastName = "Cocquyt", BirthPlace = "" },
                new Artist { Id = 14, FirstName = "Raf", LastName = "Coorevits", BirthPlace = "Sint-Niklaas", BirthYear = 1934 },
                new Artist { Id = 15, FirstName = "Tony", LastName = "De Bruycker", BirthPlace = "Gent", BirthYear = 1950 },
                new Artist { Id = 16, FirstName = "Vigdis", LastName = "De Cauter", BirthPlace = "Gent", BirthYear = 1974 },
                new Artist { Id = 17, FirstName = "Jeanne", LastName = "De Dijn", BirthPlace = "Wichelen", BirthYear = 1919 },
                new Artist { Id = 18, FirstName = "Robert", LastName = "De keersmaecker", BirthPlace = "Bornem", BirthYear = 1955 },
                new Artist { Id = 19, FirstName = "Luc", LastName = "De Mot", BirthPlace = "Aalst", BirthYear = 1934 },
                new Artist { Id = 20, FirstName = "Pieter", LastName = "De Poortere", BirthPlace = "Gent", BirthYear = 1976 },
                new Artist { Id = 21, FirstName = "Gino", LastName = "Dermaut", BirthPlace = "Roeselare", BirthYear = 1951 },
                new Artist { Id = 22, FirstName = "Paul", LastName = "De Ryck", BirthPlace = "Aalst", BirthYear = 1953 },
                new Artist { Id = 23, FirstName = "Jozef", LastName = "De Schrijver", BirthPlace = "Aalst", BirthYear = 1916 },
                new Artist { Id = 24, FirstName = "François", LastName = "Deshommes", BirthPlace = "Aalst", BirthYear = 1939 },
                new Artist { Id = 25, FirstName = "Theo", LastName = "De Smedt", BirthPlace = "Aalst", BirthYear = 1938 },
                new Artist { Id = 26, FirstName = "Leen", LastName = "De Vos", BirthPlace = "Aalst", BirthYear = 1952 },
                new Artist { Id = 27, FirstName = "Frans", LastName = "De Vree", BirthPlace = "Aalst", BirthYear = 1934 },
                new Artist { Id = 28, FirstName = "Paul", LastName = "De Vylder", BirthPlace = "Sint-Niklaas", BirthYear = 1942 },
                new Artist { Id = 29, FirstName = "Ignace", LastName = "Dierickx", BirthPlace = "", },
                new Artist { Id = 30, FirstName = "Hans", LastName = "Droesbeke", BirthPlace = "Geraardsbergen", BirthYear = 1968 },
                new Artist { Id = 31, FirstName = "Ronald", LastName = "Ergo", BirthPlace = "Watervliet", BirthYear = 1936 },
                new Artist { Id = 32, FirstName = "", LastName = "Expha", BirthPlace = "Gent" },
                new Artist { Id = 33, FirstName = "Leonor", LastName = "Fini", BirthPlace = "Buenos Aires (ARG)", BirthYear = 1907 },
                new Artist { Id = 34, FirstName = "Rafaël", LastName = "Gorsen", BirthPlace = "Merksem", BirthYear = 1942 },
                new Artist { Id = 35, FirstName = "Daniël", LastName = "Hardyns", BirthPlace = "Gent", BirthYear = 1951 },
                new Artist { Id = 36, FirstName = "Henri", LastName = "Hemelsoet", BirthPlace = "Westdorpe (NL)", BirthYear = 1955 },
                new Artist { Id = 37, FirstName = "Eveline", LastName = "Henderickx", BirthPlace = "Aalst", BirthYear = 1931 },
                new Artist { Id = 38, FirstName = "Carla", LastName = "Heuvinck", BirthPlace = "", },
                new Artist { Id = 39, FirstName = "Luc", LastName = "Hoenraet", BirthPlace = "Aalst", BirthYear = 1941 },
                new Artist { Id = 40, FirstName = "Achiel", LastName = "Hutsebaut", BirthPlace = "Hofstade", BirthYear = 1936 },
                new Artist { Id = 41, FirstName = "Octave", LastName = "Landuyt", BirthPlace = "Gent", BirthYear = 1922 },
                new Artist { Id = 42, FirstName = "Fons", LastName = "Macharis", BirthPlace = "Denderbelle", BirthYear = 1927 },
                new Artist { Id = 43, FirstName = "Mik", LastName = "Maes", BirthPlace = "Aalst", BirthYear = 1959 },
                new Artist { Id = 44, FirstName = "", LastName = "MarieAnge", BirthPlace = "Nieuwpoort", BirthYear = 1963 },
                new Artist { Id = 45, FirstName = "Frans", LastName = "Minnaert", BirthPlace = "Idegem", BirthYear = 1929 },
                new Artist { Id = 46, FirstName = "Wilhelm", LastName = "Mechnig", BirthPlace = "Köln (GER)", BirthYear = 1929 },
                new Artist { Id = 47, FirstName = "Martina", LastName = "Mory", BirthPlace = "", },
                new Artist { Id = 48, FirstName = "Geert", LastName = "Opsomer", BirthPlace = "Waregem", BirthYear = 1958 },
                new Artist { Id = 49, FirstName = "Achiel", LastName = "Pauwels", BirthPlace = "Mariakerke", BirthYear = 1932 },
                new Artist { Id = 50, FirstName = "Dany", LastName = "Persoons", BirthPlace = "Aspelare", BirthYear = 1938 },
                new Artist { Id = 51, FirstName = "Cyriel", LastName = "Poep", BirthPlace = "Lede", BirthYear = 1870 },
                new Artist { Id = 52, FirstName = "Brigitta", LastName = "Praet", BirthPlace = "Wichelen", BirthYear = 1959 },
                new Artist { Id = 53, FirstName = "Matteas", LastName = "Praet", BirthPlace = "Aalst", BirthYear = 1988 },
                new Artist { Id = 54, FirstName = "Paul", LastName = "Ryckaert", BirthPlace = "", BirthYear = 1951 },
                new Artist { Id = 55, FirstName = "André", LastName = "Roelant", BirthPlace = "Sint-Niklaas", BirthYear = 1942 },
                new Artist { Id = 56, FirstName = "Walter", LastName = "Schelfhout", BirthPlace = "Aalst", BirthYear = 1942 },
                new Artist { Id = 57, FirstName = "Guy", LastName = "Smet", BirthPlace = "Dendermonde", BirthYear = 1954 },
                new Artist { Id = 58, FirstName = "Jeroom", LastName = "Snelders", BirthPlace = "Borgerhout", BirthYear = 1977 },
                new Artist { Id = 59, FirstName = "Paul", LastName = "Van den Abeele", BirthPlace = "Aalst", BirthYear = 1929 },
                new Artist { Id = 60, FirstName = "Guy", LastName = "Van den Eeckhaut", BirthPlace = "Aalst", BirthYear = 1949 },
                new Artist { Id = 61, FirstName = "Jan", LastName = "Van Der Aa", BirthPlace = "Hemiksem", BirthYear = 1927 },
                new Artist { Id = 62, FirstName = "Jean-Paul", LastName = "van der Poorten", BirthPlace = "Aalst", BirthYear = 1951 },
                new Artist { Id = 63, FirstName = "Rika", LastName = "Van Dyke", BirthPlace = "Brugge", BirthYear = 1948 },
                new Artist { Id = 64, FirstName = "Tom", LastName = "Verhoeven", BirthPlace = "Wetteren", BirthYear = 1979 },
                new Artist { Id = 65, FirstName = "Roger", LastName = "Wittewrongel", BirthPlace = "Blankenberge", BirthYear = 1933 },
                new Artist { Id = 66, FirstName = "Kimiko", LastName = "Yoshida", BirthPlace = "Tokyo (JAP)", BirthYear = 1963 },
                new Artist { Id = 67, FirstName = "Jacky", LastName = "Zegers", BirthPlace = "" }


            );



            modelBuilder.Entity<Technic>().HasData(
                new Technic { Id = 1, Name = "Acryl" },
                new Technic { Id = 2, Name = "Aquarel" },
                new Technic { Id = 3, Name = "Aquarel & fineliner" },
                new Technic { Id = 4, Name = "Aquatint" },
                new Technic { Id = 5, Name = "Bister" },
                new Technic { Id = 6, Name = "Balpen & markers" },
                new Technic { Id = 7, Name = "Cement" },
                new Technic { Id = 8, Name = "Ets" },
                new Technic { Id = 9, Name = "Ets, droge naald" },
                new Technic { Id = 10, Name = "Gemengde techniek" },
                new Technic { Id = 11, Name = "Gouache" },
                new Technic { Id = 12, Name = "Houtsnede" },
                new Technic { Id = 13, Name = "Keramiek" },
                new Technic { Id = 14, Name = "Klei" },
                new Technic { Id = 15, Name = "Kleurpotlood" },
                new Technic { Id = 16, Name = "Linosnede" },
                new Technic { Id = 17, Name = "Nagellak" },
                new Technic { Id = 18, Name = "Litho" },
                new Technic { Id = 19, Name = "Offset druk" },
                new Technic { Id = 20, Name = "Olieverf" },
                new Technic { Id = 21, Name = "Oostindische inkt" },
                new Technic { Id = 22, Name = "Opgehoogde zeefdruk" },
                new Technic { Id = 23, Name = "PC grafiek" },
                new Technic { Id = 24, Name = "Print op doek" },
                new Technic { Id = 25, Name = "Print op fotopapier" },
                new Technic { Id = 26, Name = "Resin" },
                new Technic { Id = 27, Name = "Zeefdruk" }

            );
        }
    }
}
