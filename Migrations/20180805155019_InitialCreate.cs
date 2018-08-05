using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Meercart.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartList",
                columns: table => new
                {
                    CartId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MasterMember = table.Column<string>(nullable: true),
                    ShoppingList = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartList", x => x.CartId);
                });

            migrationBuilder.CreateTable(
                name: "MemberList",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberList", x => x.MemberId);
                });

            migrationBuilder.CreateTable(
                name: "ProductList",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductList", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "StoreList",
                columns: table => new
                {
                    StoreId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StoreName = table.Column<string>(nullable: true),
                    StorePhone = table.Column<string>(nullable: true),
                    StoreMemo = table.Column<string>(nullable: true),
                    StoreLocation = table.Column<string>(nullable: true),
                    StoreMiniCharge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreList", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingItem",
                columns: table => new
                {
                    ShoppingName = table.Column<string>(nullable: true),
                    ShoppingItemId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShoppingNumber = table.Column<int>(nullable: false),
                    ShoppingPrice = table.Column<int>(nullable: false),
                    ShoppingOwner = table.Column<string>(nullable: true),
                    ShoppingDate = table.Column<DateTime>(nullable: false),
                    CartId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingItem", x => x.ShoppingItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingItem_CartList_CartId",
                        column: x => x.CartId,
                        principalTable: "CartList",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingItem_CartId",
                table: "ShoppingItem",
                column: "CartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberList");

            migrationBuilder.DropTable(
                name: "ProductList");

            migrationBuilder.DropTable(
                name: "ShoppingItem");

            migrationBuilder.DropTable(
                name: "StoreList");

            migrationBuilder.DropTable(
                name: "CartList");
        }
    }
}
