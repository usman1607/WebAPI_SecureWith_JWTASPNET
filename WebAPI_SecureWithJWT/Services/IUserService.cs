using System.Threading.Tasks;
using WebAPI_SecureWithJWT.Models;

namespace WebAPI_SecureWithJWT.Services
{
    public interface IUserService
    {
        Task<string> RegisterAsync(RegisterModel model);
        Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
