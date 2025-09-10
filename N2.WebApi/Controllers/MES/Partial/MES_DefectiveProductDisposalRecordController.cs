/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("MES_DefectiveProductDisposalRecord",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using N2.Entity.DomainModels;
using N2.MES.IServices;

namespace N2.MES.Controllers
{
    public partial class MES_DefectiveProductDisposalRecordController
    {
        private readonly IMES_DefectiveProductDisposalRecordService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public MES_DefectiveProductDisposalRecordController(
            IMES_DefectiveProductDisposalRecordService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
