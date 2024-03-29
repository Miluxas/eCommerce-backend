﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.AspNetCore.Identity;
using eCommerce_backend.IdentityAuth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace eCommerce_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AttributeController : Base.BaseController<Data.Models.Attribute>
    {
        public AttributeController(ECommerceContext context, IContentRoleAccess<Data.Models.Attribute> contentRoleAccess, Guid? userId=null) : base(userId)
        {
            service = new Services.AttributeService(context.Attributes,context,contentRoleAccess);
        }

    }
}
