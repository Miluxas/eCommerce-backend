using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Services
{
    public class SupplierService:Base.BaseService<Supplier>
    {
        public SupplierService(DbSet<Supplier> ts,ECommerceContext context):base(ts,context) {

        }

    }
}
