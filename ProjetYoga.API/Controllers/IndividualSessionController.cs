using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetYoga.Application.Services;

namespace ProjetYoga.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndividualSessionController(IndividualSessionService individualSessionService) : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                throw new NotImplementedException();

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
