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
    public class SpecialEventConfig : IEntityTypeConfiguration<SpecialEvent>
    {
        public void Configure(EntityTypeBuilder<SpecialEvent> builder)
        {
            builder.ToTable("SpecialEvent");

            builder.HasData([
                 new SpecialEvent {
                    Id_Event = 2,
                    Title= "Souper des anciens",
                    Description = "chants, postures, méditation",
                    StartDate = new DateTime(2025, 5, 11, 9, 0, 0),
                    EndDate = new DateTime(2025, 5, 11, 17, 0, 0),
                    MaxSub = 15,
                    MinSub = 3,
                    Available = true,
                    Id_PlaceEventYoga = 1
                }
            ]);
        }
    }
}
