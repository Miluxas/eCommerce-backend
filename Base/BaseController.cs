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
        Guid? _userID;
        public BaseController(Guid? userID = null)
        {
            _userID = userID;
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
            if (!_userID.HasValue)
                _userID = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return await service.Create(detail, _userID.Value);
        }

        [HttpPost]
        [Route("Update")]
        public async Task<T> Update(T detail)
        {
            if (!_userID.HasValue)
                _userID = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return await service.Update(detail, _userID.Value);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<Boolean> Delete(Guid id)
        {
            return await service.Delete(id);
        }
    }
}
