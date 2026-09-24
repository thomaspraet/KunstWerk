using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KunstWerk.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeddataForArtists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "FirstName", "LastName", "PlaceOfBirth", "YearOfBirth" },
                values: new object[] { 1, "Nancy", "Bailleux", "Antwerpen", "1964" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
