﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetYoga.Application.Utils;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Infrastructure.Configs
{
    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(u => u.Id_User);

            builder.Property(u => u.Id_User)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(255);
            //email doit être unique:
            builder.HasIndex(u => u.Email)
                   .IsUnique();

            builder.Property(u => u.Password)
                   .IsRequired();
            
            builder.HasIndex(u => u.Salt).IsUnique();

            // Data
            builder.HasData([
                new User {
                    Id_User = 1,
                    Email = "lauravdn@gmail.com",
                    Salt = new Guid(),
                    Password = PasswordUtils.HashPassword("-namaste1234", new Guid())
                }
            ]);

        }
    }
}
