using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeDine.Migrations
{
    public partial class initial18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "<h3class='mt-3'>Online Order</h3>");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "<h3 class='mt-3'>Free delivery</h3>");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Button", "Paragraph", "Title" },
                values: new object[] { "<a class='text-white'>View Menu</a>", " <h1 class='text-white'>Fresh,Delicious meal to reach your optimum health and fitness</h1>", " <span class='text-white'> Welcome to restuarant</span> " });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Button", "Paragraph", "Title" },
                values: new object[] { "<a class='text-white'>View Menu</a>", "<h1 class='text-white'>Good food starts with good ingridients.Have a great time with us</h1>", " <span class='text-white'>Welcome to restuarant</span> " });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Button", "Paragraph", "Title" },
                values: new object[] { "<a class='text-white'>View Menu</a>", "<h1 class='text-white'>We deliver good quality food with great service to our customers</h1>", " <span class='text-white'>Welcome to restuarant</span> " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "<h3 class='mt - 3'>Online Order</h3>");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "   <h3 class='mt - 3'>Free delivery</h3>");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Button", "Paragraph", "Title" },
                values: new object[] { "<a>View Menu</a>", " <h1>Fresh,Delicious meal to reach your optimum health and fitness</h1>", " <span>Welcome to restuarant</span> " });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Button", "Paragraph", "Title" },
                values: new object[] { "<a>View Menu</a>", "<h1>Good food starts with good ingridients.Have a great time with us</h1>", " <span>Welcome to restuarant</span> " });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Button", "Paragraph", "Title" },
                values: new object[] { "<a>View Menu</a>", "<h1>We deliver good quality food with great service to our customers</h1>", " <span>Welcome to restuarant</span> " });
        }
    }
}
