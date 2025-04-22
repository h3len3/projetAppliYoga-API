using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetYoga.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id_Address", "City", "Country", "NumberStreet", "PostalCode", "Street" },
                values: new object[] { 1, "Bruxelles", "Belgique", 123, "1040", "Rue du parc Saint-Antoine" });

            migrationBuilder.InsertData(
                table: "PlaceEventYoga",
                columns: new[] { "Id_PlaceEventYoga", "Id_Address", "NamePlaceEventYoga" },
                values: new object[] { 1, 1, "Studio du Parc Antoine" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id_Event", "Available", "Description", "EndDate", "Id_PlaceEventYoga", "MaxSub", "MinSub", "StartDate", "Title" },
                values: new object[] { 1, true, "chants, postures, méditation", new DateTime(2025, 5, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, 15, 3, new DateTime(2025, 5, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "matinée viniyoga" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id_Event",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlaceEventYoga",
                keyColumn: "Id_PlaceEventYoga",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id_Address",
                keyValue: 1);
        }
    }
}
