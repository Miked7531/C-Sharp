using Microsoft.EntityFrameworkCore.Migrations;

namespace L08HandsOn.Data.Migrations
{
    public partial class TimesPlayed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TimesPlayed",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimesPlayed",
                table: "Movies");
        }
    }
}
