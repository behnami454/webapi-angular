using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations.Cups
{
    public partial class CupsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cups",
                columns: table => new
                {
                    CupsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CupsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CupsYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CupsPhotoFileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cups", x => x.CupsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cups");
        }
    }
}
