﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class Event
    {
        public int Id_Event { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int MaxSub { get; set; }

        public int? MinSub { get; set; }

        public bool Available { get; set; }

        // Relations : 

        // H -> GroupSession, IndividualSession, SpecialEvent  : Fait

        // many to many avec User:
        public ICollection<Reservation> Reservations { get; set; }

        // many to one - FK ds Event poitant vers PlaceEventYoga:
        public int Id_PlaceEventYoga { get; set; }

        [ForeignKey("Id_PlaceEventYoga")]
        public PlaceEventYoga PlaceEventYoga { get; set; }

        public virtual string Type => "Autre";
    }
}
