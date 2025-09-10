/*
 *Author：jxx
 *Contact：283591387@qq.com
 *Date：2018-07-01
 * 此代码由框架生成，请勿随意更改
 */
using N2.Sys.IRepositories;
using N2.Core.BaseProvider;
using N2.Core.DbContext;
using N2.Core.Extensions.AutofacManager;
using N2.Entity.DomainModels;

namespace N2.Sys.Repositories
{
    public partial class Sys_RoleRepository : RepositoryBase<Sys_Role>, ISys_RoleRepository
    {
        public Sys_RoleRepository(N2Context dbContext)
        : base(dbContext)
        {

        }
        public static ISys_RoleRepository Instance
        {
            get { return AutofacContainerModule.GetService<ISys_RoleRepository>(); }
        }
    }
}

