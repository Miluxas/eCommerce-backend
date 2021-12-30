using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommercebackend.Migrations.ECommerce
{
    public partial class initialmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Md_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brand_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

 
            migrationBuilder.CreateIndex(
                name: "IX_Brand_CreatedById",
                table: "Brand",
                column: "CreatedById");

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brand");
        }
    }
}
