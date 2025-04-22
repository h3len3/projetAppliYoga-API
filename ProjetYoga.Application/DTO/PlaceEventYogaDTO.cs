using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.DTO
{
    public class PlaceEventYogaDTO(PlaceEventYoga p)
    {
        public int Id { get; set; } = p.Id_PlaceEventYoga;
        public string Name { get; set; } = p.NamePlaceEventYoga;
    }
}
