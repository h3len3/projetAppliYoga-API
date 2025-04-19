using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetYoga.Application.Services;

namespace ProjetYoga.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceEventYogaController(PlaceEventYogaService placeEventYogaService) : ControllerBase
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
