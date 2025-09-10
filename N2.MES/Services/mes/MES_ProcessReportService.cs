/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下MES_ProcessReportService与IMES_ProcessReportService中编写
 */
using N2.MES.IRepositories;
using N2.MES.IServices;
using N2.Core.BaseProvider;
using N2.Core.Extensions.AutofacManager;
using N2.Entity.DomainModels;

namespace N2.MES.Services
{
    public partial class MES_ProcessReportService : ServiceBase<MES_ProcessReport, IMES_ProcessReportRepository>
    , IMES_ProcessReportService, IDependency
    {
    public static IMES_ProcessReportService Instance
    {
      get { return AutofacContainerModule.GetService<IMES_ProcessReportService>(); } }
    }
 }
