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

namespace eCommerce_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CountryController : Base.BaseController<Country>
    {
        public CountryController(ECommerceContext context,Guid? userID=null) : base(userID)
        {
            service = new Services.CountryService(context.Countries,context);
        }
    }
}
