using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetYoga.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id_Address", "City", "Country", "NumberStreet", "PostalCode", "Street" },
                values: new object[] { 2, "Bxl", "Belgium", 42, "1000", "rue des marroniers" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id_User", "Email", "Password", "Salt" },
                values: new object[] { 3, "lykhun@gmail.com", "���?=�\0�J��M^/����DH׊�P��H�QNLO`�p*Rc<Q��^Ɗ�Z7������", new Guid("a802db70-4c4d-4e0d-80b1-9ec3f61608c8") });

            migrationBuilder.InsertData(
                table: "Adept",
                columns: new[] { "Id_User", "BirthDate", "Id_Address", "LastnameAdept", "NameAdept", "NissAdept", "PhoneAdept" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Ly", "Khun", "82050620316", "0000000" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adept",
                keyColumn: "Id_User",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id_Address",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id_User",
                keyValue: 3);
        }
    }
}
