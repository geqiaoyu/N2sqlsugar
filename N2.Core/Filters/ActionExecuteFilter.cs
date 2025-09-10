using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using N2.Core.Enums;
using N2.Core.Extensions;
using N2.Core.ObjectActionValidator;
using N2.Core.Services;
using N2.Core.Utilities;

namespace N2.Core.Filters
{
    public class ActionExecuteFilter : IActionFilter
    {

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //验证方法参数
            context.ActionParamsValidator();
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}