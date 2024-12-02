using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Articles.Migrations
{
    /// <inheritdoc />
    public partial class ArticleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "1 cooles Werkzeug", new DateTime(2024, 11, 30, 23, 9, 52, 361, DateTimeKind.Local).AddTicks(7292), "Schraube" },
                    { 2, "Haut rein!", new DateTime(2024, 11, 30, 23, 9, 52, 361, DateTimeKind.Local).AddTicks(7352), "Hammer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
