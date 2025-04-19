using Be.Khunly.EFRepository;
using ProjetYoga.Application.Interfaces.Repositories;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Infrastructure.Repositories
{
    internal class TypeSubRepository(ProjetYogaContext context) : RepositoryBase<TypeSub>(context), ITypeSubRepository
    {
    }
}
