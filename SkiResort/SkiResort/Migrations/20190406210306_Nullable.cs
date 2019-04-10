using Microsoft.EntityFrameworkCore.Migrations;

namespace SkiResort.Migrations
{
    public partial class Nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LiftId",
                table: "Trails",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LiftId",
                table: "Trails",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
