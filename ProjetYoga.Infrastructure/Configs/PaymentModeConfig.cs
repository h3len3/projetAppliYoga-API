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
    internal class PaymentModeConfig : IEntityTypeConfiguration<PaymentMode>
    {
        public void Configure(EntityTypeBuilder<PaymentMode> builder)
        {
            builder.ToTable("PaymentModes");

            // Clé primaire avec auto - incrément
            builder.HasKey(pm => pm.Id_PaymentMode);
            builder.Property(pm => pm.Id_PaymentMode)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            builder.Property(pm => pm.Name_PaymentMode)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
