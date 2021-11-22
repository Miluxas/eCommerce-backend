using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommercebackend.Migrations.ECommerce
{
    public partial class initialmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCountry_Warehouse_WarehouseID",
                table: "ProductCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStore_Warehouse_WarehouseID",
                table: "ProductStore");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSupplier_Warehouse_WarehouseID",
                table: "ProductSupplier");

            migrationBuilder.DropIndex(
                name: "IX_ProductSupplier_WarehouseID",
                table: "ProductSupplier");

            migrationBuilder.DropIndex(
                name: "IX_ProductStore_WarehouseID",
                table: "ProductStore");

            migrationBuilder.DropIndex(
                name: "IX_ProductCountry_WarehouseID",
                table: "ProductCountry");

            migrationBuilder.DropColumn(
                name: "WarehouseID",
                table: "ProductSupplier");

            migrationBuilder.DropColumn(
                name: "WarehouseID",
                table: "ProductStore");

            migrationBuilder.DropColumn(
                name: "WarehouseID",
                table: "ProductCountry");

            migrationBuilder.CreateTable(
                name: "WarehouseArea",
                columns: table => new
                {
                    WarehouseID = table.Column<long>(type: "bigint", nullable: false),
                    AreaID = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DeliveryMaxDay = table.Column<int>(type: "int", nullable: false),
                    DeliveryCost = table.Column<decimal>(type: "decimal(18,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseArea", x => new { x.WarehouseID, x.AreaID });
                    table.ForeignKey(
                        name: "FK_WarehouseArea_Area_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Area",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WarehouseArea_Warehouse_AreaID",
                        column: x => x.AreaID,
                        principalTable: "Warehouse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseArea_AreaID",
                table: "WarehouseArea",
                column: "AreaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WarehouseArea");

            migrationBuilder.AddColumn<long>(
                name: "WarehouseID",
                table: "ProductSupplier",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "WarehouseID",
                table: "ProductStore",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "WarehouseID",
                table: "ProductCountry",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductSupplier_WarehouseID",
                table: "ProductSupplier",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStore_WarehouseID",
                table: "ProductStore",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCountry_WarehouseID",
                table: "ProductCountry",
                column: "WarehouseID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCountry_Warehouse_WarehouseID",
                table: "ProductCountry",
                column: "WarehouseID",
                principalTable: "Warehouse",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStore_Warehouse_WarehouseID",
                table: "ProductStore",
                column: "WarehouseID",
                principalTable: "Warehouse",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSupplier_Warehouse_WarehouseID",
                table: "ProductSupplier",
                column: "WarehouseID",
                principalTable: "Warehouse",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
