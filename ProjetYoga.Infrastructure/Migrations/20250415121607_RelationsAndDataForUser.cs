using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetYoga.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RelationsAndDataForUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "namePlaceEventYoga",
                table: "PlaceEventYoga",
                newName: "NamePlaceEventYoga");

            migrationBuilder.RenameColumn(
                name: "id_PlaceEventYoga",
                table: "PlaceEventYoga",
                newName: "Id_PlaceEventYoga");

            migrationBuilder.AddColumn<Guid>(
                name: "Salt",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Id_Address",
                table: "PlaceEventYoga",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_PlaceEventYoga",
                table: "Event",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Adept",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id_Address",
                table: "Adept",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id_Address = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NumberStreet = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id_Address);
                });

            migrationBuilder.CreateTable(
                name: "PaymentModes",
                columns: table => new
                {
                    Id_PaymentMode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_PaymentMode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentModes", x => x.Id_PaymentMode);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id_User = table.Column<int>(type: "int", nullable: false),
                    Id_Event = table.Column<int>(type: "int", nullable: false),
                    DateReservation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentModeId = table.Column<int>(type: "int", nullable: false),
                    Payed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => new { x.Id_User, x.Id_Event });
                    table.ForeignKey(
                        name: "FK_Reservation_Event_Id_Event",
                        column: x => x.Id_Event,
                        principalTable: "Event",
                        principalColumn: "Id_Event",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservation_PaymentModes_PaymentModeId",
                        column: x => x.PaymentModeId,
                        principalTable: "PaymentModes",
                        principalColumn: "Id_PaymentMode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservation_User_Id_User",
                        column: x => x.Id_User,
                        principalTable: "User",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_TypeSub",
                columns: table => new
                {
                    Id_User = table.Column<int>(type: "int", nullable: false),
                    Id_TypeSub = table.Column<int>(type: "int", nullable: false),
                    DateSub = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Payed = table.Column<bool>(type: "bit", nullable: false),
                    Id_PaymentMode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_TypeSub", x => new { x.Id_User, x.Id_TypeSub });
                    table.ForeignKey(
                        name: "FK_User_TypeSub_PaymentModes_Id_PaymentMode",
                        column: x => x.Id_PaymentMode,
                        principalTable: "PaymentModes",
                        principalColumn: "Id_PaymentMode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_TypeSub_TypeSub_Id_TypeSub",
                        column: x => x.Id_TypeSub,
                        principalTable: "TypeSub",
                        principalColumn: "Id_TypeSub",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_TypeSub_User_Id_User",
                        column: x => x.Id_User,
                        principalTable: "User",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id_User", "Email", "Password", "Salt" },
                values: new object[] { 1, "lauravdn@gmail.com", "	�����}�𛉻���jV�+Qyp�@���c\r�Z�������7�.7�~�\\�Oa����2�k��:", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.CreateIndex(
                name: "IX_User_Salt",
                table: "User",
                column: "Salt",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlaceEventYoga_Id_Address",
                table: "PlaceEventYoga",
                column: "Id_Address",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Event_Id_PlaceEventYoga",
                table: "Event",
                column: "Id_PlaceEventYoga");

            migrationBuilder.CreateIndex(
                name: "IX_Adept_Id_Address",
                table: "Adept",
                column: "Id_Address");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_Id_Event",
                table: "Reservation",
                column: "Id_Event");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_PaymentModeId",
                table: "Reservation",
                column: "PaymentModeId");

            migrationBuilder.CreateIndex(
                name: "IX_User_TypeSub_Id_PaymentMode",
                table: "User_TypeSub",
                column: "Id_PaymentMode");

            migrationBuilder.CreateIndex(
                name: "IX_User_TypeSub_Id_TypeSub",
                table: "User_TypeSub",
                column: "Id_TypeSub");

            migrationBuilder.AddForeignKey(
                name: "FK_Adept_Address_Id_Address",
                table: "Adept",
                column: "Id_Address",
                principalTable: "Address",
                principalColumn: "Id_Address",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_PlaceEventYoga_Id_PlaceEventYoga",
                table: "Event",
                column: "Id_PlaceEventYoga",
                principalTable: "PlaceEventYoga",
                principalColumn: "Id_PlaceEventYoga",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceEventYoga_Address_Id_Address",
                table: "PlaceEventYoga",
                column: "Id_Address",
                principalTable: "Address",
                principalColumn: "Id_Address",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adept_Address_Id_Address",
                table: "Adept");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_PlaceEventYoga_Id_PlaceEventYoga",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaceEventYoga_Address_Id_Address",
                table: "PlaceEventYoga");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "User_TypeSub");

            migrationBuilder.DropTable(
                name: "PaymentModes");

            migrationBuilder.DropIndex(
                name: "IX_User_Salt",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_PlaceEventYoga_Id_Address",
                table: "PlaceEventYoga");

            migrationBuilder.DropIndex(
                name: "IX_Event_Id_PlaceEventYoga",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Adept_Id_Address",
                table: "Adept");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id_User",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Salt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Id_Address",
                table: "PlaceEventYoga");

            migrationBuilder.DropColumn(
                name: "Id_PlaceEventYoga",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Adept");

            migrationBuilder.DropColumn(
                name: "Id_Address",
                table: "Adept");

            migrationBuilder.RenameColumn(
                name: "NamePlaceEventYoga",
                table: "PlaceEventYoga",
                newName: "namePlaceEventYoga");

            migrationBuilder.RenameColumn(
                name: "Id_PlaceEventYoga",
                table: "PlaceEventYoga",
                newName: "id_PlaceEventYoga");
        }
    }
}
