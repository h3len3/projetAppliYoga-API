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
    public class SpecialEvent : IEntityTypeConfiguration<SpecialEvent>
    {
        public void Configure(EntityTypeBuilder<SpecialEvent> builder)
        {
            builder.ToTable("SpecialEvent");
        }
    }
}
