using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class step1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishName = table.Column<string>(nullable: true),
                    ArabicName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ViewapplicationData",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    progID = table.Column<int>(nullable: false),
                    progarmEnglishName = table.Column<string>(nullable: true),
                    progarmArabicName = table.Column<string>(nullable: true),
                    repID = table.Column<int>(nullable: false),
                    reportEnglishName = table.Column<string>(nullable: true),
                    reportArabicName = table.Column<string>(nullable: true),
                    repprogID = table.Column<int>(nullable: false),
                    ReportID = table.Column<int>(nullable: false),
                    paramID = table.Column<int>(nullable: false),
                    parameterEnglishName = table.Column<string>(nullable: true),
                    parameterArabicName = table.Column<string>(nullable: true),
                    paramrepID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewapplicationData", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rports",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishName = table.Column<string>(nullable: true),
                    ArabicName = table.Column<string>(nullable: true),
                    ApplicationProgramID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rports_Program_ApplicationProgramID",
                        column: x => x.ApplicationProgramID,
                        principalTable: "Program",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishName = table.Column<string>(nullable: true),
                    ArabicName = table.Column<string>(nullable: true),
                    ReportID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Parameters_Rports_ReportID",
                        column: x => x.ReportID,
                        principalTable: "Rports",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parameters_ReportID",
                table: "Parameters",
                column: "ReportID");

            migrationBuilder.CreateIndex(
                name: "IX_Rports_ApplicationProgramID",
                table: "Rports",
                column: "ApplicationProgramID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parameters");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ViewapplicationData");

            migrationBuilder.DropTable(
                name: "Rports");

            migrationBuilder.DropTable(
                name: "Program");
        }
    }
}
