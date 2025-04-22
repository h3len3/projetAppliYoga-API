using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Interfaces.Repositories;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.Services
{
    public class PlaceEventYogaService(IPlaceEventYogaRepository placeEventYogaRepository) : IPlaceEventYogaService
    {
        public List<PlaceEventYoga> GetAll()
        {
           return placeEventYogaRepository.Find();
        }

        public PlaceEventYoga Register(CreatePlaceEventYogaDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
