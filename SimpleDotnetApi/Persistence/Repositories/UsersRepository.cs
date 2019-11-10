using Microsoft.Extensions.Configuration;
using RestSharp;
using Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace SimpleDotnetApi.Persistence.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IRestClient _client;
        private readonly IConfiguration _configuration;

        public UsersRepository(IRestClient client, IConfiguration configuration)
        {
            _client = client;
            _configuration = configuration;
        }

        public async Task<IRestResponse> GetUsers()
        {
            IRestRequest request = new RestRequest(_configuration["UsersUrl"], Method.GET);
            IRestResponse response = await _client.ExecuteTaskAsync(request);
            return response;
        }
    }
}
