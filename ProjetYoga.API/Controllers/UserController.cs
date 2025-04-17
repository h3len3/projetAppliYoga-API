using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Exceptions;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Application.Services;
using ProjetYoga.Domain.Entities;

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
                User u = userService.Register(dto);
                return Created("user/" + u.Id_User, u);

            }
            catch (DuplicatePropertyException ex) 
            {
                return Conflict(ex.Message);
            }

        }
    }
}
