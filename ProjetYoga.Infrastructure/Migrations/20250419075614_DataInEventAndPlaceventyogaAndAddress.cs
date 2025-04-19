using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetYoga.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DataInEventAndPlaceventyogaAndAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id_Address", "City", "Country", "NumberStreet", "PostalCode", "Street" },
                values: new object[] { 1, "Bruxelles", "Belgique", 123, "1040", "Rue du parc Saint-Antoine" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id_Event",
                keyValue: 1,
                column: "Id_PlaceEventYoga",
                value: 1);

            migrationBuilder.InsertData(
                table: "PlaceEventYoga",
                columns: new[] { "Id_PlaceEventYoga", "Id_Address", "NamePlaceEventYoga" },
                values: new object[] { 1, 1, "Studio du parc Antoine" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaceEventYoga",
                keyColumn: "Id_PlaceEventYoga",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id_Address",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id_Event",
                keyValue: 1,
                column: "Id_PlaceEventYoga",
                value: 0);
        }
    }
}
