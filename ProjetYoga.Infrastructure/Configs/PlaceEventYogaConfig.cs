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
            builder.HasKey(p => p.id_PlaceEventYoga);

            // Auto-incrémentée
            builder.Property(p => p.id_PlaceEventYoga)
                   .ValueGeneratedOnAdd();

            // namePlaceEventYoga requis
            builder.Property(p => p.namePlaceEventYoga)
                   .IsRequired()
                   .HasMaxLength(100); 

           
        }

    }
}
