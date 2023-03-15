using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "todos",
                columns: new[] { "Id", "CreatedAt", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, new DateTime(2023, 3, 15, 21, 36, 5, 160, DateTimeKind.Local).AddTicks(9454), "get some text book for school", new DateTime(2023, 3, 20, 21, 36, 5, 160, DateTimeKind.Local).AddTicks(9468), 0, "Get books from school" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
