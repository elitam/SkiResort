using Microsoft.EntityFrameworkCore.Migrations;

namespace SkiResort.Migrations
{
    public partial class RemoveQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Items");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Items",
                nullable: false,
                defaultValue: 0);
        }
    }
}
