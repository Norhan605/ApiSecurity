using APISecurity.Models;
using System.Threading.Tasks;

namespace APISecurity.Services
{
    public interface IAuthService
    {
        Task<AuthModel> ResigterAsync (RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
