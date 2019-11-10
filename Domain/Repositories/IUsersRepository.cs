using RestSharp;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IUsersRepository
    {
        Task<IRestResponse> GetUsers();
    }
}
