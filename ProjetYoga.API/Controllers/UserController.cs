using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Exceptions;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Application.Services;
using ProjetYoga.Domain.Entities;
using System.Net.Mail;

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
                return Created("user/" + u.Id_User, new RegisterUserResultDTO(u));

            }
            catch (DuplicatePropertyException ex) 
            {
                return Conflict(ex.Message);
            }
            catch (SmtpException)
            {
                return Problem("L'email n'a pas pu être envoyé");
            }

        }

        
    }
}
