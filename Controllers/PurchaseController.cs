﻿using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerce_backend.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class PurchaseController : Base.BaseController<Purchase>
    {
        readonly Services.PurchaseService _service;
        public PurchaseController(ECommerceContext context, Guid? userId = null) : base(userId)
        {
            service=_service = new Services.PurchaseService(context.Purchases, context);
        }

        [HttpPost]
        [Route("RegisterNewPurchase")]
        virtual public async Task<Purchase> RegisterNewPurchase(Purchase detail)
        {
            if (!base._userId.HasValue)
                _userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            return await _service.RegisterNewPurchase(detail, _userId.Value);
        }
    }
}
