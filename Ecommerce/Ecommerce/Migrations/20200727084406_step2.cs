using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class step2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ViewapplicationData");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ViewapplicationData",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportID = table.Column<int>(type: "int", nullable: false),
                    paramID = table.Column<int>(type: "int", nullable: false),
                    parameterArabicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parameterEnglishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paramrepID = table.Column<int>(type: "int", nullable: false),
                    progID = table.Column<int>(type: "int", nullable: false),
                    progarmArabicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    progarmEnglishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    repID = table.Column<int>(type: "int", nullable: false),
                    reportArabicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reportEnglishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    repprogID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewapplicationData", x => x.ID);
                });
        }
    }
}
