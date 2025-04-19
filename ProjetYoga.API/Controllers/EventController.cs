using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Services;

namespace ProjetYoga.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController(EventService eventService) : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(CreateEventDTO dto)
        {
            try
            {
                eventService.CreateEvent(dto);
                return Created();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
