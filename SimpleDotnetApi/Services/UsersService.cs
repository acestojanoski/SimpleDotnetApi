using Newtonsoft.Json;
using RestSharp;
using Domain.Models;
using Domain.Repositories;
using Domain.Services;
using System.Threading.Tasks;

namespace SimpleDotnetApi.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _repository;

        public UsersService(IUsersRepository repository)
        {
            _repository = repository;
        }

        public async Task<StatusCodeModel> GetUsers()
        {
            IRestResponse response = await _repository.GetUsers();
            return new StatusCodeModel()
            {
                StatusCode = (int)response.StatusCode,
                Content = JsonConvert.DeserializeObject(response.Content)
            };
        }
    }
}
