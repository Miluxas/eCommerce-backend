﻿using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace eCommerce_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AreaController : Base.BaseController<Area>
    {
        public AreaController(ECommerceContext context,Guid? userID=null) : base(userID)
        {
            service = new Services.AreaService(context.Areas, context);
        }

    }
}