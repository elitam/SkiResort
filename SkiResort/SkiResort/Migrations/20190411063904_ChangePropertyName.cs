using Microsoft.EntityFrameworkCore.Migrations;

namespace SkiResort.Migrations
{
    public partial class ChangePropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Rentals_RentalId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Length",
                table: "Hikes",
                newName: "AverageDuration");

            migrationBuilder.AlterColumn<string>(
                name: "Size",
                table: "Items",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "RentalId",
                table: "Items",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Rentals_RentalId",
                table: "Items",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Rentals_RentalId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "AverageDuration",
                table: "Hikes",
                newName: "Length");

            migrationBuilder.AlterColumn<double>(
                name: "Size",
                table: "Items",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "RentalId",
                table: "Items",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Rentals_RentalId",
                table: "Items",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
