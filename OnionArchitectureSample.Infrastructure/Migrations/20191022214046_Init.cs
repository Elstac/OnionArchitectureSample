using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnionArchitectureSample.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id","Name", "Price" },
                values: new object[] {Guid.NewGuid(), "Product1", 10f }
                );

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id","Name", "Price" },
                values: new object[] {Guid.NewGuid(), "Product2", 20f }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
