using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.DTO
{
    public class EventDTO(Event e)
    {
        public int Id { get; set; } = e.Id_Event;
        public string Title { get; set; } = e.Title;
        public string Description { get; set; } = e.Description;
        public DateTime StartDate { get; set; } = e.StartDate.ToLocalTime();
        public DateTime EndDate { get; set; } = e.EndDate.ToLocalTime();
        public string Type { get; set; } = e.Type;
        public int Id_PlaceEventYoga { get; set; } = e.Id_PlaceEventYoga;
    }
}
