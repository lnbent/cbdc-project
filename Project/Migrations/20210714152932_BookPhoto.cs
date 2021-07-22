using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class BookPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookPhoto",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookPhoto",
                table: "Book");
        }
    }
}
