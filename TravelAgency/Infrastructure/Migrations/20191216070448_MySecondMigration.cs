using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class MySecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Tour",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopCartId",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "Order",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Tour");

            migrationBuilder.DropColumn(
                name: "ShopCartId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Order");
        }
    }
}
