using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTelerik.Migrations
{
    public partial class AttMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MetaScore",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MetaScore",
                table: "Movies");
        }
    }
}
