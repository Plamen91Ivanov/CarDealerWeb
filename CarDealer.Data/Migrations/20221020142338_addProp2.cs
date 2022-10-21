using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDealerWeb.Data.Migrations
{
    public partial class addProp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Customers_CustormerId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_CustormerId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "CustormerId",
                table: "Sales");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Sales",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Customers_CustomerId",
                table: "Sales",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Customers_CustomerId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Sales");

            migrationBuilder.AddColumn<int>(
                name: "CustormerId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustormerId",
                table: "Sales",
                column: "CustormerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Customers_CustormerId",
                table: "Sales",
                column: "CustormerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
