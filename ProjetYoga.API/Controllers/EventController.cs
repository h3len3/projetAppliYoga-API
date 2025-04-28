using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Application.Services;

namespace ProjetYoga.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController(IEventService eventService) : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(EventFormDTO dto)
        {
            
            
                eventService.Register(dto);
                return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, EventFormDTO dto)
        {
            eventService.UpdateEvent(id, dto);
            return Created();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(eventService.GetEvents().Select(e => new EventDTO(e)));
        }
    }
}
