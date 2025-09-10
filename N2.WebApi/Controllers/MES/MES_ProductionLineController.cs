/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹MES_ProductionLineController编写
 */
using Microsoft.AspNetCore.Mvc;
using N2.Core.Controllers.Basic;
using N2.Entity.AttributeManager;
using N2.MES.IServices;
namespace N2.MES.Controllers
{
    [Route("api/MES_ProductionLine")]
    [PermissionTable(Name = "MES_ProductionLine")]
    public partial class MES_ProductionLineController : ApiBaseController<IMES_ProductionLineService>
    {
        public MES_ProductionLineController(IMES_ProductionLineService service)
        : base(service)
        {
        }
    }
}

