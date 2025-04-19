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
    internal class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");

            builder.HasKey(t => t.Id_Address);

            builder.Property(t => t.Id_Address)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-incrémentation


            builder.Property(a => a.Street)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(ad => ad.NumberStreet)
                 .IsRequired()
                 .HasMaxLength(50);

            builder.Property(a => a.PostalCode)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.Property(a => a.City)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.Property(a => a.PostalCode)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.Property(a => a.Country)
                  .IsRequired()
                  .HasMaxLength(100);

            // Relations : 
            // PlaceEventYoga - One-to-one : 
            builder.HasOne(ad => ad.PlaceEventYoga)
                    .WithOne(pey => pey.Address)
                    .HasForeignKey<PlaceEventYoga>(pey => pey.Id_Address)
                    .OnDelete(DeleteBehavior.Restrict); // ou Cascade, à changer plus tard

            // data
            builder.HasData([
                new Address {
                    Id_Address = 1,
                    Street = "Rue du parc Saint-Antoine",
                    NumberStreet = 123,
                    City = "Bruxelles",
                    PostalCode = "1040",
                    Country = "Belgique"
                }
            ]);


        }
    }
}
