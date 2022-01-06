using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace eCommerce_backend.Services
{
    public class PurchaseService : Base.BaseService<Purchase>
    {
        public PurchaseService(DbSet<Purchase> ts,ECommerceContext context):base(ts,context) {

        }
        public async Task<Purchase> RegisterNewPurchase(NewPurchase newPurchase, Guid userId)
        {
            Purchase purchase = new();
            purchase.SupplierId = newPurchase.SupplierId;
            purchase.Status=newPurchase.Status;
            purchase.Type=newPurchase.Type;
            foreach (var item in newPurchase.Items)
            {
                purchase.Items.Add(new PurchaseItem
                {
                    Qty = item.Qty,
                    SkuId = item.SkuId,
                    SellPrice = item.SellPrice,
                    BuyPrice = item.BuyPrice
                });
            }

            purchase.CreatedAt = DateTime.UtcNow;
            purchase.CreatedById = userId;
            await _ts.AddAsync(purchase);
            await _context.SaveChangesAsync();
            return await _ts.AsSingleQuery<Purchase>().FirstAsync<Purchase>(e => e.Id == purchase.Id);
        }

    }
}
