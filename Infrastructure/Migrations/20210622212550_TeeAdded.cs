using Microsoft.EntityFrameworkCore.Migrations;

namespace TeeBox.Infrastructure.Migrations
{
    public partial class TeeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Holes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<short>(
                name: "Hcp",
                table: "Holes",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Par",
                table: "Holes",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Holes");

            migrationBuilder.DropColumn(
                name: "Hcp",
                table: "Holes");

            migrationBuilder.DropColumn(
                name: "Par",
                table: "Holes");
        }
    }
}
