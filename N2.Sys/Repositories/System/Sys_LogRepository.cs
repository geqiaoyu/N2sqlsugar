using N2.Sys.IRepositories;
using N2.Core.BaseProvider;
using N2.Core.Extensions.AutofacManager;
using N2.Core.DbContext;
using N2.Entity.DomainModels;

namespace N2.Sys.Repositories
{
    public partial class Sys_LogRepository : RepositoryBase<Sys_Log>, ISys_LogRepository
    {
        public Sys_LogRepository(N2Context dbContext)
        : base(dbContext)
        {

        }
        public static ISys_LogRepository GetService
        {
            get { return AutofacContainerModule.GetService<ISys_LogRepository>(); }
        }
    }
}

