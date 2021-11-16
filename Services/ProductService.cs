using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_backend.Services
{
    public class ProductService : Base.BaseService<Product>
    {
        public ProductService(DbSet<Product> ts, ECommerceContext context) : base(ts, context)
        {
        }

        override public async Task<Product> Detail(Int64 id)
        {
            var query = _context.Products
               // .Join(
               // _context)
                .Join(
                    _context.Skus,
                    Product => Product.ID,
                    sku => sku.ProductID,
                    (Product, sku) => sku
                ).ToList();
            var product = await base.Detail(id);
            product.Skus = query;
            return product;
        }
    }
}
