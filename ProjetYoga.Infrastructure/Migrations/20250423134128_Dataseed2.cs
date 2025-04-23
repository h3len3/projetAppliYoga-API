using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetYoga.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Dataseed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id_Event", "Available", "Description", "EndDate", "Id_PlaceEventYoga", "MaxSub", "MinSub", "StartDate", "Title" },
                values: new object[] { 2, true, "chants, postures, méditation", new DateTime(2025, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, 15, 3, new DateTime(2025, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Souper des anciens" });

            migrationBuilder.InsertData(
                table: "SpecialEvent",
                column: "Id_Event",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SpecialEvent",
                keyColumn: "Id_Event",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id_Event",
                keyValue: 2);
        }
    }
}
