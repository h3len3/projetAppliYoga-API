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
    internal class EventConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Event");

            // Clé primaire avec auto-incrément
            builder.HasKey(e => e.Id_Event);
            builder.Property(e => e.Id_Event)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            // Titre : requis, min 5 max 255
            builder.Property(e => e.Title)
                   .IsRequired()
                   .HasMaxLength(255);
                   //HasMinLength(5); // MinLength n'est pas supporté en DB directement -> le valider via FluentValidation ou DataAnnotation

            // Description : requis, min 20 max 2000
            builder.Property(e => e.Description)
                   .IsRequired()
                   .HasMaxLength(2000); 
                    // Pas de HasMinLength natif ici non plus -> le valider via FluentValidation ou DataAnnotation


            // StartDate : requis
            builder.Property(e => e.StartDate)
                   .IsRequired();

            // EndDate : requis
            builder.Property(e => e.EndDate)
                   .IsRequired();

            // MaxSub : requis
            builder.Property(e => e.MaxSub)
                   .IsRequired();

            // MinSub : facultatif
            builder.Property(e => e.MinSub);

            // Available : requis
            builder.Property(e => e.Available)
                   .IsRequired();

            // Relation avec PlaceEventYooga (one-to-many) : 
            builder.HasOne(e => e.PlaceEventYoga)
                .WithMany(p => p.Events)
                .HasForeignKey(e => e.Id_PlaceEventYoga)
                .IsRequired();

        }

    }
}
