using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketPlace.DAL.EF.Migrations
{
    public partial class EditSitesetting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutUs",
                table: "SiteSettings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutUs",
                table: "SiteSettings");
        }
    }
}
