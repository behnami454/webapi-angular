using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations.Legends
{
    public partial class LegendsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Legends",
                columns: table => new
                {
                    LegendsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LegendsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegendsApps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegendsPhotoFileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legends", x => x.LegendsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Legends");
        }
    }
}
