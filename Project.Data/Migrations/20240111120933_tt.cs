using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class tt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductList_OrderList_OrderId",
                table: "ProductList");

            migrationBuilder.DropIndex(
                name: "IX_ProductList_OrderId",
                table: "ProductList");

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrdersId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_OrderList_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "OrderList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_ProductList_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "ProductList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdactToOrderList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    count = table.Column<int>(type: "int", nullable: false),
                    orderIdId = table.Column<int>(type: "int", nullable: false),
                    productIdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdactToOrderList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdactToOrderList_OrderList_orderIdId",
                        column: x => x.orderIdId,
                        principalTable: "OrderList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdactToOrderList_ProductList_productIdId",
                        column: x => x.productIdId,
                        principalTable: "ProductList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductsId",
                table: "OrderProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdactToOrderList_orderIdId",
                table: "ProdactToOrderList",
                column: "orderIdId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdactToOrderList_productIdId",
                table: "ProdactToOrderList",
                column: "productIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "ProdactToOrderList");

            migrationBuilder.CreateIndex(
                name: "IX_ProductList_OrderId",
                table: "ProductList",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductList_OrderList_OrderId",
                table: "ProductList",
                column: "OrderId",
                principalTable: "OrderList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
