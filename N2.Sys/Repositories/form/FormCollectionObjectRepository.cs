/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹FormCollectionObjectRepository编写代码
 */
using N2.Sys.IRepositories;
using N2.Core.BaseProvider;
using N2.Core.DbContext;
using N2.Core.Extensions.AutofacManager;
using N2.Entity.DomainModels;

namespace N2.Sys.Repositories
{
    public partial class FormCollectionObjectRepository : RepositoryBase<FormCollectionObject> , IFormCollectionObjectRepository
    {
    public FormCollectionObjectRepository(N2Context dbContext)
    : base(dbContext)
    {

    }
    public static IFormCollectionObjectRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IFormCollectionObjectRepository>(); } }
    }
}
