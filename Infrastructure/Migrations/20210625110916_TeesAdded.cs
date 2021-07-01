using Microsoft.EntityFrameworkCore.Migrations;

namespace TeeBox.Infrastructure.Migrations
{
    public partial class TeesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeeColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeeColors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Distance = table.Column<double>(type: "float", nullable: false),
                    TeeColorId = table.Column<int>(type: "int", nullable: false),
                    HoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Sobienie Królewskie G&C" });

            migrationBuilder.InsertData(
                table: "Holes",
                columns: new[] { "Id", "Hcp", "Number", "Par" },
                values: new object[,]
                {
                    { 18, (short)12, (short)18, (short)5 },
                    { 17, (short)18, (short)17, (short)4 },
                    { 16, (short)11, (short)16, (short)3 },
                    { 15, (short)5, (short)15, (short)5 },
                    { 14, (short)1, (short)14, (short)4 },
                    { 13, (short)3, (short)13, (short)4 },
                    { 12, (short)15, (short)12, (short)3 },
                    { 11, (short)9, (short)11, (short)4 },
                    { 10, (short)10, (short)10, (short)4 },
                    { 8, (short)7, (short)8, (short)5 },
                    { 7, (short)2, (short)7, (short)4 },
                    { 6, (short)4, (short)6, (short)4 },
                    { 5, (short)17, (short)5, (short)4 },
                    { 4, (short)16, (short)4, (short)3 },
                    { 3, (short)13, (short)3, (short)5 },
                    { 2, (short)14, (short)2, (short)3 },
                    { 1, (short)8, (short)1, (short)4 },
                    { 9, (short)6, (short)9, (short)3 }
                });

            migrationBuilder.InsertData(
                table: "TeeColors",
                columns: new[] { "Id", "Color", "CourseId" },
                values: new object[,]
                {
                    { 1, 0, 1 },
                    { 2, 1, 1 },
                    { 3, 2, 1 },
                    { 4, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tees",
                columns: new[] { "Id", "Distance", "HoleId", "TeeColorId" },
                values: new object[,]
                {
                    { 5, 138.0, 2, 1 },
                    { 56, 351.0, 14, 4 },
                    { 55, 382.0, 14, 3 },
                    { 54, 408.0, 14, 2 },
                    { 53, 418.0, 14, 1 },
                    { 52, 331.0, 13, 4 },
                    { 51, 333.0, 13, 3 },
                    { 57, 522.0, 15, 1 },
                    { 50, 337.0, 13, 2 },
                    { 48, 142.0, 12, 4 },
                    { 47, 150.0, 12, 3 },
                    { 46, 161.0, 12, 2 },
                    { 45, 174.0, 12, 1 },
                    { 44, 305.0, 11, 4 },
                    { 43, 324.0, 11, 3 },
                    { 49, 349.0, 13, 1 },
                    { 42, 347.0, 11, 2 },
                    { 58, 495.0, 15, 2 },
                    { 60, 416.0, 15, 4 }
                });

            migrationBuilder.InsertData(
                table: "Tees",
                columns: new[] { "Id", "Distance", "HoleId", "TeeColorId" },
                values: new object[,]
                {
                    { 1, 356.0, 1, 1 },
                    { 2, 333.0, 1, 2 },
                    { 72, 379.0, 18, 4 },
                    { 71, 446.0, 18, 3 },
                    { 70, 460.0, 18, 2 },
                    { 69, 481.0, 18, 1 },
                    { 59, 458.0, 15, 3 },
                    { 68, 240.0, 17, 4 },
                    { 66, 276.0, 17, 2 },
                    { 65, 304.0, 17, 1 },
                    { 64, 108.0, 16, 4 },
                    { 63, 136.0, 16, 3 },
                    { 62, 168.0, 16, 2 },
                    { 61, 178.0, 16, 1 },
                    { 67, 260.0, 17, 3 },
                    { 41, 368.0, 11, 1 },
                    { 40, 278.0, 10, 4 },
                    { 39, 327.0, 10, 3 },
                    { 19, 289.0, 5, 3 },
                    { 18, 304.0, 5, 2 },
                    { 17, 313.0, 5, 1 },
                    { 16, 101.0, 4, 4 },
                    { 15, 160.0, 4, 3 },
                    { 14, 171.0, 4, 2 },
                    { 20, 275.0, 5, 4 },
                    { 13, 183.0, 4, 1 },
                    { 11, 434.0, 3, 3 },
                    { 10, 453.0, 3, 2 },
                    { 9, 460.0, 3, 1 },
                    { 8, 119.0, 2, 4 },
                    { 7, 129.0, 2, 3 },
                    { 6, 131.0, 2, 2 },
                    { 12, 398.0, 3, 4 },
                    { 21, 316.0, 6, 1 },
                    { 22, 294.0, 6, 2 },
                    { 23, 255.0, 6, 3 },
                    { 38, 350.0, 10, 2 },
                    { 37, 371.0, 10, 1 },
                    { 36, 134.0, 9, 4 },
                    { 35, 145.0, 9, 3 },
                    { 34, 156.0, 9, 2 },
                    { 33, 165.0, 9, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tees",
                columns: new[] { "Id", "Distance", "HoleId", "TeeColorId" },
                values: new object[,]
                {
                    { 32, 398.0, 8, 4 },
                    { 31, 440.0, 8, 3 },
                    { 30, 473.0, 8, 2 },
                    { 3, 312.0, 1, 3 },
                    { 28, 347.0, 7, 4 },
                    { 27, 387.0, 7, 3 },
                    { 26, 414.0, 7, 2 },
                    { 25, 433.0, 7, 1 },
                    { 24, 247.0, 6, 4 },
                    { 4, 293.0, 1, 4 },
                    { 29, 496.0, 8, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeeColors");

            migrationBuilder.DropTable(
                name: "Tees");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Holes",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
