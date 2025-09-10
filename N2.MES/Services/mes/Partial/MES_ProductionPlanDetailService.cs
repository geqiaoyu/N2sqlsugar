/*
 *所有关于MES_ProductionPlanDetail类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*MES_ProductionPlanDetailService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
*/
using N2.Core.BaseProvider;
using N2.Core.Extensions.AutofacManager;
using N2.Entity.DomainModels;
using System.Linq;
using N2.Core.Utilities;
using System.Linq.Expressions;
using N2.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using N2.MES.IRepositories;
using SqlSugar;
using N2.Core.DbSqlSugar;
using N2.Core.DBManager;

namespace N2.MES.Services
{
    public partial class MES_ProductionPlanDetailService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMES_ProductionPlanDetailRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public MES_ProductionPlanDetailService(
            IMES_ProductionPlanDetailRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }
        public override PageGridData<MES_ProductionPlanDetail> GetPageData(PageDataOptions options)
        {
            SummaryExpress = (ISugarQueryable<MES_ProductionPlanDetail> queryable) =>
            {
                return queryable.Select(x => new
                {
                    //AvgPrice注意大小写和数据库字段大小写一样
                    PlanQuantity = SqlFunc.AggregateSum(x.PlanQuantity)
                })
                .FirstOrDefault();
            };
            return base.GetPageData(options);
        }
    }
}
