using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable


namespace KunstWerk.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedArtist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "Id", "BirthPlace", "BirthYear", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Antwerpen", 1964, "Nancy", "Bailleux" },
                    { 2, "Yate (UK)", 1974, null, "Banksy" },
                    { 3, "Aalst", 1959, "Gerrit", "Baten" },
                    { 4, "Aalst", 1930, "Etienne", "Bauwens" },
                    { 5, "Aalst", 1961, "Geert", "Bauwens" },
                    { 6, "Aalst", 1938, "René", "Bekaert" },
                    { 7, "Vilvoorde", 1955, "André", "Berner" },
                    { 8, "Reet", 1947, "Walter", "Brems" },
                    { 9, "Girona (ESP)", 1952, "Pedro", "Brugada" },
                    { 10, "Onkerzele", 1944, "André", "Bruylandt" },
                    { 11, "", 1967, "Randall", "Casaer" },
                    { 12, "", null, "Roland", "Cobbaut" },
                    { 13, "", null, "Claire", "Cocquyt" },
                    { 14, "Sint-Niklaas", 1934, "Raf", "Coorevits" },
                    { 15, "Gent", 1950, "Tony", "De Bruycker" },
                    { 16, "Gent", 1974, "Vigdis", "De Cauter" },
                    { 17, "Wichelen", 1919, "Jeanne", "De Dijn" },
                    { 18, "Bornem", 1955, "Robert", "De keersmaecker" },
                    { 19, "Aalst", 1934, "Luc", "De Mot" },
                    { 20, "Gent", 1976, "Pieter", "De Poortere" },
                    { 21, "Roeselare", 1951, "Gino", "Dermaut" },
                    { 22, "Aalst", 1953, "Paul", "De Ryck" },
                    { 23, "Aalst", 1916, "Jozef", "De Schrijver" },
                    { 24, "Aalst", 1939, "François", "Deshommes" },
                    { 25, "Aalst", 1938, "Theo", "De Smedt" },
                    { 26, "Aalst", 1952, "Leen", "De Vos" },
                    { 27, "Aalst", 1934, "Frans", "De Vree" },
                    { 28, "Sint-Niklaas", 1942, "Paul", "De Vylder" },
                    { 29, "", null, "Ignace", "Dierickx" },
                    { 30, "Geraardsbergen", 1968, "Hans", "Droesbeke" },
                    { 31, "Watervliet", 1936, "Ronald", "Ergo" },
                    { 32, "Gent", null, "", "Expha" },
                    { 33, "Buenos Aires (ARG)", 1907, "Leonor", "Fini" },
                    { 34, "Merksem", 1942, "Rafaël", "Gorsen" },
                    { 35, "Gent", 1951, "Daniël", "Hardyns" },
                    { 36, "Westdorpe (NL)", 1955, "Henri", "Hemelsoet" },
                    { 37, "Aalst", 1931, "Eveline", "Henderickx" },
                    { 38, "", null, "Carla", "Heuvinck" },
                    { 39, "Aalst", 1941, "Luc", "Hoenraet" },
                    { 40, "Hofstade", 1936, "Achiel", "Hutsebaut" },
                    { 41, "Gent", 1922, "Octave", "Landuyt" },
                    { 42, "Denderbelle", 1927, "Fons", "Macharis" },
                    { 43, "Aalst", 1959, "Mik", "Maes" },
                    { 44, "Nieuwpoort", 1963, "", "MarieAnge" },
                    { 45, "Idegem", 1929, "Frans", "Minnaert" },
                    { 46, "Köln (GER)", 1929, "Wilhelm", "Mechnig" },
                    { 47, "", null, "Martina", "Mory" },
                    { 48, "Waregem", 1958, "Geert", "Opsomer" },
                    { 49, "Mariakerke", 1932, "Achiel", "Pauwels" },
                    { 50, "Aspelare", 1938, "Dany", "Persoons" },
                    { 51, "Lede", 1870, "Cyriel", "Poep" },
                    { 52, "Wichelen", 1959, "Brigitta", "Praet" },
                    { 53, "Aalst", 1988, "Matteas", "Praet" },
                    { 54, "", 1951, "Paul", "Ryckaert" },
                    { 55, "Sint-Niklaas", 1942, "André", "Roelant" },
                    { 56, "Aalst", 1942, "Walter", "Schelfhout" },
                    { 57, "Dendermonde", 1954, "Guy", "Smet" },
                    { 58, "Borgerhout", 1977, "Jeroom", "Snelders" },
                    { 59, "Aalst", 1929, "Paul", "Van den Abeele" },
                    { 60, "Aalst", 1949, "Guy", "Van den Eeckhaut" },
                    { 61, "Hemiksem", 1927, "Jan", "Van Der Aa" },
                    { 62, "Aalst", 1951, "Jean-Paul", "van der Poorten" },
                    { 63, "Brugge", 1948, "Rika", "Van Dyke" },
                    { 64, "Wetteren", 1979, "Tom", "Verhoeven" },
                    { 65, "Blankenberge", 1933, "Roger", "Wittewrongel" },
                    { 66, "Tokyo (JAP)", 1963, "Kimiko", "Yoshida" },
                    { 67, "", null, "Jacky", "Zegers" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 67);
        }
    }
}
