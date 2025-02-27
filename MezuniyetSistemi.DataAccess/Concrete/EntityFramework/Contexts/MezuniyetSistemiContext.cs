﻿using MezuniyetSistemi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace MezuniyetSistemi.DataAccess.Concrete.EntityFramework.Contexts
{
    public class MezuniyetSistemiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MezuniyetSistemiDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<Email> Emails { get; set; }
        public DbSet<Specialty> Specialties { get; set; }

    }
}
