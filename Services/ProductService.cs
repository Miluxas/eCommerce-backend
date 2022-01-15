using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace eCommerce_backend.Services
{
    public class ProductService : Base.BaseService<Product>
    {
        public ProductService(DbSet<Product> ts, ECommerceContext context) : base(ts, context)
        {
            _predicate = (filter) =>
            {
                IQueryable<Product> tmpQuery = ts;
                var arr = filter.Properties();
                foreach (var prop in arr)
                {
                    if(prop.Name =="Id")
                        tmpQuery=tmpQuery.Where(e=>e.Id==System.Guid.Parse( prop.Value.ToString()));
                    else if (prop.Name == "Name")
                        tmpQuery = tmpQuery.Where(e => e.Ml_Name.Contains( prop.Value.ToString()));
                    else if (prop.Name == "Description")
                        tmpQuery = tmpQuery.Where(e => e.Ml_Description.Contains(prop.Value.ToString()));
                    else if (prop.Name == "Code")
                        tmpQuery = tmpQuery.Where(e => e.Code.Contains(prop.Value.ToString()));
                    else if (prop.Name == "Brand.Name")
                        tmpQuery = tmpQuery.Where(e => e.Brand!=null && e.Brand.Ml_Name.Contains(prop.Value.ToString()));
                }
                return tmpQuery;
            };
        }
        //override public async Task<Product> Create(Product entity, Guid userId)
        //{
        //    entity.CreatedAt = DateTime.UtcNow;
        //    entity.CreatedById = userId;

        //    var list = new List<ValueTask<EntityEntry<Product>>>();
        //    for (int i = 0; i < 5000; i++)
        //    {

        //        var nEn = new Product()  entity ;
        //        entity.Name["en"] = entity.Name["en"]+ "    " + i.ToString();
        //        _ts.Add(entity);
        //        entity.Id = Guid.NewGuid();
        //    }
        //    await _context.SaveChangesAsync();
        //    return await _ts.AsSingleQuery<Product>().FirstAsync<Product>(e => e.Id == entity.Id);
        //}
    }
}
