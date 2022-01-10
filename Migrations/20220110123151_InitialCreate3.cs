using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommercebackend.Migrations.ECommerce
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Order_OrderId",
                table: "Inventory");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "Inventory",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Order_OrderId",
                table: "Inventory",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Order_OrderId",
                table: "Inventory");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "Inventory",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Order_OrderId",
                table: "Inventory",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
