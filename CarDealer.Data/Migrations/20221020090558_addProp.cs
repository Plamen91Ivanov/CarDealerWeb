using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDealerWeb.Data.Migrations
{
    public partial class addProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "Cars",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Make",
                table: "Cars");
        }
    }
}
