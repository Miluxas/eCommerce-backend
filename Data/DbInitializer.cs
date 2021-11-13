using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_backend.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ECommerceContext context)
        {
            context.Database.EnsureCreated();

            try
            {
                context.Brands.Count<Models.Brand>();

            }
            catch (Exception)
            {

            }
        }
    }
}
