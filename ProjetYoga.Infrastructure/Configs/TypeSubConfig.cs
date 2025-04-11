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
    internal class TypeSubConfig : IEntityTypeConfiguration<TypeSub>
    {
        public void Configure(EntityTypeBuilder<TypeSub> builder)
        {
            builder.ToTable("TypeSub");

            builder.HasKey(t => t.Id_TypeSub);

            builder.Property(t => t.Id_TypeSub)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-incrémentation

            builder.Property(t => t.NameTypeSub)
                .IsRequired()
                .HasMaxLength(100);
                // HasMinLength(3); // le gérer en validation ou migration personnalisée

            builder.Property(t => t.DescriptionTypeSub)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(t => t.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(t => t.StartDate)
                .IsRequired();

            builder.Property(t => t.EndDate)
                .IsRequired();

            // Relation One to Many avec GroupSession
            builder.HasMany(t => t.GroupSessions)
                .WithOne(g => g.TypeSub)
                .HasForeignKey(g => g.Id_TypeSub)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
