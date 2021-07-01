using Microsoft.EntityFrameworkCore.Migrations;

namespace TeeBox.Infrastructure.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Holes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Holes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
