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
    internal class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            // Configuration de la table Instructor
            builder.ToTable("Instructor"); 

            // La clé primaire est héritée de la classe User, donc pas besoin de la redéfinir ici.

            // Configuration de la propriété Nickname
            builder.Property(i => i.Nickname)
                   .IsRequired()                // Non nullable
                   .HasMaxLength(50)            // Taille maximale
                   .HasDefaultValue("Instructor");  // Valeur par défaut "Instructor"
        }
    }
}
