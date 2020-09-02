using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCRecipes.Migrations
{
    public partial class Meal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Meal",
                table: "Recipe",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Meal",
                table: "Recipe");
        }
    }
}
