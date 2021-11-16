using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Services
{
    public class StoreService:Base.BaseService<Store>
    {
        public StoreService(DbSet<Store> ts,ECommerceContext context):base(ts,context) {

        }

    }
}
