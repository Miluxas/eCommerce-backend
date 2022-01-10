using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerce_backend.Base
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("[controller]")]
    [ApiController]
    public partial class BaseController<T> : ControllerBase where T : BaseModel
    {
        protected Guid? _userId;
        public BaseController(Guid? userId = null)
        {
            _userId = userId;
        }
        protected BaseService<T> service;

        [HttpPost]
        public async Task<IEnumerable<T>> Index(ListBody listBody)
        {
            return await service.List(listBody);
        }

        [HttpGet]
        [Route("Detail")]
        public async Task<T?> Detail(Guid? id)
        {
            if (id.HasValue)
                return await service.Detail(id.Value);
            else
                return null;

        }

        [HttpPost]
        [Route("Create")]
        virtual public async Task<T> Create(T detail)
        {
            if (!_userId.HasValue)
                _userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return await service.Create(detail, _userId.Value);
        }

        [HttpPost]
        [Route("Update")]
        public async Task<T> Update(T detail)
        {
            if (!_userId.HasValue)
                _userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return await service.Update(detail, _userId.Value);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<Boolean> Delete(Guid id)
        {
            return await service.Delete(id);
        }
    }
}
