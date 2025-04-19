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
    internal class PlaceEventYogaConfig: IEntityTypeConfiguration<PlaceEventYoga>
    {
        public void Configure(EntityTypeBuilder<PlaceEventYoga> builder)
        {
            // Nom de la table
            builder.ToTable("PlaceEventYoga");

            // Clé primaire
            builder.HasKey(p => p.Id_PlaceEventYoga);

            // Auto-incrémentée
            builder.Property(p => p.Id_PlaceEventYoga)
                   .ValueGeneratedOnAdd();

            // namePlaceEventYoga requis
            builder.Property(p => p.NamePlaceEventYoga)
                   .IsRequired()
                   .HasMaxLength(100);

            // Relations : 
            // Address - One-to-one : 
            builder.HasOne(p => p.Address)
                .WithOne(ad => ad.PlaceEventYoga)
                .HasForeignKey<PlaceEventYoga>(p => p.Id_Address);

            // data 
            builder.HasData([
                new PlaceEventYoga {
                    Id_PlaceEventYoga = 1,
                    NamePlaceEventYoga = "Studio du Parc Antoine",
                    Id_Address = 1
                }
            ]);

        }

    }
}
