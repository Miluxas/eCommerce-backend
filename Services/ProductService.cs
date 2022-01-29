using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace eCommerce_backend.Services
{
    public class ProductService : Base.BaseService<Product>
    {
        public ProductService(DbSet<Product> ts, ECommerceContext context,IContentRoleAccess<Product> contentRoleAccess) : base(ts, context,contentRoleAccess)
        {
            _predicate = (query,filter) =>
            {
                var arr = filter.Properties();
                foreach (var prop in arr)
                {
                    if(prop.Name =="Id")
                        query=query.Where(e=>e.Id==System.Guid.Parse( prop.Value.ToString()));
                    else if (prop.Name == "Name")
                        query = query.Where(e => e.Ml_Name.Contains( prop.Value.ToString()));
                    else if (prop.Name == "Description")
                        query = query.Where(e => e.Ml_Description.Contains(prop.Value.ToString()));
                    else if (prop.Name == "Code")
                        query = query.Where(e => e.Code.Contains(prop.Value.ToString()));
                    else if (prop.Name == "Brand.Name")
                        query = query.Where(e => e.Brand!=null && e.Brand.Ml_Name.Contains(prop.Value.ToString()));
                }
                return query;
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
