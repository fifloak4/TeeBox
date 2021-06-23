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
                    Id = 1,
                    Name = "Sobienie Królewskie G&C"
                }
            );

            modelBuilder.Entity<Hole>().HasData(
                new Hole {
                    Id = 1,
                    Number = 1,
                    CourseId = 1,
                    Hcp = 8,
                    Par = 4
                },
                new Hole
                {
                    Id = 2,
                    Number = 2,
                    CourseId = 1,
                    Hcp = 14,
                    Par = 3
                },
                new Hole
                {
                    Id = 3,
                    Number = 3,
                    CourseId = 1,
                    Hcp = 13,
                    Par = 5
                },
                new Hole
                {
                    Id = 4,
                    Number = 4,
                    CourseId = 1,
                    Hcp = 16,
                    Par = 3
                },
                new Hole
                {
                    Id = 5,
                    Number = 5,
                    CourseId = 1,
                    Hcp = 17,
                    Par = 4
                },
                new Hole
                {
                    Id = 6,
                    Number = 6,
                    CourseId = 1,
                    Hcp = 4,
                    Par = 4
                },
                new Hole
                {
                    Id = 7,
                    Number = 7,
                    CourseId = 1,
                    Hcp = 2,
                    Par = 4
                },
                new Hole
                {
                    Id = 8,
                    Number = 8,
                    CourseId = 1,
                    Hcp = 7,
                    Par = 5
                },
                new Hole
                {
                    Id = 9,
                    Number = 9,
                    CourseId = 1,
                    Hcp = 6,
                    Par = 3
                },
                new Hole
                {
                    Id = 10,
                    Number = 10,
                    CourseId = 1,
                    Hcp = 10,
                    Par = 4
                },
                new Hole
                {
                    Id = 11,
                    Number = 11,
                    CourseId = 1,
                    Hcp = 9,
                    Par = 4
                },
                new Hole
                {
                    Id = 12,
                    Number = 12,
                    CourseId = 1,
                    Hcp = 15,
                    Par = 3
                },
                new Hole
                {
                    Id = 13,
                    Number = 13,
                    CourseId = 1,
                    Hcp = 3,
                    Par = 4
                },
                new Hole
                {
                    Id = 14,
                    Number = 14,
                    CourseId = 1,
                    Hcp = 1,
                    Par = 4
                },
                new Hole
                {
                    Id = 15,
                    Number = 15,
                    CourseId = 1,
                    Hcp = 5,
                    Par = 5
                },
                new Hole
                {
                    Id = 16,
                    Number = 16,
                    CourseId = 1,
                    Hcp = 11,
                    Par = 3
                },
                new Hole
                {
                    Id = 17,
                    Number = 17,
                    CourseId = 1,
                    Hcp = 18,
                    Par = 4
                },
                new Hole
                {
                    Id = 18,
                    Number = 18,
                    CourseId = 1,
                    Hcp = 12,
                    Par = 5
                }
            );
        }
    }
}
