using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalHouseApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Species = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SubSpecies = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Name", "Species", "SubSpecies" },
                values: new object[,]
                {
                    { 1, 1, "Goji", "Dog", "Pitbull" },
                    { 2, 1, "Darryl", "Dog", "Australian Cattle Dog" },
                    { 3, 6, "ChopSticks", "Cat", "Siamese" },
                    { 4, 2, "FuzzyWasHe", "Cat", "Persian" },
                    { 5, 3, "Olaf", "Dog", "Wolfhound" },
                    { 6, 3, "Tuna", "Cat", "Snowshoe" },
                    { 8, 2, "Shark", "Dog", "Pitbull" },
                    { 9, 2, "Bologna", "Dog", "Pitbull" },
                    { 10, 2, "Steeze", "Cat", "Abyssinian" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
