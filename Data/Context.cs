using eCommerce_backend.Base;
using eCommerce_backend.Data.Models;
using eCommerce_backend.IdentityAuth;
using Microsoft.EntityFrameworkCore;

namespace eCommerce_backend.Data
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        { }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Models.Attribute> Attributes { get; set; }
        public DbSet<AttributeItem> AttributeItems { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Variation> Variations { get; set; }
        public DbSet<VariationItem> VariationItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttributeItem> ProductAttributeItems { get; set; }
        public DbSet<ProductBadge> ProductBadges { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<ProductCountry> ProductCountries { get; set; }
        public DbSet<ProductStore> ProductStores { get; set; }
        public DbSet<ProductSupplier> ProductSuppliers { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Sku> Skus { get; set; }
        public DbSet<SkuVariationItem> SkuVariationItems { get; set; }
        public DbSet<StatusHistory> StatusHistories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<PurchaseReceive> PurchaseReceives { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Badge>().ToTable("Badge");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<Models.Attribute>().ToTable("Attribute");
            modelBuilder.Entity<AttributeItem>().ToTable("AttributeItem");
            modelBuilder.Entity<Variation>().ToTable("Variation");
            modelBuilder.Entity<VariationItem>().ToTable("VariationItem");
            modelBuilder.Entity<Store>().ToTable("Store");
            modelBuilder.Entity<Supplier>().ToTable("Supplier");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<ProductAttributeItem>().ToTable("ProductAttributeItem");
            modelBuilder.Entity<ProductBadge>().ToTable("ProductBadge");
            modelBuilder.Entity<ProductCategory>().ToTable("ProductCategory");
            modelBuilder.Entity<ProductCountry>().ToTable("ProductCountry");
            modelBuilder.Entity<ProductStore>().ToTable("ProductStore");
            modelBuilder.Entity<ProductSupplier>().ToTable("ProductSupplier");
            modelBuilder.Entity<ProductTag>().ToTable("ProductTag");
            modelBuilder.Entity<Sku>().ToTable("Sku");
            modelBuilder.Entity<SkuVariationItem>().ToTable("SkuVariationItem");
            modelBuilder.Entity<StatusHistory>().ToTable("StatusHistory");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Purchase>().ToTable("Purchase");
            modelBuilder.Entity<PurchaseItem>().ToTable("PurchaseItem");
            modelBuilder.Entity<PurchaseReceive>().ToTable("PurchaseReceive");
            modelBuilder.Entity<Inventory>().ToTable("Inventory");
            modelBuilder.Entity<Warehouse>().ToTable("Warehouse");
            modelBuilder.Ignore<Media>();
            modelBuilder.Ignore<ExtraDetail>();
            modelBuilder.Ignore<User>();

            modelBuilder.Entity<ProductAttributeItem>().HasKey(pAi => new { pAi.ProductId, pAi.AttributeItemId });
            modelBuilder.Entity<ProductAttributeItem>()
                .HasOne(pAi => pAi.Product)
                .WithMany(p => p.ProductAttributeItems)
                .HasForeignKey(pAi => pAi.AttributeItemId);
            modelBuilder.Entity<ProductAttributeItem>()
                .HasOne(pAi => pAi.AttributeItem)
                .WithMany(p => p.ProductAttributeItems)
                .HasForeignKey(pAi => pAi.ProductId);

            modelBuilder.Entity<ProductBadge>().HasKey(pB => new { pB.ProductId, pB.BadgeId });
            modelBuilder.Entity<ProductBadge>()
                .HasOne(pB => pB.Product)
                .WithMany(p => p.ProductBadges)
                .HasForeignKey(pB => pB.BadgeId);
            modelBuilder.Entity<ProductBadge>()
                .HasOne(pB => pB.Badge)
                .WithMany(p => p.ProductBadges)
                .HasForeignKey(pB => pB.ProductId);

            modelBuilder.Entity<ProductCategory>().HasKey(pB => new { pB.ProductId, pB.CategoryId });
            modelBuilder.Entity<ProductCategory>()
                .HasOne(pB => pB.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pB => pB.CategoryId);
            modelBuilder.Entity<ProductCategory>()
                .HasOne(pB => pB.Category)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pB => pB.ProductId);

            modelBuilder.Entity<ProductCountry>().HasKey(pB => new { pB.ProductId, pB.CountryId });
            modelBuilder.Entity<ProductCountry>()
                .HasOne(pB => pB.Product)
                .WithMany(p => p.ProductCountries)
                .HasForeignKey(pB => pB.CountryId);
            modelBuilder.Entity<ProductCountry>()
                .HasOne(pB => pB.Country)
                .WithMany(p => p.ProductCountries)
                .HasForeignKey(pB => pB.ProductId);


            modelBuilder.Entity<ProductStore>().HasKey(pB => new { pB.ProductId, pB.CountryId, pB.StoreId });
            modelBuilder.Entity<ProductStore>()
                .HasOne(pB => pB.Product)
                .WithMany(p => p.ProductStores)
                .HasForeignKey(pB => pB.StoreId);
            modelBuilder.Entity<ProductStore>()
                .HasOne(pB => pB.Store)
                .WithMany(p => p.ProductStores)
                .HasForeignKey(pB => pB.ProductId);


            modelBuilder.Entity<ProductSupplier>().HasKey(pB => new { pB.ProductId, pB.CountryId, pB.SupplierId });
            modelBuilder.Entity<ProductSupplier>()
                .HasOne(pB => pB.Product)
                .WithMany(p => p.ProductSuppliers)
                .HasForeignKey(pB => pB.SupplierId);
            modelBuilder.Entity<ProductSupplier>()
                .HasOne(pB => pB.Supplier)
                .WithMany(p => p.ProductSuppliers)
                .HasForeignKey(pB => pB.ProductId);

            modelBuilder.Entity<ProductTag>().HasKey(pB => new { pB.ProductId, pB.TagId });
            modelBuilder.Entity<ProductTag>()
                .HasOne(pB => pB.Product)
                .WithMany(p => p.ProductTags)
                .HasForeignKey(pB => pB.TagId);
            modelBuilder.Entity<ProductTag>()
                .HasOne(pB => pB.Tag)
                .WithMany(p => p.ProductTags)
                .HasForeignKey(pB => pB.ProductId);

            modelBuilder.Entity<SkuVariationItem>().HasKey(pB => new { pB.SkuId, pB.VariationItemId });
            modelBuilder.Entity<SkuVariationItem>()
                .HasOne(pB => pB.Sku)
                .WithMany(p => p.SkuVariationItems)
                .HasForeignKey(pB => pB.VariationItemId);
            modelBuilder.Entity<SkuVariationItem>()
                .HasOne(pB => pB.VariationItem)
                .WithMany(p => p.SkuVariationItems)
                .HasForeignKey(pB => pB.SkuId);

            modelBuilder.Entity<Area>()
           .HasOne(a => a.Country)
           .WithMany(c => c.Areas)
           .HasForeignKey(a => a.CountryId);

            modelBuilder.Entity<PurchaseItem>().HasKey(pB => new { pB.SkuId, pB.PurchaseId });
            modelBuilder.Entity<PurchaseReceiveItem>().HasKey(pB => new { pB.SkuId, pB.PurchaseReceiveId });

            modelBuilder.Entity<WarehouseArea>().HasKey(pB => new { pB.WarehouseId, pB.AreaId });
            modelBuilder.Entity<WarehouseArea>()
                .HasOne(pB => pB.Warehouse)
                .WithMany(p => p.WarehouseAreas)
                .HasForeignKey(pB => pB.AreaId);
            modelBuilder.Entity<WarehouseArea>()
                .HasOne(pB => pB.Area)
                .WithMany(p => p.WarehouseAreas)
                .HasForeignKey(pB => pB.WarehouseId);
        }
    }
}
