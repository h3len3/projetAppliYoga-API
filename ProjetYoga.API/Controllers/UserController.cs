using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Interfaces.Services;

namespace ProjetYoga.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] UserRegisterDTO dto)
        {
            try
            {

            }
            catch (Exception) 
            {
                throw;
            }

        }
    }
}
