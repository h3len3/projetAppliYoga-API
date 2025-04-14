using Microsoft.EntityFrameworkCore;
using ProjetYoga.Domain.Entities;
using ProjetYoga.Infrastructure.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Infrastructure
{
    public class ProjetYogaContext(DbContextOptions options): DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<TypeSub> TypeSubs { get; set; }
        public DbSet<PlaceEventYoga> PlaceEventYogas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new EventConfig());
            modelBuilder.ApplyConfiguration(new TypeSubConfig());
            modelBuilder.ApplyConfiguration(new PlaceEventYogaConfig());

        }

        
    }
}
