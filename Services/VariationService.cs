using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_backend.Services
{
    public class VariationService : Base.BaseService<Variation>
    {
        public VariationService(DbSet<Variation> ts, ECommerceContext context) : base(ts, context)
        {
            _predicate = (query, filter) =>
            {
                var arr = filter.Properties();
                foreach (var prop in arr)
                {
                    if (prop.Name == "Id")
                        query = query.Where(e => e.Id == System.Guid.Parse(prop.Value.ToString()));
                    else if (prop.Name == "Name")
                        query = query.Where(e => e.Ml_Name.Contains(prop.Value.ToString()));
                }
                return query;
            };
        }

        override public async Task<Variation> Detail(Guid id)
        {
            var query = _context.Variations.Join(
                    _context.VariationItems,
                    variation => variation.Id,
                    item => item.VariationId,
                    (Variation, item) => item
                ).ToList();
            var attri = await base.Detail(id);
            attri.Items = query;
            return attri;
        }
    }
}
