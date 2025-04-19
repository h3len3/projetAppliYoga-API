using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetYoga.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TestHasDataEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id_Event", "Available", "Description", "EndDate", "Id_PlaceEventYoga", "MaxSub", "MinSub", "StartDate", "Title" },
                values: new object[] { 1, true, "Chants, postures, méditation", new DateTime(2025, 5, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 0, 15, 3, new DateTime(2025, 5, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "Matinée Viniyoga" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id_Event",
                keyValue: 1);
        }
    }
}
