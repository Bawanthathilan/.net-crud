using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuthorEntityAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Bawantha Thilan" },
                    { 2, "John Doe" },
                    { 3, "John Carm" },
                    { 4, "Garfield" }
                });

            migrationBuilder.UpdateData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedAt", "Due" },
                values: new object[] { 1, new DateTime(2023, 3, 15, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(980), new DateTime(2023, 3, 20, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.InsertData(
                table: "todos",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2023, 3, 15, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(995), "get some text book for school 2", new DateTime(2023, 3, 20, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(996), 0, "Get books from school 2" },
                    { 3, 2, new DateTime(2023, 3, 15, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(997), "get some text book for school 3", new DateTime(2023, 3, 20, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(998), 0, "Get books from school 3" },
                    { 4, 2, new DateTime(2023, 3, 15, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(999), "get some text book for school 4", new DateTime(2023, 3, 20, 22, 47, 52, 610, DateTimeKind.Local).AddTicks(999), 0, "Get books from school 4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_todos_AuthorId",
                table: "todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_todos_authors_AuthorId",
                table: "todos",
                column: "AuthorId",
                principalTable: "authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_todos_authors_AuthorId",
                table: "todos");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropIndex(
                name: "IX_todos_AuthorId",
                table: "todos");

            migrationBuilder.DeleteData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "todos");

            migrationBuilder.UpdateData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Due" },
                values: new object[] { new DateTime(2023, 3, 15, 21, 36, 5, 160, DateTimeKind.Local).AddTicks(9454), new DateTime(2023, 3, 20, 21, 36, 5, 160, DateTimeKind.Local).AddTicks(9468) });
        }
    }
}
