using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCAssignment.Models
{
    public class ProfileContext:DbContext
        {
            public ProfileContext() : base()
            {

            }
            public ProfileContext(DbContextOptions options) : base(options)
            {
            }
            public DbSet<Profile> profiles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>().HasData(
                new Profile() { Id = 1, Name = "Hari", Age = 20, Qualification = "B.E CSE", IsEmployed = true, NoticePeriod = 60, CurrentCtc = 300000 });

        }
    }
    }