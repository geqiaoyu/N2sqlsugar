using N2.Core.BaseProvider;
using N2.Core.Utilities;
using N2.Entity.DomainModels;
using System.Threading.Tasks;

namespace N2.Sys.IServices
{
    public partial interface ISys_UserService
    {

        Task<WebResponseContent> Login(LoginInfo loginInfo, bool verificationCode = true);
        Task<WebResponseContent> ReplaceToken();
        Task<WebResponseContent> ModifyPwd(string oldPwd, string newPwd);
        Task<WebResponseContent> GetCurrentUserInfo();
    }
}

