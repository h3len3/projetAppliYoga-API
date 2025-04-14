using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Infrastructure.Configs
{
    internal class IndividualSessionConfig : IEntityTypeConfiguration<IndividualSession>
    {
        public void Configure(EntityTypeBuilder<IndividualSession> builder)
        {
            builder.ToTable("Event");
        }
    }
}
