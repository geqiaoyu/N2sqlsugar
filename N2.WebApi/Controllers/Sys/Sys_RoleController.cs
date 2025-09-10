using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using N2.Core.Controllers.Basic;
using N2.Core.Enums;
using N2.Core.Filters;
using N2.Entity.AttributeManager;
using N2.Entity.DomainModels;
using N2.Sys.IServices;

namespace N2.Sys.Controllers
{
    [Route("api/Sys_Role")]
    [PermissionTable(Name = "Sys_Role")]
    public partial class Sys_RoleController : ApiBaseController<ISys_RoleService>
    {
        public Sys_RoleController(ISys_RoleService service)
        : base("System", "System", "Sys_Role", service)
        {

        }
    }
}


