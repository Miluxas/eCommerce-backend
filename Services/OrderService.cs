using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Services
{
    public class OrderService : Base.BaseService<Order>
    {
        public OrderService(DbSet<Order> ts,ECommerceContext context):base(ts,context) {

        }

    }
}
