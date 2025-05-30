﻿
using Be.Khunly.EFRepository.Abstraction;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.Interfaces.Repositories
{
    public interface IEventRepository: IRepositoryBase<Event>
    {
        Event? FindOneByIdWithLocation(int id_Event);
        public List<Event> GetAllWithPlaceAndAddress();

    }
}
