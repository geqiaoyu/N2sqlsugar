using N2.Sys.IRepositories;
using N2.Core.BaseProvider;
using N2.Core.Extensions.AutofacManager;
using N2.Core.DbContext;
using N2.Entity.DomainModels;

namespace N2.Sys.Repositories
{
    public partial class Sys_MenuRepository : RepositoryBase<Sys_Menu>, ISys_MenuRepository
    {
        public Sys_MenuRepository(N2Context dbContext)
        : base(dbContext)
        {

        }
        public static ISys_MenuRepository Instance
        {
            get { return AutofacContainerModule.GetService<ISys_MenuRepository>(); }
        }
    }
}

