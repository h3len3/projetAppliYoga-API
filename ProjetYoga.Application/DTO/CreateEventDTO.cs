using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.DTO
{
    public class CreateEventDTO
    {

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int MaxSub { get; set; }

        public int? MinSub { get; set; }

        public bool Available { get; set; }

        // pour placeEventYoga
        // Soit on envoie un ID existant...
        public int? Id_PlaceEventYoga { get; set; }

        // ... soit un nouveau lieu à créer
        public NewPlaceEventYogaDTO? NewPlaceEventYoga { get; set; }

    }
}
