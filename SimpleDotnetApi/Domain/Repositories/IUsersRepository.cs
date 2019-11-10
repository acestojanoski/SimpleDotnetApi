using RestSharp;
using System.Threading.Tasks;

namespace SimpleDotnetApi.Domain.Repositories
{
    public interface IUsersRepository
    {
        Task<IRestResponse> GetUsers();
    }
}
