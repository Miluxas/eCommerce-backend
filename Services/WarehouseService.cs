﻿using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Services
{
    public class WarehouseService:Base.BaseService<Warehouse>
    {
        public WarehouseService(DbSet<Warehouse> ts,ECommerceContext context):base(ts,context) {

        }

    }
}