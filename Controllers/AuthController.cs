using EmployeeApi.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if (username == "teste" && password == "123")
            {
                var token = TokenService.GenerateToken(new Domain.Models.EmployeeModel());
                return Ok(token);
            }

            return BadRequest("username or password invalid");
        }
    }
}
