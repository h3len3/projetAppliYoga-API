using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Exceptions;
using ProjetYoga.Application.Interfaces;
using ProjetYoga.Application.Interfaces.Repositories;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Application.Utils;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ProjetYoga.Application.Services
{
    public class EventService(IEventRepository eventRepository, IMailer mailer, IUserRepository userRepository, IReservationRepository reservationRepository, IUserService userService, IPlaceEventYogaRepository placeEventYogaRepository) : IEventService
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
            //la place event yoga 
            if (dto.Id_PlaceEventYoga == 0)
            {
              PlaceEventYoga placeEventYoga =  new PlaceEventYoga
                {
                    NamePlaceEventYoga = dto.NewPlaceEventYoga!.Name,
                    Address = new Address
                    {
                        Street = dto.NewPlaceEventYoga.Address.Street,
                        NumberStreet = dto.NewPlaceEventYoga.Address.NumberStreet,
                        PostalCode = dto.NewPlaceEventYoga.Address.PostalCode,
                        City = dto.NewPlaceEventYoga.Address.City,
                        Country = dto.NewPlaceEventYoga.Address.Country

                    }
                };

                placeEventYogaRepository.Add( placeEventYoga );
                dto.Id_PlaceEventYoga = placeEventYoga.Id_PlaceEventYoga;

            }

            

            Event toAdd = GetTypeForEvent(dto.Type);
            toAdd.Title = dto.Title;
            toAdd.Description = dto.Description;
            toAdd.StartDate = dto.StartDate;
            toAdd.EndDate = dto.EndDate;
            toAdd.MaxSub = dto.MaxSub;
            toAdd.MinSub = dto.MinSub;
            toAdd.Available = true;
            toAdd.Id_PlaceEventYoga = dto.Id_PlaceEventYoga ?? 0;
            
            eventRepository.Add( toAdd );
            return toAdd ;

    }

        //public Event Register(EventFormDTO dto, NewPlaceEventYogaDTO dtoNPEY, CreateAddressDTO dtoA)
        //{
        //    throw new NotImplementedException();
        //}

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

            toUpdate.PlaceEventYoga = dto.Id_PlaceEventYoga != null ? null : new PlaceEventYoga
            {
                NamePlaceEventYoga = dto.NewPlaceEventYoga.Name,
                Address = new Address
                {
                    Street = dto.NewPlaceEventYoga.Address.Street,
                    NumberStreet = dto.NewPlaceEventYoga.Address.NumberStreet,
                    PostalCode = dto.NewPlaceEventYoga.Address.PostalCode,
                    City = dto.NewPlaceEventYoga.Address.City,
                    Country = dto.NewPlaceEventYoga.Address.Country

                }
            };



            eventRepository.Update(toUpdate);
        }

        public void DeleteEvent(int Id_Event)
        {
            Event? toDelete = eventRepository.FindOne(Id_Event);
            if (toDelete is null) { throw new KeyNotFoundException(); }
            eventRepository.Remove(toDelete);
        }


        public void Booking(int Id_Event, EventBookingDTO dtoB) 
        {
            // Transaction (using ci-dessous + en fin transactionScope.Complete();)
            using TransactionScope transactionScope = new();
            User u = userRepository.FindOneWhere(u => u.Email == dtoB.Email) 
                ?? userService.Register(new UserRegisterDTO
                {
                    email = dtoB.Email,
                    password = "1234"
                });
            // vérifier email unique
            // list des inscri à cet event ou liste des email de linscrà cet event = cmt y arriver
            if (reservationRepository.Any(r => r.Id_Event == Id_Event && r.Id_User == u.Id_User))
            {
                throw new DuplicateReservationException(); 
            };
            reservationRepository.Add(new Reservation
            {
                Id_Event = Id_Event,
                Id_User = u.Id_User,
                Payed = false,
                PaymentModeId = 1
            });
            // régles pour s'incr à un event, comme exemple : pas à un event passé
            // email qui existe            
            // envoyer un mail 
            Event thisEvent = eventRepository.FindOne(Id_Event);
            mailer.Send(dtoB.Email, "Inscription", $"Bienvenue, par ce mail nous vous confirmons que votre inscription à {thisEvent.Title}, prévu de {thisEvent.StartDate.ToLocalTime()} à {thisEvent.EndDate.ToLocalTime()}. Merci & à bientôt ! ");
            transactionScope.Complete();
            
        }

    }
}
