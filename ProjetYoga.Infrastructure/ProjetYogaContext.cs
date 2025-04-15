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
        public DbSet<Adept> Adepts { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<GroupSession> GroupSessions { get; set; }
        public DbSet<IndividualSession> IndividualSessions { get; set; }
        public DbSet<SpecialEvent> SpecialEvents { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User_TypeSub> User_TypeSubs { get; set; }
        public DbSet<PaymentMode> PaymentModes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new EventConfig());
            modelBuilder.ApplyConfiguration(new TypeSubConfig());
            modelBuilder.ApplyConfiguration(new PlaceEventYogaConfig());
            modelBuilder.ApplyConfiguration(new AdeptConfig());
            modelBuilder.ApplyConfiguration(new InstructorConfig());
            modelBuilder.ApplyConfiguration(new GroupSessionConfig());
            modelBuilder.ApplyConfiguration(new IndividualSessionConfig());
            modelBuilder.ApplyConfiguration(new SpecialEventConfig());
            modelBuilder.ApplyConfiguration(new AddressConfig());
            modelBuilder.ApplyConfiguration(new ReservationConfig());
            modelBuilder.ApplyConfiguration(new User_TypeSubConfig());
            modelBuilder.ApplyConfiguration(new PaymentModeConfig());
        }

    }
}
