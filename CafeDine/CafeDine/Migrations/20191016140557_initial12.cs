using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeDine.Migrations
{
    public partial class initial12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Logo",
                value: " <i class='icofont-tasks'></i>");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Logo",
                value: " <i class='icofont - tasks'></i>");
        }
    }
}
