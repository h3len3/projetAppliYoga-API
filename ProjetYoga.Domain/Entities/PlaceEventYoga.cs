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
        public int id_PlaceEventYoga { get; set; }
        public string namePlaceEventYoga { get; set; }

        // relations : 
        // avec Event : one to many - FK ds Event poitant vers PlaceEventYoga
        // avec address : one to one 
    }
}
