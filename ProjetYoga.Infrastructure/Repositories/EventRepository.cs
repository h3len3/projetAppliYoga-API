using Be.Khunly.EFRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjetYoga.Application.Interfaces.Repositories;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Infrastructure.Repositories
{
    public class EventRepository(ProjetYogaContext context): RepositoryBase<Event>(context), IEventRepository
    {
        public Event? FindOneByIdWithLocation(int id_Event)
        {
            return context.Events
               .Include(e => e.PlaceEventYoga)
                   .ThenInclude(p => p.Address)
               .FirstOrDefault(e=>e.Id_Event== id_Event);
        }

        public List<Event> GetAllWithPlaceAndAddress()
        {
            return context.Events
                .Include(e => e.PlaceEventYoga)
                    .ThenInclude(p => p.Address)
                .ToList();
        }

    }
}
