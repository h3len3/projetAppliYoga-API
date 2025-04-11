using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int MaxSub { get; set; }

        public int? MinSub { get; set; }

        public bool Available { get; set; }

        // Foreign key vers PlaceEventYoga
        public int PlaceEventYogaId { get; set; }

       // public PlaceEventYoga PlaceEventYoga { get; set; } = null!;

        // Navigation vers les réservations (relation many-to-many via Reservation)
       // public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
