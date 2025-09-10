using System;
using System.Collections.Generic;
using System.Text;

namespace N2.Core.DBManager
{
    public class DBConnectionAttribute : Attribute
    {
        public string DBName { get; set; }
    }
}
