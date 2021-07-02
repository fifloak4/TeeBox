using Microsoft.EntityFrameworkCore.Migrations;

namespace TeeBox.Infrastructure.Migrations
{
    public partial class CourseIdAddedToHole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Holes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OriginalMaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousId = table.Column<int>(type: "int", nullable: false),
                    NextId = table.Column<int>(type: "int", nullable: false),
                    HoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OriginalMaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SvgMaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalId = table.Column<int>(type: "int", nullable: false),
                    PreviousId = table.Column<int>(type: "int", nullable: false),
                    NextId = table.Column<int>(type: "int", nullable: false),
                    HoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SvgMaps", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CourseId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OriginalMaps");

            migrationBuilder.DropTable(
                name: "SvgMaps");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Holes");
        }
    }
}
