using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Services
{
    public class PurchaseService : Base.BaseService<Purchase>
    {
        public PurchaseService(DbSet<Purchase> ts,ECommerceContext context):base(ts,context) {

        }

    }
}
