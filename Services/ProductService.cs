using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_backend.Services
{
    public class ProductService : Base.BaseService<Product>
    {
        
        public ProductService(DbSet<Product> ts, ECommerceContext context) : base(ts, context)
        {
        }
        //override public async Task<Product> Create(Product entity, Guid userID)
        //{
        //    entity.CreatedAt = DateTime.UtcNow;
        //    entity.CreatedByID = userID;

        //    var list = new List<ValueTask<EntityEntry<Product>>>();
        //    for (int i = 0; i < 5000; i++)
        //    {
               
        //        var nEn = new Product()  entity ;
        //        entity.Name["en"] = entity.Name["en"]+ "    " + i.ToString();
        //        _ts.Add(entity);
        //        entity.ID = Guid.NewGuid();
        //    }
        //    await _context.SaveChangesAsync();
        //    return await _ts.AsSingleQuery<Product>().FirstAsync<Product>(e => e.ID == entity.ID);
        //}
    }
}
