using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommercebackend.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attribute",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attribute", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Badge",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badge", x => x.Id);
                });

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
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mm_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Category_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Md_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Md_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Variation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttributeItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttributeItem_Attribute_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attribute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    HasWrapping = table.Column<bool>(type: "bit", nullable: false),
                    HasGiftCard = table.Column<bool>(type: "bit", nullable: false),
                    HasCustomText = table.Column<bool>(type: "bit", nullable: false),
                    Ml_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Taxable = table.Column<bool>(type: "bit", nullable: false),
                    SizeGuildId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsStandardProduct = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Area_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VariationItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VariationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariationItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VariationItem_Variation_VariationId",
                        column: x => x.VariationId,
                        principalTable: "Variation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApprovedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Purchase_AspNetUsers_ApprovedById",
                        column: x => x.ApprovedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchase_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchase_Warehouse_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributeItem",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttributeItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeItem", x => new { x.ProductId, x.AttributeItemId });
                    table.ForeignKey(
                        name: "FK_ProductAttributeItem_AttributeItem_ProductId",
                        column: x => x.ProductId,
                        principalTable: "AttributeItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAttributeItem_Product_AttributeItemId",
                        column: x => x.AttributeItemId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductBadge",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BadgeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBadge", x => new { x.ProductId, x.BadgeId });
                    table.ForeignKey(
                        name: "FK_ProductBadge_Badge_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Badge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductBadge_Product_BadgeId",
                        column: x => x.BadgeId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategory_Category_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategory_Product_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCountry",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCountry", x => new { x.ProductId, x.CountryId });
                    table.ForeignKey(
                        name: "FK_ProductCountry_Country_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCountry_Product_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductStore",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStore", x => new { x.ProductId, x.CountryId, x.StoreId });
                    table.ForeignKey(
                        name: "FK_ProductStore_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductStore_Product_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductStore_Store_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSupplier",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSupplier", x => new { x.ProductId, x.CountryId, x.SupplierId });
                    table.ForeignKey(
                        name: "FK_ProductSupplier_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSupplier_Product_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSupplier_Supplier_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTag",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTag", x => new { x.ProductId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ProductTag_Product_TagId",
                        column: x => x.TagId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTag_Tag_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sku",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ml_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Md_Images = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sku", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sku_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseArea",
                columns: table => new
                {
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DeliveryMaxDay = table.Column<int>(type: "int", nullable: false),
                    DeliveryCost = table.Column<decimal>(type: "decimal(18,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseArea", x => new { x.WarehouseId, x.AreaId });
                    table.ForeignKey(
                        name: "FK_WarehouseArea_Area_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WarehouseArea_Warehouse_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseReceive",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReciveById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiveById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReceiveAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseReceive", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseReceive_AspNetUsers_ReceiveById",
                        column: x => x.ReceiveById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseReceive_Purchase_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseItem",
                columns: table => new
                {
                    PurchaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseItem", x => new { x.SkuId, x.PurchaseId });
                    table.ForeignKey(
                        name: "FK_PurchaseItem_Purchase_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseItem_Sku_SkuId",
                        column: x => x.SkuId,
                        principalTable: "Sku",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkuVariationItem",
                columns: table => new
                {
                    SkuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VariationItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkuVariationItem", x => new { x.SkuId, x.VariationItemId });
                    table.ForeignKey(
                        name: "FK_SkuVariationItem_Sku_VariationItemId",
                        column: x => x.VariationItemId,
                        principalTable: "Sku",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkuVariationItem_VariationItem_SkuId",
                        column: x => x.SkuId,
                        principalTable: "VariationItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseReceiveItem",
                columns: table => new
                {
                    PurchaseReceiveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseReceiveItem", x => new { x.SkuId, x.PurchaseReceiveId });
                    table.ForeignKey(
                        name: "FK_PurchaseReceiveItem_PurchaseReceive_PurchaseReceiveId",
                        column: x => x.PurchaseReceiveId,
                        principalTable: "PurchaseReceive",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseReceiveItem_Sku_SkuId",
                        column: x => x.SkuId,
                        principalTable: "Sku",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Area_CountryId",
                table: "Area",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeItem_AttributeId",
                table: "AttributeItem",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentId",
                table: "Category",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandId",
                table: "Product",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeItem_AttributeItemId",
                table: "ProductAttributeItem",
                column: "AttributeItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBadge_BadgeId",
                table: "ProductBadge",
                column: "BadgeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_CategoryId",
                table: "ProductCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCountry_CountryId",
                table: "ProductCountry",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStore_CountryId",
                table: "ProductStore",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStore_StoreId",
                table: "ProductStore",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSupplier_CountryId",
                table: "ProductSupplier",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSupplier_SupplierId",
                table: "ProductSupplier",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTag_TagId",
                table: "ProductTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_ApprovedById",
                table: "Purchase",
                column: "ApprovedById");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_SupplierId",
                table: "Purchase",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_WarehouseId",
                table: "Purchase",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItem_PurchaseId",
                table: "PurchaseItem",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReceive_PurchaseId",
                table: "PurchaseReceive",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReceive_ReceiveById",
                table: "PurchaseReceive",
                column: "ReceiveById");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReceiveItem_PurchaseReceiveId",
                table: "PurchaseReceiveItem",
                column: "PurchaseReceiveId");

            migrationBuilder.CreateIndex(
                name: "IX_Sku_ProductId",
                table: "Sku",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SkuVariationItem_VariationItemId",
                table: "SkuVariationItem",
                column: "VariationItemId");

            migrationBuilder.CreateIndex(
                name: "IX_VariationItem_VariationId",
                table: "VariationItem",
                column: "VariationId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseArea_AreaId",
                table: "WarehouseArea",
                column: "AreaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAttributeItem");

            migrationBuilder.DropTable(
                name: "ProductBadge");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "ProductCountry");

            migrationBuilder.DropTable(
                name: "ProductStore");

            migrationBuilder.DropTable(
                name: "ProductSupplier");

            migrationBuilder.DropTable(
                name: "ProductTag");

            migrationBuilder.DropTable(
                name: "PurchaseItem");

            migrationBuilder.DropTable(
                name: "PurchaseReceiveItem");

            migrationBuilder.DropTable(
                name: "SkuVariationItem");

            migrationBuilder.DropTable(
                name: "StatusHistory");

            migrationBuilder.DropTable(
                name: "WarehouseArea");

            migrationBuilder.DropTable(
                name: "AttributeItem");

            migrationBuilder.DropTable(
                name: "Badge");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "PurchaseReceive");

            migrationBuilder.DropTable(
                name: "Sku");

            migrationBuilder.DropTable(
                name: "VariationItem");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Attribute");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Variation");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "Brand");
        }
    }
}
