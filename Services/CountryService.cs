﻿using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Services
{
    public class CountryService : Base.BaseService<Country>
    {
        public CountryService(DbSet<Country> ts,ECommerceContext context):base(ts,context) {

        }

    }
}