using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameShopUI.Data.Migrations
{
    /// <inheritdoc />
    public partial class addauthortogame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Game",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Game");
        }
    }
}
