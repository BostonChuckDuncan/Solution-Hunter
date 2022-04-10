using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Ghost> Ghosts { get; set; }
        public DbSet<Population> Populations { get; set; }
        public DbSet<Individual> Individuals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasOne( p => p.ProjectOwner )
                .WithMany( p => p.Projects );

            modelBuilder.Entity<Ghost>()
                .HasOne( p => p.parentProject )
                .WithMany( p => p.Ghosts );

            modelBuilder.Entity<Individual>()
                .HasOne( p => p.OwnerPopulation )
                .WithMany( p => p.Individuals );
        }
    }
}