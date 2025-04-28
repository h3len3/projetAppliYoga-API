using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
    public class EventService(IEventRepository eventRepository) : IEventService
    {
        public List<Event> GetEvents()
        {
            return eventRepository.Find();
        }

        // créer un Event <-> règles métier
        public Event Register(CreateEventDTO dto, NewPlaceEventYogaDTO dtoNPEY, CreateAddressDTO dtoA )
        {
            // vérifier toutes les règles de création : pas vraiment dans ce cas

            //enregistrer, dans la DB
            Event e = eventRepository.Add(new Event
            {
                Title = dto.Title,
                Description = dto.Description,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                MaxSub = dto.MaxSub,
                MinSub = dto.MinSub,
                Available = true,
                Id_PlaceEventYoga = dto.Id_PlaceEventYoga ?? 0,
                //TODO ou new
                //PlaceEventYoga = new PlaceEventYoga
                //{
                //    NamePlaceEventYoga = dtoNPEY.Name,
                //    Address = new Address
                //    {
                //        Street = dtoA.Street,
                //        NumberStreet = dtoA.NumberStreet,
                //        City = dtoA.City,
                //        PostalCode = dtoA.PostalCode,
                //        Country = dtoA.Country,

                //    }
                //}
            });

            return e;


        }

       
    }
}
