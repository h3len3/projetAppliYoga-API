﻿using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Interfaces.Repositories;
using ProjetYoga.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.Services
{
    public class EventService(IEventRepository eventRepository) : IEventService
    {
        // créer un Event <-> règles métier
        public void CreateEvent(CreateEventDTO dto)
        {
            // vérifier toutes les règles de création : pas vraiment dans ce cas

            //enregistrer, dans la DB
            eventRepository.Add();

            
        }
    }
}
