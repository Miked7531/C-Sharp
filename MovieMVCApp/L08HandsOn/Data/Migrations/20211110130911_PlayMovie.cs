using Microsoft.EntityFrameworkCore.Migrations;

namespace L08HandsOn.Data.Migrations
{
    public partial class PlayMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlayMovie",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayMovie",
                table: "Movies");
        }
    }
}
