using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeDine.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Paragraph = table.Column<string>(maxLength: 100, nullable: false),
                    Button = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Button", "Image", "Paragraph", "Title" },
                values: new object[] { 1, "<a>View Menu</a>", "slide-1.jpg", " <h1>Fresh,Delicious meal to reach your optimum health and fitness</h1>", " <span>Welcome to restuarant</span> " });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Button", "Image", "Paragraph", "Title" },
                values: new object[] { 2, "<a>View Menu</a>", "slide-2.jpg", "<h1>Good food starts with good ingridients.Have a great time with us</h1>", " <span>Welcome to restuarant</span> " });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Button", "Image", "Paragraph", "Title" },
                values: new object[] { 3, "<a>View Menu</a>", "slide-3.jpg", "<h1>We deliver good quality food with great service to our customers</h1>", " <span>Welcome to restuarant</span> " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
