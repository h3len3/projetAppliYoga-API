using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetYoga.Application.Utils;

namespace ProjetYoga.Infrastructure.Configs
{
    internal class AdeptConfig : IEntityTypeConfiguration<Adept>
    {
        public void Configure(EntityTypeBuilder<Adept> builder)
        {
            // Nom de la table
            builder.ToTable("Adept");

            // NameAdept : string, non nullable, taille min et max
            builder.Property(a => a.NameAdept)
                .IsRequired()
                .HasMaxLength(100);
            //.HasMinLength(2);  

            // LastNameAdept : string, non nullable, taille min et max
            builder.Property(a => a.LastnameAdept)
                .IsRequired()
                .HasMaxLength(100);
                //.HasMinLength(2);

            // NissAdept : string, non nullable, format NISS
            builder.Property(a => a.NissAdept)
                .IsRequired()
                .HasMaxLength(11)  // le NISS est souvent de 11 chiffres
                .IsFixedLength();

            // BithDate : 
            builder.Property(a => a.BirthDate)
                .IsRequired();


            // Relation avec Address - One-to-many : 
            builder.HasOne(a => a.Address)
                .WithMany(ad => ad.Adepts)
                .HasForeignKey(a => a.Id_Address)
                .OnDelete(DeleteBehavior.Restrict); // ou Cascade, changer plus tard

            builder.HasData([
                new Adept {
                    Id_User = 3,
                    Email = "lykhun@gmail.com",
                    Password = PasswordUtils.HashPassword("1234", new Guid("a802db70-4c4d-4e0d-80b1-9ec3f61608c8")),
                    Salt = new Guid("a802db70-4c4d-4e0d-80b1-9ec3f61608c8"),
                    NameAdept = "Khun",
                    LastnameAdept = "Ly",
                    NissAdept = "82050620316",
                    PhoneAdept = "0000000",
                    Id_Address = 2,
                }
                ]); ;

        }
    }
}
