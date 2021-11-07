using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Services
{
    public class BrandService:Base.BaseService<Brand>
    {
        public BrandService(DbSet<Brand> ts):base(ts) {
            _ts = ts;
        }

    }
}
