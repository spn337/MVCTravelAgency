using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCTravelAgency.Migrations
{
    public partial class AddtblTownsandtblCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 300, nullable: false),
                    Img = table.Column<string>(nullable: true),
                    ImgLarge = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: false),
                    DepartureTown = table.Column<string>(maxLength: 30, nullable: false),
                    Period = table.Column<int>(nullable: false),
                    IsNightCrossing = table.Column<bool>(nullable: false),
                    Countries = table.Column<string>(maxLength: 300, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    DepartureDate = table.Column<string>(nullable: false),
                    isFavorite = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_CategoryId",
                table: "Tours",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
