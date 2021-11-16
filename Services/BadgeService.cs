﻿using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Services
{
    public class BadgeService:Base.BaseService<Badge>
    {
        public BadgeService(DbSet<Badge> ts,ECommerceContext context):base(ts,context) {

        }

    }
}
