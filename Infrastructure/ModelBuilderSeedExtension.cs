using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeeBox.Domain;

namespace TeeBox.Infrastructure.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course
                {

                }
            );

            modelBuilder.Entity<Hole>().HasData(
                new Hole {  }
            );

            modelBuilder.Entity<User>().HasData(
                new User { }
            );
        }
    }
}
