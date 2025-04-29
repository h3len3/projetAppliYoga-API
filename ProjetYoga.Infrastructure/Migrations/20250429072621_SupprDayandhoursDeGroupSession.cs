using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetYoga.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SupprDayandhoursDeGroupSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysAndHours",
                table: "GroupSession");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DaysAndHours",
                table: "GroupSession",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
