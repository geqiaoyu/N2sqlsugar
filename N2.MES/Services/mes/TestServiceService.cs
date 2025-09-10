/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下TestServiceService与ITestServiceService中编写
 */
using N2.MES.IRepositories;
using N2.MES.IServices;
using N2.Core.BaseProvider;
using N2.Core.Extensions.AutofacManager;
using N2.Entity.DomainModels;

namespace N2.MES.Services
{
    public partial class TestServiceService : ServiceBase<TestService, ITestServiceRepository>
    , ITestServiceService, IDependency
    {
    public static ITestServiceService Instance
    {
      get { return AutofacContainerModule.GetService<ITestServiceService>(); } }
    }
 }
