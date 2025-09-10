/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹FormDesignOptionsController编写
 */
using Microsoft.AspNetCore.Mvc;
using N2.Core.Controllers.Basic;
using N2.Entity.AttributeManager;
using N2.Sys.IServices;
namespace N2.Sys.Controllers
{
    [Route("api/FormDesignOptions")]
    [PermissionTable(Name = "FormDesignOptions")]
    public partial class FormDesignOptionsController : ApiBaseController<IFormDesignOptionsService>
    {
        public FormDesignOptionsController(IFormDesignOptionsService service)
        : base(service)
        {
        }
    }
}

