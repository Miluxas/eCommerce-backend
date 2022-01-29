using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace eCommerce_backend.Services
{
    public class OrderService : Base.BaseService<Order>
    {
        public OrderService(DbSet<Order> ts,ECommerceContext context,IContentRoleAccess<Order> contentRoleAccess):base(ts,context,contentRoleAccess) {
            _predicate = (query, filter) =>
            {
                var arr = filter.Properties();
                foreach (var prop in arr)
                {
                    if (prop.Name == "Id")
                        query = query.Where(e => e.Id == System.Guid.Parse(prop.Value.ToString()));
                }
                return query;
            };
        }

    }
}
