using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Services;

namespace SimpleDotnetApi.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        private readonly IUsersService _service;

        public UsersController(IUsersService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetTodos()
        {
            try
            {
                var response = await _service.GetUsers();
                return StatusCode(response.StatusCode, response.Content);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return StatusCode(500, new { exception.Message });
            }
        }
    }
}
