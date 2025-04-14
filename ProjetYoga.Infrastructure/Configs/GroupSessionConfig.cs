using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Infrastructure.Configs
{
    internal class GroupSessionConfig : IEntityTypeConfiguration<GroupSession>
    {
        public void Configure(EntityTypeBuilder<GroupSession> builder)
        {
            builder.ToTable("GroupSession");

            builder.Property(g => g.DaysAndHours)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(g => g.StartDateGroupSession)
                .IsRequired();

            builder.Property(g => g.EndDateGroupSession)
                .IsRequired();

            builder.Property(g => g.Id_TypeSub)
                .IsRequired();

            // Relation vers TypeSub
           // builder.HasOne(g => g.TypeSub)
                //.WithMany(t => t.GroupSessions)
               // .HasForeignKey(g => g.Id_TypeSub)
               // .OnDelete(DeleteBehavior.Cascade);  // ou autre ;à voir plus tard
        }
    }
}
