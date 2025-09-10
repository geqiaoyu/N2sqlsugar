/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹MES_ProductionReportingDetailRepository编写代码
 */
using N2.MES.IRepositories;
using N2.Core.BaseProvider;
using N2.Core.DbContext;
using N2.Core.Extensions.AutofacManager;
using N2.Entity.DomainModels;

namespace N2.MES.Repositories
{
    public partial class MES_ProductionReportingDetailRepository : RepositoryBase<MES_ProductionReportingDetail> , IMES_ProductionReportingDetailRepository
    {
    public MES_ProductionReportingDetailRepository(N2Context dbContext)
    : base(dbContext)
    {

    }
    public static IMES_ProductionReportingDetailRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IMES_ProductionReportingDetailRepository>(); } }
    }
}
