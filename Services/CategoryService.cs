using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Services
{
    public class CategoryService : Base.BaseService<Category>
    {
        public CategoryService(DbSet<Category> ts,ECommerceContext context):base(ts,context) {

        }

    }
}
