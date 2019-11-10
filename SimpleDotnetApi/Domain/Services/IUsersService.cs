using SimpleDotnetApi.Domain.Models;
using System.Threading.Tasks;

namespace SimpleDotnetApi.Domain.Services
{
    public interface IUsersService
    {
        Task<StatusCodeModel> GetUsers();
    }
}
