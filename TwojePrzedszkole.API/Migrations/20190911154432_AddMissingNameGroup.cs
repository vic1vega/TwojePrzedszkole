using Microsoft.EntityFrameworkCore.Migrations;

namespace TwojePrzedszkole.API.Migrations
{
    public partial class AddMissingNameGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PhotoGallerys",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ChildGroups",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "PhotoGallerys");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ChildGroups");
        }
    }
}
