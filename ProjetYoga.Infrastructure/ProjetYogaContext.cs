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
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EventConfig());
        }
    }
}
