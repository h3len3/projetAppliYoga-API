using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Infrastructure.Configs
{
    internal class AdeptConfig : IEntityTypeConfiguration<Adept>
    {
        public void Configure(EntityTypeBuilder<Adept> builder)
        {
            // Configurations de la table Adept
            builder.Property(a => a.NameAdept)
                   .IsRequired()
                   .HasMaxLength(100);
            //HasMinLength(2) via validation

            builder.Property(a => a.LastnameAdept)
                   .IsRequired()
                   .HasMaxLength(100);
            // HasMinLength(2)via validation

            builder.Property(a => a.NissAdept)
                   .IsRequired()
                   .HasMaxLength(20);
            // HasMinLength(11) via validation

            // Créer un index unique sur le NissAdept
            builder.HasIndex(a => a.NissAdept)
                   .IsUnique();  // Cela garantit l'unicité dans la base de données

            // Lien avec la table Adresse (clé étrangère)
            builder.HasOne(a => a.Address)
                   .WithMany(ad => ad.Adepts)  // L'adresse peut être liée à plusieurs adeptes
                   .HasForeignKey(a => a.AddressId)
                   .OnDelete(DeleteBehavior.Cascade);  //  suppression en cascade
        }
    }
}
