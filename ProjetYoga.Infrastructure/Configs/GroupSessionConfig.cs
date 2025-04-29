using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Infrastructure.Configs
{
    internal class GroupSessionConfig : IEntityTypeConfiguration<GroupSession>
    {
        public void Configure(EntityTypeBuilder<GroupSession> builder)
        {
            builder.ToTable("GroupSession");


        }
    }
}
