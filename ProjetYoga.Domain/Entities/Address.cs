using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class Address
    {
        public int Id_Address { get; set; }

        public string Street { get; set; }
        public int NumberStreet { get; set; }

        public string City { get; set; } 
        public string PostalCode { get; set; }

        public string Country { get; set; }

        // Relations : 

        // avec Adept (One-to-many) : 
        public ICollection<Adept> Adepts { get; set; }
        // public ICollection<Adept> Adepts { get; set; } = new List<Adept>(); 

        // avec PlaceEventYoga  (One-to-one) : 
        public PlaceEventYoga PlaceEventYoga { get; set; } // 1:1
    }
}
