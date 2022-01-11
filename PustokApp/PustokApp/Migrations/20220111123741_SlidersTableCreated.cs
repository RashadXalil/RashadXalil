using Microsoft.EntityFrameworkCore.Migrations;

namespace PustokApp.Migrations
{
    public partial class SlidersTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 100, nullable: false),
                    Title1 = table.Column<string>(maxLength: 50, nullable: true),
                    Title2 = table.Column<string>(maxLength: 50, nullable: true),
                    Desc = table.Column<string>(maxLength: 150, nullable: true),
                    BtnText = table.Column<string>(maxLength: 50, nullable: true),
                    BtnUrl = table.Column<string>(maxLength: 200, nullable: true),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
