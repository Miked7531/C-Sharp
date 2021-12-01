using Microsoft.EntityFrameworkCore.Migrations;

namespace L08HandsOn.Data.Migrations
{
    public partial class MoviePlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Vname",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vpath",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vname",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Vpath",
                table: "Movies");
        }
    }
}
