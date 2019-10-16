using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeDine.Migrations
{
    public partial class initital22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Button",
                value: "<a class='btn btn-main mr-3' data-swiper-parallax='500'>View Menu</a>");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Button",
                value: "<a class='btn btn-main mr-3' data-swiper-parallax='500'>View Menu</a>");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Button",
                value: "<a class='btn btn-main mr-3' data-swiper-parallax='500'>View Menu</a>");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Button",
                value: "<a class='text-white'>View Menu</a>");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Button",
                value: "<a class='text-white'>View Menu</a>");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Button",
                value: "<a class='text-white'>View Menu</a>");
        }
    }
}
