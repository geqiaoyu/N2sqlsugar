/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Sys_UserService与ISys_UserService中编写
 */
using N2.Sys.IRepositories;
using N2.Sys.IServices;
using N2.Core.BaseProvider;
using N2.Core.Extensions.AutofacManager;
using N2.Entity.DomainModels;

namespace N2.Sys.Services
{
    public partial class Sys_UserService : ServiceBase<Sys_User, ISys_UserRepository>
    , ISys_UserService, IDependency
    {
    public static ISys_UserService Instance
    {
      get { return AutofacContainerModule.GetService<ISys_UserService>(); } }
    }
 }
