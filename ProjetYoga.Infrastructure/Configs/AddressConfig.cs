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


        }
    }
}
