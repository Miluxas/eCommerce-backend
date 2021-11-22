using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.AspNetCore.Authorization;

namespace eCommerce_backend.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class BrandController : Base.BaseController<Brand>
    {
        public BrandController(ECommerceContext context)
        {
            service = new Services.BrandService(context.Brands,context);
        }
    }
}
