using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class PlaceEventYoga
    {
        public int Id_PlaceEventYoga { get; set; }
        public string NamePlaceEventYoga { get; set; }

        // Relations : 
        // avec address : one to one : 
        public int Id_Address { get; set; }
        public Address Address { get; set; }

        // avec Event : one to many - FK ds Event poitant vers PlaceEventYoga:

        public ICollection<Event> Events { get; set; }

    }
}
