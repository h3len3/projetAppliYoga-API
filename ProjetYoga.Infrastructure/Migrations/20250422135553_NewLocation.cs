using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetYoga.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlaceEventYoga",
                columns: new[] { "Id_PlaceEventYoga", "Id_Address", "NamePlaceEventYoga" },
                values: new object[] { 2, 2, "Digital City" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaceEventYoga",
                keyColumn: "Id_PlaceEventYoga",
                keyValue: 2);
        }
    }
}
