using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Addeddataannotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "todos",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "todos",
                type: "varchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "authors",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AddColumn<string>(
                name: "AddressNo",
                table: "authors",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "authors",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "authors",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "45", "nuwara", "street1" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "45", "nuwara", "street2" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "45", "nuwara", "street3" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "45", "nuwara", "street4" });

            migrationBuilder.UpdateData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Due" },
                values: new object[] { new DateTime(2023, 3, 16, 23, 41, 19, 526, DateTimeKind.Local).AddTicks(4524), new DateTime(2023, 3, 21, 23, 41, 19, 526, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Due" },
                values: new object[] { new DateTime(2023, 3, 16, 23, 41, 19, 526, DateTimeKind.Local).AddTicks(4544), new DateTime(2023, 3, 21, 23, 41, 19, 526, DateTimeKind.Local).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Due" },
                values: new object[] { new DateTime(2023, 3, 16, 23, 41, 19, 526, DateTimeKind.Local).AddTicks(4546), new DateTime(2023, 3, 21, 23, 41, 19, 526, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Due" },
                values: new object[] { new DateTime(2023, 3, 16, 23, 41, 19, 526, DateTimeKind.Local).AddTicks(4548), new DateTime(2023, 3, 21, 23, 41, 19, 526, DateTimeKind.Local).AddTicks(4548) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressNo",
                table: "authors");

            migrationBuilder.DropColumn(
                name: "City",
                table: "authors");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "authors");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "todos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "todos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "authors",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Due" },
                values: new object[] { new DateTime(2023, 3, 15, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(980), new DateTime(2023, 3, 20, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Due" },
                values: new object[] { new DateTime(2023, 3, 15, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(995), new DateTime(2023, 3, 20, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Due" },
                values: new object[] { new DateTime(2023, 3, 15, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(997), new DateTime(2023, 3, 20, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Due" },
                values: new object[] { new DateTime(2023, 3, 15, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(999), new DateTime(2023, 3, 20, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(999) });
        }
    }
}
