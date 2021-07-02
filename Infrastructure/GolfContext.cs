using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeeBox.Domain;
using TeeBox.Domain.Models;
using TeeBox.Infrastructure.Extensions;

namespace TeeBox.Infrastructure
{
    public class GolfContext : IdentityDbContext<User>
    {
        public DbSet<Hole> Holes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Tee> Tees { get; set; }
        public DbSet<TeeColor> TeeColors { get; set; }
        public DbSet<OriginalMap> OriginalMaps { get; set; }
        public DbSet<SvgMap> SvgMaps { get; set; }


        public GolfContext(DbContextOptions<GolfContext> options)
                : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}