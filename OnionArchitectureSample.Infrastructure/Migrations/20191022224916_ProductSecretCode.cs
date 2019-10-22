using Microsoft.EntityFrameworkCore.Migrations;

namespace OnionArchitectureSample.Infrastructure.Migrations
{
    public partial class ProductSecretCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PrivateCode",
                table: "Products",
                defaultValue:"secrecCode",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrivateCode",
                table: "Products");
        }
    }
}
