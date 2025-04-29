using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Interfaces.Repositories;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ProjetYoga.Application.Services
{
    public class EventService(IEventRepository eventRepository) : IEventService
    {
        public List<Event> GetEvents()
        {
            return eventRepository.Find();
        }

        // créer un Event <-> règles métier

        // pour gérer le type d'évènement 
        public Event GetTypeForEvent(string category)
        {
            switch (category)
            {
                case "GroupSession":
                    return new GroupSession();

                case "IndividualSession":
                    return new IndividualSession();

                case "SpecialEvent":
                    return new SpecialEvent();

                default:
                    return new Event();
            }
        }
        public Event Register(EventFormDTO dto )
        {
            // vérifier toutes les règles de création : pas vraiment dans ce cas

            //enregistrer, dans la DB
            Event toAdd = GetTypeForEvent(dto.Type);
            toAdd.Title = dto.Title;
            toAdd.Description = dto.Description;
            toAdd.StartDate = dto.StartDate;
            toAdd.EndDate = dto.EndDate;
            toAdd.MaxSub = dto.MaxSub;
            toAdd.MinSub = dto.MinSub;
            toAdd.Available = true;
            toAdd.Id_PlaceEventYoga = dto.Id_PlaceEventYoga ?? 0;

            Event e = eventRepository.Add(toAdd);

            return e;


        }

        public Event Register(EventFormDTO dto, NewPlaceEventYogaDTO dtoNPEY, CreateAddressDTO dtoA)
        {
            throw new NotImplementedException();
        }

        public void UpdateEvent(int Id_Event, EventFormDTO dto)
        {
            Event? toUpdate = eventRepository.FindOne(Id_Event);
            if (toUpdate is null)
            {
                throw new KeyNotFoundException();
            }

            toUpdate.Title = dto.Title;
            toUpdate.Description = dto.Description;
            toUpdate.StartDate = dto.StartDate;
            toUpdate.EndDate = dto.EndDate;
            toUpdate.MaxSub = dto.MaxSub;
            toUpdate.MinSub = dto.MinSub;
            toUpdate.Available = true;
            toUpdate.Id_PlaceEventYoga = dto.Id_PlaceEventYoga ?? 0;
            
           
           
           eventRepository.Update(toUpdate);
        }

        


    }
}
