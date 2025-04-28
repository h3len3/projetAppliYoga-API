using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjetYoga.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "TypeSub",
                columns: table => new
                {
                    Id_TypeSub = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTypeSub = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DescriptionTypeSub = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeSub", x => x.Id_TypeSub);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id_User = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id_User);
                });

            migrationBuilder.CreateTable(
                name: "PlaceEventYoga",
                columns: table => new
                {
                    Id_PlaceEventYoga = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePlaceEventYoga = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Id_Address = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceEventYoga", x => x.Id_PlaceEventYoga);
                    table.ForeignKey(
                        name: "FK_PlaceEventYoga_Address_Id_Address",
                        column: x => x.Id_Address,
                        principalTable: "Address",
                        principalColumn: "Id_Address",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Adept",
                columns: table => new
                {
                    Id_User = table.Column<int>(type: "int", nullable: false),
                    NameAdept = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastnameAdept = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NissAdept = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    PhoneAdept = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Address = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adept", x => x.Id_User);
                    table.ForeignKey(
                        name: "FK_Adept_Address_Id_Address",
                        column: x => x.Id_Address,
                        principalTable: "Address",
                        principalColumn: "Id_Address",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adept_User_Id_User",
                        column: x => x.Id_User,
                        principalTable: "User",
                        principalColumn: "Id_User",
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

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id_Event = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaxSub = table.Column<int>(type: "int", nullable: false),
                    MinSub = table.Column<int>(type: "int", nullable: true),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    Id_PlaceEventYoga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id_Event);
                    table.ForeignKey(
                        name: "FK_Event_PlaceEventYoga_Id_PlaceEventYoga",
                        column: x => x.Id_PlaceEventYoga,
                        principalTable: "PlaceEventYoga",
                        principalColumn: "Id_PlaceEventYoga",
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

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id_Address", "City", "Country", "NumberStreet", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, "Bruxelles", "Belgique", 123, "1040", "Rue du parc Saint-Antoine" },
                    { 2, "Bxl", "Belgium", 42, "1000", "rue des marroniers" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id_User", "Email", "Password", "Salt" },
                values: new object[,]
                {
                    { 1, "lauravdn@gmail.com", "	�����}�𛉻���jV�+Qyp�@���c\r�Z�������7�.7�~�\\�Oa����2�k��:", new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, "lykhun@gmail.com", "���?=�\0�J��M^/����DH׊�P��H�QNLO`�p*Rc<Q��^Ɗ�Z7������", new Guid("a802db70-4c4d-4e0d-80b1-9ec3f61608c8") }
                });

            migrationBuilder.InsertData(
                table: "Adept",
                columns: new[] { "Id_User", "BirthDate", "Id_Address", "LastnameAdept", "NameAdept", "NissAdept", "PhoneAdept" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Ly", "Khun", "82050620316", "0000000" });

            migrationBuilder.InsertData(
                table: "PlaceEventYoga",
                columns: new[] { "Id_PlaceEventYoga", "Id_Address", "NamePlaceEventYoga" },
                values: new object[,]
                {
                    { 1, 1, "Studio du Parc Antoine" },
                    { 2, 2, "Digital City" }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id_Event", "Available", "Description", "EndDate", "Id_PlaceEventYoga", "MaxSub", "MinSub", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1, true, "chants, postures, méditation", new DateTime(2025, 5, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, 15, 3, new DateTime(2025, 5, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "matinée viniyoga" },
                    { 2, true, "chants, postures, méditation", new DateTime(2025, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, 15, 3, new DateTime(2025, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "Souper des anciens" }
                });

            migrationBuilder.InsertData(
                table: "SpecialEvent",
                column: "Id_Event",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Adept_Id_Address",
                table: "Adept",
                column: "Id_Address");

            migrationBuilder.CreateIndex(
                name: "IX_Event_Id_PlaceEventYoga",
                table: "Event",
                column: "Id_PlaceEventYoga");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceEventYoga_Id_Address",
                table: "PlaceEventYoga",
                column: "Id_Address",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_Id_Event",
                table: "Reservation",
                column: "Id_Event");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_PaymentModeId",
                table: "Reservation",
                column: "PaymentModeId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Salt",
                table: "User",
                column: "Salt",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_TypeSub_Id_PaymentMode",
                table: "User_TypeSub",
                column: "Id_PaymentMode");

            migrationBuilder.CreateIndex(
                name: "IX_User_TypeSub_Id_TypeSub",
                table: "User_TypeSub",
                column: "Id_TypeSub");
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

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "SpecialEvent");

            migrationBuilder.DropTable(
                name: "User_TypeSub");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "PaymentModes");

            migrationBuilder.DropTable(
                name: "TypeSub");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "PlaceEventYoga");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
