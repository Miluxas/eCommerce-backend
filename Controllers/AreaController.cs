using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace eCommerce_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AreaController : Base.BaseController<Area>
    {
        public AreaController(ECommerceContext context,Guid? userId=null) : base(userId)
        {
            service = new Services.AreaService(context.Areas, context);
        }

    }
}
