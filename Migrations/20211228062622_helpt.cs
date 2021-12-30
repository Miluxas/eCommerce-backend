using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommercebackend.Migrations.ECommerce
{
    public partial class helpt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
                name: "FK_Area_Country_CountryId",
                table: "Area");

            migrationBuilder.DropForeignKey(
                name: "FK_WarehouseArea_Area_WarehouseId",
                table: "WarehouseArea");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Area",
                table: "Area");

            migrationBuilder.RenameTable(
                name: "Area",
                newName: "Areas");

            migrationBuilder.RenameIndex(
                name: "IX_Area_CountryId",
                table: "Areas",
                newName: "IX_Areas_CountryId");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PurchaseReceiveItem",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PurchaseItem",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Areas",
                table: "Areas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    Shipping = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    Pay = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    Obj_ExteraDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Sku_SkuId",
                        column: x => x.SkuId,
                        principalTable: "Sku",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StatusHistory_SetterId",
                table: "StatusHistory",
                column: "SetterId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CreatedById",
                table: "Order",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_SkuId",
                table: "OrderItem",
                column: "SkuId");


            migrationBuilder.AddForeignKey(
                name: "FK_Areas_Country_CountryId",
                table: "Areas",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);


            migrationBuilder.AddForeignKey(
                name: "FK_WarehouseArea_Areas_WarehouseId",
                table: "WarehouseArea",
                column: "WarehouseId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Areas_ApplicationUser_CreatedById",
                table: "Areas");

            migrationBuilder.DropForeignKey(
                name: "FK_Areas_Country_CountryId",
                table: "Areas");

            migrationBuilder.DropForeignKey(
                name: "FK_Attribute_ApplicationUser_CreatedById",
                table: "Attribute");

            migrationBuilder.DropForeignKey(
                name: "FK_Badge_ApplicationUser_CreatedById",
                table: "Badge");

            migrationBuilder.DropForeignKey(
                name: "FK_Brand_ApplicationUser_CreatedById",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_ApplicationUser_CreatedById",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_ApplicationUser_CreatedById",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ApplicationUser_CreatedById",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_ApplicationUser_CreatedById",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusHistory_ApplicationUser_CreatedById",
                table: "StatusHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusHistory_AspNetUsers_SetterId",
                table: "StatusHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Store_ApplicationUser_CreatedById",
                table: "Store");

            migrationBuilder.DropForeignKey(
                name: "FK_Supplier_ApplicationUser_CreatedById",
                table: "Supplier");

            migrationBuilder.DropForeignKey(
                name: "FK_Tag_ApplicationUser_CreatedById",
                table: "Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_Variation_ApplicationUser_CreatedById",
                table: "Variation");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_ApplicationUser_CreatedById",
                table: "Warehouse");

            migrationBuilder.DropForeignKey(
                name: "FK_WarehouseArea_Areas_WarehouseId",
                table: "WarehouseArea");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropIndex(
                name: "IX_StatusHistory_SetterId",
                table: "StatusHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Areas",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PurchaseReceiveItem");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PurchaseItem");

            migrationBuilder.RenameTable(
                name: "Areas",
                newName: "Area");

            migrationBuilder.RenameIndex(
                name: "IX_Areas_CreatedById",
                table: "Area",
                newName: "IX_Area_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Areas_CountryId",
                table: "Area",
                newName: "IX_Area_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Area",
                table: "Area",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Area_AspNetUsers_CreatedById",
                table: "Area",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Area_Country_CountryId",
                table: "Area",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attribute_AspNetUsers_CreatedById",
                table: "Attribute",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Badge_AspNetUsers_CreatedById",
                table: "Badge",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_AspNetUsers_CreatedById",
                table: "Brand",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_AspNetUsers_CreatedById",
                table: "Category",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_AspNetUsers_CreatedById",
                table: "Country",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_CreatedById",
                table: "Product",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_AspNetUsers_CreatedById",
                table: "Purchase",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusHistory_AspNetUsers_CreatedById",
                table: "StatusHistory",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Store_AspNetUsers_CreatedById",
                table: "Store",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier_AspNetUsers_CreatedById",
                table: "Supplier",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_AspNetUsers_CreatedById",
                table: "Tag",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Variation_AspNetUsers_CreatedById",
                table: "Variation",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_AspNetUsers_CreatedById",
                table: "Warehouse",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WarehouseArea_Area_WarehouseId",
                table: "WarehouseArea",
                column: "WarehouseId",
                principalTable: "Area",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
