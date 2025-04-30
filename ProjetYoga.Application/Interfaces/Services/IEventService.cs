using ProjetYoga.Application.DTO;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.Interfaces.Services
{
    public interface IEventService
    {
        List<Event> GetEvents();

        Event Register(EventFormDTO dto);
        void UpdateEvent(int id, EventFormDTO dto);

        void DeleteEvent(int id);

        void Booking(int Id_Event, EventBookingDTO dtoB);


    }
}
