using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjetYoga.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Dataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { 3, "lykhun@gmail.com", "���?=�\0�J��M^/����DH׊�P��H�QNLO`�p*Rc<Q��^Ɗ�Z7������", new Guid("a802db70-4c4d-4e0d-80b1-9ec3f61608c8") });

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
                values: new object[] { 1, true, "chants, postures, méditation", new DateTime(2025, 5, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, 15, 3, new DateTime(2025, 5, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "matinée viniyoga" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adept",
                keyColumn: "Id_User",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id_Event",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlaceEventYoga",
                keyColumn: "Id_PlaceEventYoga",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id_Address",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlaceEventYoga",
                keyColumn: "Id_PlaceEventYoga",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id_User",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id_Address",
                keyValue: 1);
        }
    }
}
