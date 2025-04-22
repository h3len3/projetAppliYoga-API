using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Application.Services;

namespace ProjetYoga.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceEventYogaController(IPlaceEventYogaService placeEventYogaService) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(placeEventYogaService.GetAll().Select(p => new PlaceEventYogaDTO(p)));
        }

        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                throw   new NotImplementedException();

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
