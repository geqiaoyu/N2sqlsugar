/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹MES_ProductionPlanDetailController编写
 */
using Microsoft.AspNetCore.Mvc;
using N2.Core.Controllers.Basic;
using N2.Entity.AttributeManager;
using N2.MES.IServices;
namespace N2.MES.Controllers
{
    [Route("api/MES_ProductionPlanDetail")]
    [PermissionTable(Name = "MES_ProductionPlanDetail")]
    public partial class MES_ProductionPlanDetailController : ApiBaseController<IMES_ProductionPlanDetailService>
    {
        public MES_ProductionPlanDetailController(IMES_ProductionPlanDetailService service)
        : base(service)
        {
        }
    }
}

