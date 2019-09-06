using Microsoft.EntityFrameworkCore.Migrations;

namespace BrianFarrellAndMariaDiazPies.Migrations
{
    public partial class PieModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "InStock",
                table: "Pies",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InStock",
                table: "Pies");
        }
    }
}
