using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetYoga.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class heritages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "User",
                newName: "Id_User");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Event",
                newName: "Id_Event");

            migrationBuilder.CreateTable(
                name: "Adept",
                columns: table => new
                {
                    Id_User = table.Column<int>(type: "int", nullable: false),
                    NameAdept = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastnameAdept = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NissAdept = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    PhoneAdept = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adept", x => x.Id_User);
                    table.ForeignKey(
                        name: "FK_Adept_User_Id_User",
                        column: x => x.Id_User,
                        principalTable: "User",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupSession",
                columns: table => new
                {
                    Id_Event = table.Column<int>(type: "int", nullable: false),
                    DaysAndHours = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupSession", x => x.Id_Event);
                    table.ForeignKey(
                        name: "FK_GroupSession_Event_Id_Event",
                        column: x => x.Id_Event,
                        principalTable: "Event",
                        principalColumn: "Id_Event",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndividualSession",
                columns: table => new
                {
                    Id_Event = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualSession", x => x.Id_Event);
                    table.ForeignKey(
                        name: "FK_IndividualSession_Event_Id_Event",
                        column: x => x.Id_Event,
                        principalTable: "Event",
                        principalColumn: "Id_Event",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    Id_User = table.Column<int>(type: "int", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Instructor")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.Id_User);
                    table.ForeignKey(
                        name: "FK_Instructor_User_Id_User",
                        column: x => x.Id_User,
                        principalTable: "User",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adept");

            migrationBuilder.DropTable(
                name: "GroupSession");

            migrationBuilder.DropTable(
                name: "IndividualSession");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.RenameColumn(
                name: "Id_User",
                table: "User",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id_Event",
                table: "Event",
                newName: "Id");
        }
    }
}
