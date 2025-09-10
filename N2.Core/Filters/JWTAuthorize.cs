using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;

namespace N2.Core.Filters
{
    public class JWTAuthorizeAttribute : AuthorizeAttribute
    {
        public JWTAuthorizeAttribute() : base()
        {

        }
    }
}
