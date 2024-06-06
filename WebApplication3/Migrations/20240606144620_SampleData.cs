using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class SampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "ClassRoomId", "Description" },
                values: new object[,]
                {
                    { 1, "1A" },
                    { 2, "2A" },
                    { 3, "3A" },
                    { 4, "4A" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "ClassRoomId", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, 1, "A", "A" },
                    { 2, 2, "B", "B" },
                    { 3, 3, "C", "C" },
                    { 4, 4, "D", "D" },
                    { 5, 1, "E", "E" },
                    { 6, 2, "F", "F" },
                    { 7, 3, "G", "G" },
                    { 8, 4, "H", "H" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "ClassRoomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "ClassRoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "ClassRoomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "ClassRoomId",
                keyValue: 4);
        }
    }
}
