using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetYoga.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PaymentModeSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PaymentModes",
                columns: new[] { "Id_PaymentMode", "Name_PaymentMode" },
                values: new object[] { 1, "Aucun" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentModes",
                keyColumn: "Id_PaymentMode",
                keyValue: 1);
        }
    }
}
