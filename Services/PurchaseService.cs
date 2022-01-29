using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_backend.Services
{
    public class PurchaseService : Base.BaseService<Purchase>
    {
        public PurchaseService(DbSet<Purchase> ts,ECommerceContext context,IContentRoleAccess<Purchase> contentRoleAccess):base(ts,context,contentRoleAccess) {
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
        public async Task<Purchase> RegisterNewPurchase(NewPurchaseModel newPurchase, Guid userId)
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
        public async Task<PurchaseReceive> RegisterNewPurchaseReceive(PurchaseReceiveModel receiveModel, Guid userId)
        {
            PurchaseReceive purchaseReceive = new();
            purchaseReceive.WarehouseId = receiveModel.WarehouseId;
            purchaseReceive.PurchaseId = receiveModel.PurchaseId;
            foreach (var item in receiveModel.Items)
            {
                var purch= await _ts.AsSingleQuery<Purchase>().FirstAsync<Purchase>(e => e.Id == receiveModel.PurchaseId);
                var totalReceivedCount= purch.PurchaseReceives.Sum(Pr =>
                {
                    var fi = Pr.Items.FirstOrDefault(i => i.SkuId == item.SkuId);
                    if (fi!=null)
                        return fi.Qty;
                    return 0;
                });
                purchaseReceive.Items.Add(new PurchaseReceiveItem
                {
                    Qty = item.Qty,
                    SkuId = item.SkuId
                });

                var purchItem = purch.Items.First(e => e.SkuId == item.SkuId);
                if (totalReceivedCount + item.Qty > purchItem.Qty)
                {
                    throw new Exception("Received Quantity is higher than purchase count");
                }
                if(purchItem!=null)
                for (int i = 0; i < item.Qty; i++)
                {
                        var inventory = new Inventory
                        {
                            SkuId = item.SkuId,
                            BuyPrice = purchItem.BuyPrice,
                            SellPrice = purchItem.SellPrice,
                            WarehouseId = receiveModel.WarehouseId,
                            PurchaseId=receiveModel.PurchaseId,
                        };
                       _context.Inventories.Add(inventory);
                }
            }

            purchaseReceive.ReceiveAt = DateTime.UtcNow;
            purchaseReceive.ReciveById = userId;
            await _context.PurchaseReceives.AddAsync(purchaseReceive);

            await _context.SaveChangesAsync();
            return await _context.PurchaseReceives.AsSingleQuery<PurchaseReceive>().FirstAsync<PurchaseReceive>(e => e.Id == purchaseReceive.Id);
        }

    }
}
