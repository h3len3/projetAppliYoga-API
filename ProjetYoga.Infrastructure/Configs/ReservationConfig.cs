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
    internal class ReservationConfig : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("Reservation");

            builder.HasKey(r => new { r.Id_User, r.Id_Event }); // many-to-many


            builder.Property(r => r.DateReservation)
                .IsRequired();

            builder.Property(r => r.Payed)
                .IsRequired();

 // many-to-many enrichie entre User et Event, 
     //avec une table de jointure personnalisée appelée Reservation
       // Ce genre de relation se modélise comme deux relations one-to-many vers une entité intermédiaire (Reservation), qui devient une entité à part entière.

            builder.HasOne(r => r.User)
                .WithMany(u => u.Reservations)
                .HasForeignKey(r => r.Id_User);

            builder.HasOne(r => r.Event)
                .WithMany(e => e.Reservations)
                .HasForeignKey(r => r.Id_Event);

 // Relation avec PaymentMode (one-to-many)
            builder.HasOne(r => r.PaymentMode)
                        .WithMany(pm => pm.Reservations)
                        .HasForeignKey(r => r.PaymentModeId)
                        .IsRequired();
        }
    }
}
