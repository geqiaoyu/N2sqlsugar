/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("Sys_Dicts",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using N2.Entity.DomainModels;
using N2.Sys.IServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace N2.Sys.Controllers
{
    public partial class Sys_DictsController
    {
        private readonly ISys_DictsService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public Sys_DictsController(
            ISys_DictsService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("GetSysDics"), AllowAnonymous]
        public async Task<IActionResult> GetSysDics()
        {
            return Json(await Service.GetSysDics());
        }
    }
}
