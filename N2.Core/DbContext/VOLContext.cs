using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel;
using Microsoft.Extensions.Logging;
using SqlSugar;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using N2.Core.DBManager;
using N2.Core.DbSqlSugar;
using N2.Core.Extensions;
using N2.Core.Extensions.AutofacManager;
using N2.Entity.SystemModels;

namespace N2.Core.DbContext
{
    public class N2Context : DbContext, IDependency
    {
        public N2Context() : base()
        {
            base.SqlSugarClient = DbManger.Db;
        }
        public N2Context(string configId) : base()
        {
            base.SqlSugarClient = DbManger.GetConnection(configId);
        }
    }
}
