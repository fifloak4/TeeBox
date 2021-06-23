using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeeBox.Domain;
using TeeBox.Infrastructure.Extensions;

namespace TeeBox.Infrastructure
{
    public class GolfContext : IdentityDbContext<User>
    {
        public DbSet<Hole> Holes { get; set; }
        public DbSet<Course> Courses { get; set; }

        public GolfContext(DbContextOptions<GolfContext> options)
                : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

    }
}