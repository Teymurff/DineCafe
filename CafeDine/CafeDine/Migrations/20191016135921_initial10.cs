using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeDine.Migrations
{
    public partial class initial10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Logo = table.Column<string>(maxLength: 255, nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Paragraph = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Logo", "Paragraph", "Title" },
                values: new object[] { 1, " <i class='icofont-soup-bowl'></i>", "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia animi ipsam obcaecati.</p>", "<h3 class='mt-3'>Delicious Food</h3>" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Logo", "Paragraph", "Title" },
                values: new object[] { 2, " <i class='icofont - tasks'></i>", "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia animi ipsam obcaecati.</p>", "<h3 class='mt - 3'>Online Order</h3>" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Logo", "Paragraph", "Title" },
                values: new object[] { 3, "<i class='icofont-map-pins'></i>", "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia animi ipsam obcaecati.</p>", "   <h3 class='mt - 3'>Free delivery</h3>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
