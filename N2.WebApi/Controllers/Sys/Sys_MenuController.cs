using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using N2.Core.Controllers.Basic;
using N2.Core.Enums;
using N2.Core.Filters;
using N2.Entity.DomainModels;
using N2.Sys.IServices;

namespace N2.Sys.Controllers
{
    [Route("api/menu")]
    [ApiController, JWTAuthorize()]
    public partial class Sys_MenuController : ApiBaseController<ISys_MenuService>
    {
        private ISys_MenuService _service { get; set; }
        public Sys_MenuController(ISys_MenuService service) :
            base("System", "System", "Sys_Menu", service)
        {
            _service = service;
        } 
    }
}
