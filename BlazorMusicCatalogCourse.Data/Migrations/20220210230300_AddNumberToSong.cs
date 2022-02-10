using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorMusicCatalogCourse.Data.Migrations
{
    public partial class AddNumberToSong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Song",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Song");
        }
    }
}
