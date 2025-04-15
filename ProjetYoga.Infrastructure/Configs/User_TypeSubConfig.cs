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
    internal class User_TypeSubConfig : IEntityTypeConfiguration<User_TypeSub>
    {
        public void Configure(EntityTypeBuilder<User_TypeSub> builder)
        {
            builder.ToTable("User_TypeSub");

            builder.HasKey(uts => new { uts.Id_User, uts.Id_TypeSub });

            builder.Property(uts => uts.DateSub)
                .IsRequired();

            builder.Property(uts => uts.PaymentMode)
                .IsRequired();

            builder.Property(uts => uts.Payed)
                .IsRequired();

            builder.HasOne(uts => uts.User)
                .WithMany(u => u.User_TypeSubs)
                .HasForeignKey(uts => uts.Id_User);

            builder.HasOne(uts => uts.TypeSub)
                .WithMany(ts => ts.User_TypeSubs)
                .HasForeignKey(uts => uts.Id_TypeSub);
        }
    }
}
