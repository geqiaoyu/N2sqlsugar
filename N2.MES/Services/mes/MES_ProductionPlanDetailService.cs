/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下MES_ProductionPlanDetailService与IMES_ProductionPlanDetailService中编写
 */
using N2.MES.IRepositories;
using N2.MES.IServices;
using N2.Core.BaseProvider;
using N2.Core.Extensions.AutofacManager;
using N2.Entity.DomainModels;

namespace N2.MES.Services
{
    public partial class MES_ProductionPlanDetailService : ServiceBase<MES_ProductionPlanDetail, IMES_ProductionPlanDetailRepository>
    , IMES_ProductionPlanDetailService, IDependency
    {
    public static IMES_ProductionPlanDetailService Instance
    {
      get { return AutofacContainerModule.GetService<IMES_ProductionPlanDetailService>(); } }
    }
 }
