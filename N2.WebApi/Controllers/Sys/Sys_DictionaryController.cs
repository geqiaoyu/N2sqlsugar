using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using N2.Core.Controllers.Basic;
using N2.Core.Extensions;
using N2.Core.Filters;
using N2.Sys.IServices;

namespace N2.Sys.Controllers
{
    [Route("api/Sys_Dictionary")]
    public partial class Sys_DictionaryController : ApiBaseController<ISys_DictionaryService>
    {
        public Sys_DictionaryController(ISys_DictionaryService service)
        : base("System", "System", "Sys_Dictionary", service)
        {
        }
    }
}
