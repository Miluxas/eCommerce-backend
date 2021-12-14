using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.AspNetCore.Identity;
using eCommerce_backend.IdentityAuth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace eCommerce_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AttributeController : Base.BaseController<Models.Attribute>
    {
        public AttributeController(Guid userID, ECommerceContext context) : base(userID)
        {
            service = new Services.AttributeService(context.Attributes,context);
        }

    }
}
