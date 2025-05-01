using Be.Khunly.EFRepository;
using Microsoft.EntityFrameworkCore;
using ProjetYoga.Application.Interfaces.Repositories;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Infrastructure.Repositories
{
    public class ReservationRepository(ProjetYogaContext context) : RepositoryBase<Reservation>(context), IReservationRepository
    {
        public List<Reservation> FindAllByEventId(int eventId)
        {
            return context.Reservations.Include(r => r.User).Include(r => r.Event).Where(r => r.Id_Event == eventId).ToList();
        }
    }
}

// ct : 
//public List<Reservation> FindAllByEventId(int eventId)
//{
//    return _context.Reservations
//        .Include(r => r.User)
//        .Where(r => r.Id_Event == eventId)
//        .ToList();
//}