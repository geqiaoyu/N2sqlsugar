/*
*所有关于Sys_Dicts类的业务代码接口应在此处编写
*/
using N2.Core.BaseProvider;
using N2.Core.Utilities;
using N2.Entity.DomainModels;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
namespace N2.Sys.IServices
{
    public partial interface ISys_DictsService
    {
        Task<List<Sys_Dicts>> GetSysDics();
    }
 }
