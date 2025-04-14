using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetYoga.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class specialEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpecialEvent",
                columns: table => new
                {
                    Id_Event = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialEvent", x => x.Id_Event);
                    table.ForeignKey(
                        name: "FK_SpecialEvent_Event_Id_Event",
                        column: x => x.Id_Event,
                        principalTable: "Event",
                        principalColumn: "Id_Event",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecialEvent");
        }
    }
}
