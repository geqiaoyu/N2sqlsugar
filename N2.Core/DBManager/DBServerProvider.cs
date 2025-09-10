using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using N2.Core.Configuration;
using N2.Core.Const;
using N2.Core.DbContext;
using N2.Core.DbSqlSugar;
using N2.Core.Enums;
using N2.Core.Extensions;

namespace N2.Core.DBManager
{
    public partial class DBServerProvider: DbManger
    {
        private static Dictionary<string, string> ConnectionArray = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        private static readonly string DefaultConnName = "defalut";

        static DBServerProvider()
        {
            SetConnection(DefaultConnName, AppSetting.DbConnectionString);
        }
        public static void SetConnection(string key, string val)
        {
            if (ConnectionArray.ContainsKey(key))
            {
                ConnectionArray[key] = val;
                return;
            }
            ConnectionArray.Add(key, val);
        }
        /// <summary>
        /// 设置默认数据库连接
        /// </summary>
        /// <param name="val"></param>
        public static void SetDefaultConnection(string val)
        {
            SetConnection(DefaultConnName, val); 
        }

        public static string GetConnectionString(string key)
        {
            key = key ?? DefaultConnName;
            if (ConnectionArray.ContainsKey(key))
            {
                return ConnectionArray[key];
            }
            return key;
        }
        /// <summary>
        /// 获取默认数据库连接
        /// </summary>
        /// <returns></returns>
        public static string GetConnectionString()
        {
            return GetConnectionString(DefaultConnName);
        }
        public static N2Context DbContext
        {
            get { return Utilities.HttpContext.Current.RequestServices.GetService(typeof(N2Context)) as N2Context; }
        }
    }
}
