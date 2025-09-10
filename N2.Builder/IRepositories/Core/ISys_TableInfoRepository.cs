using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N2.Core.BaseProvider;
using N2.Entity.DomainModels;
using N2.Core.Extensions.AutofacManager;
namespace N2.Builder.IRepositories
{
    public partial interface ISys_TableInfoRepository : IDependency,IRepository<Sys_TableInfo>
    {
    }
}

