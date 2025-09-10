/*
 *所有关于Sys_Dicts类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*Sys_DictsService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
*/
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using N2.Core.BaseProvider;
using N2.Core.Extensions;
using N2.Core.Extensions.AutofacManager;
using N2.Core.Utilities;
using N2.Entity.DomainModels;
using N2.Sys.IRepositories;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace N2.Sys.Services
{
    public partial class Sys_DictsService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ISys_DictsRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public Sys_DictsService(
            ISys_DictsRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }

        public async Task<List<Sys_Dicts>> GetSysDics()
        {
            return await repository.FindAsync(x => 1 == 1, s => s);
        }
    }
}
