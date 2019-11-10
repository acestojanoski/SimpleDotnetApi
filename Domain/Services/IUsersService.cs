using Domain.Models;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IUsersService
    {
        Task<StatusCodeModel> GetUsers();
    }
}
