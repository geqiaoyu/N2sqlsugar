/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下MES_SupplierService与IMES_SupplierService中编写
 */
using N2.MES.IRepositories;
using N2.MES.IServices;
using N2.Core.BaseProvider;
using N2.Core.Extensions.AutofacManager;
using N2.Entity.DomainModels;

namespace N2.MES.Services
{
    public partial class MES_SupplierService : ServiceBase<MES_Supplier, IMES_SupplierRepository>
    , IMES_SupplierService, IDependency
    {
    public static IMES_SupplierService Instance
    {
      get { return AutofacContainerModule.GetService<IMES_SupplierService>(); } }
    }
 }
