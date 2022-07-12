using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImageUploadCrude.Data.Migrations
{
    public partial class ProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsName = table.Column<string>(maxLength: 20, nullable: false),
                    ProductsModel = table.Column<string>(maxLength: 20, nullable: false),
                    Sku = table.Column<string>(maxLength: 20, nullable: false),
                    ProductsPrice = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
