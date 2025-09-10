/*
 *所有关于MES_ProductInbound类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*MES_ProductInboundService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
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
    public partial class MES_ProductInboundService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMES_ProductInboundRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public MES_ProductInboundService(
            IMES_ProductInboundRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }

        public override PageGridData<MES_ProductInbound> GetPageData(PageDataOptions options)
        {
            SummaryExpress = (ISugarQueryable<MES_ProductInbound> queryable) =>
            {
                return queryable.Select(x => new
                {
                    InboundQuantity = SqlFunc.AggregateSum(x.InboundQuantity).ToString("f2")
                })
            .FirstOrDefault();
            };
            return base.GetPageData(options);
        }
    }
}
