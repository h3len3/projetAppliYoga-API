using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Application.Services;

namespace ProjetYoga.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdeptController(AdeptService adeptService) : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
