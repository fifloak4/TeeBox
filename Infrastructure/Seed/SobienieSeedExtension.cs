using Microsoft.EntityFrameworkCore;
using TeeBox.Domain;
using TeeBox.Domain.Enum;

namespace TeeBox.Infrastructure.Seed
{
    public static class SobienieSeedExtension
    {
        public static void SeedSobienie(this ModelBuilder modelBuilder)
        {
            //Add Course
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Name = "Sobienie Królewskie G&C"
                }
            );

            //Add Holes
            modelBuilder.Entity<Hole>().HasData(
                new Hole
                {
                    Id = 1,
                    Number = 1,
                    Hcp = 8,
                    Par = 4,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 2,
                    Number = 2,
                    Hcp = 14,
                    Par = 3,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 3,
                    Number = 3,
                    Hcp = 13,
                    Par = 5,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 4,
                    Number = 4,
                    Hcp = 16,
                    Par = 3,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 5,
                    Number = 5,
                    Hcp = 17,
                    Par = 4,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 6,
                    Number = 6,
                    Hcp = 4,
                    Par = 4,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 7,
                    Number = 7,
                    Hcp = 2,
                    Par = 4,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 8,
                    Number = 8,
                    Hcp = 7,
                    Par = 5,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 9,
                    Number = 9,
                    Hcp = 6,
                    Par = 3,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 10,
                    Number = 10,
                    Hcp = 10,
                    Par = 4,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 11,
                    Number = 11,
                    Hcp = 9,
                    Par = 4,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 12,
                    Number = 12,
                    Hcp = 15,
                    Par = 3,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 13,
                    Number = 13,
                    Hcp = 3,
                    Par = 4,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 14,
                    Number = 14,
                    Hcp = 1,
                    Par = 4,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 15,
                    Number = 15,
                    Hcp = 5,
                    Par = 5,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 16,
                    Number = 16,
                    Hcp = 11,
                    Par = 3,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 17,
                    Number = 17,
                    Hcp = 18,
                    Par = 4,
                    CourseId = 1
                },
                new Hole
                {
                    Id = 18,
                    Number = 18,
                    Hcp = 12,
                    Par = 5,
                    CourseId = 1
                }
            );

            //Add TeeColors
            modelBuilder.Entity<TeeColor>().HasData(
                new TeeColor
                {
                    Id = 1,
                    Color = TeeColors.White,
                    CourseId = 1,
                },
                new TeeColor
                {
                    Id = 2,
                    Color = TeeColors.Yellow,
                    CourseId = 1
                },
               new TeeColor
               {
                   Id = 3,
                   Color = TeeColors.Blue,
                   CourseId = 1
               },
               new TeeColor
               {
                   Id = 4,
                   Color = TeeColors.Red,
                   CourseId = 1
               }
           );

            //Add Tee
            modelBuilder.Entity<Tee>().HasData(
               //Hole 1
               new Tee
               {
                   Id = 1,
                   Distance = 356,
                   HoleId = 1,
                   TeeColorId = 1,
               },
               new Tee
               {
                   Id = 2,
                   Distance = 333,
                   HoleId = 1,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 3,
                   Distance = 312,
                   HoleId = 1,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 4,
                   Distance = 293,
                   HoleId = 1,
                   TeeColorId = 4
               },
               //Hole 2
               new Tee
               {
                   Id = 5,
                   Distance = 138,
                   HoleId = 2,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 6,
                   Distance = 131,
                   HoleId = 2,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 7,
                   Distance = 129,
                   HoleId = 2,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 8,
                   Distance = 119,
                   HoleId = 2,
                   TeeColorId = 4
               },
               //Hole 3
               new Tee
               {
                   Id = 9,
                   Distance = 460,
                   HoleId = 3,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 10,
                   Distance = 453,
                   HoleId = 3,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 11,
                   Distance = 434,
                   HoleId = 3,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 12,
                   Distance = 398,
                   HoleId = 3,
                   TeeColorId = 4
               },
               //Hole 4
               new Tee
               {
                   Id = 13,
                   Distance = 183,
                   HoleId = 4,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 14,
                   Distance = 171,
                   HoleId = 4,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 15,
                   Distance = 160,
                   HoleId = 4,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 16,
                   Distance = 101,
                   HoleId = 4,
                   TeeColorId = 4
               },
               //Hole 5
               new Tee
               {
                   Id = 17,
                   Distance = 313,
                   HoleId = 5,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 18,
                   Distance = 304,
                   HoleId = 5,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 19,
                   Distance = 289,
                   HoleId = 5,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 20,
                   Distance = 275,
                   HoleId = 5,
                   TeeColorId = 4
               },
               //Hole 6
               new Tee
               {
                   Id = 21,
                   Distance = 316,
                   HoleId = 6,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 22,
                   Distance = 294,
                   HoleId = 6,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 23,
                   Distance = 255,
                   HoleId = 6,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 24,
                   Distance = 247,
                   HoleId = 6,
                   TeeColorId = 4
               },
               //Hole 7
               new Tee
               {
                   Id = 25,
                   Distance = 433,
                   HoleId = 7,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 26,
                   Distance = 414,
                   HoleId = 7,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 27,
                   Distance = 387,
                   HoleId = 7,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 28,
                   Distance = 347,
                   HoleId = 7,
                   TeeColorId = 4
               },
               //Hole 8
               new Tee
               {
                   Id = 29,
                   Distance = 496,
                   HoleId = 8,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 30,
                   Distance = 473,
                   HoleId = 8,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 31,
                   Distance = 440,
                   HoleId = 8,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 32,
                   Distance = 398,
                   HoleId = 8,
                   TeeColorId = 4
               },
               //Hole 9
               new Tee
               {
                   Id = 33,
                   Distance = 165,
                   HoleId = 9,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 34,
                   Distance = 156,
                   HoleId = 9,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 35,
                   Distance = 145,
                   HoleId = 9,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 36,
                   Distance = 134,
                   HoleId = 9,
                   TeeColorId = 4
               },
               //Hole 10
               new Tee
               {
                   Id = 37,
                   Distance = 371,
                   HoleId = 10,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 38,
                   Distance = 350,
                   HoleId = 10,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 39,
                   Distance = 327,
                   HoleId = 10,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 40,
                   Distance = 278,
                   HoleId = 10,
                   TeeColorId = 4
               },
               //Hole 11
               new Tee
               {
                   Id = 41,
                   Distance = 368,
                   HoleId = 11,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 42,
                   Distance = 347,
                   HoleId = 11,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 43,
                   Distance = 324,
                   HoleId = 11,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 44,
                   Distance = 305,
                   HoleId = 11,
                   TeeColorId = 4
               },
               //Hole 12
               new Tee
               {
                   Id = 45,
                   Distance = 174,
                   HoleId = 12,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 46,
                   Distance = 161,
                   HoleId = 12,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 47,
                   Distance = 150,
                   HoleId = 12,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 48,
                   Distance = 142,
                   HoleId = 12,
                   TeeColorId = 4
               },
               //Hole 13
               new Tee
               {
                   Id = 49,
                   Distance = 349,
                   HoleId = 13,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 50,
                   Distance = 337,
                   HoleId = 13,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 51,
                   Distance = 333,
                   HoleId = 13,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 52,
                   Distance = 331,
                   HoleId = 13,
                   TeeColorId = 4
               },
               //Hole 14
               new Tee
               {
                   Id = 53,
                   Distance = 418,
                   HoleId = 14,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 54,
                   Distance = 408,
                   HoleId = 14,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 55,
                   Distance = 382,
                   HoleId = 14,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 56,
                   Distance = 351,
                   HoleId = 14,
                   TeeColorId = 4
               },
               //Hole 15
               new Tee
               {
                   Id = 57,
                   Distance = 522,
                   HoleId = 15,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 58,
                   Distance = 495,
                   HoleId = 15,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 59,
                   Distance = 458,
                   HoleId = 15,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 60,
                   Distance = 416,
                   HoleId = 15,
                   TeeColorId = 4
               },
               //Hole 16
               new Tee
               {
                   Id = 61,
                   Distance = 178,
                   HoleId = 16,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 62,
                   Distance = 168,
                   HoleId = 16,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 63,
                   Distance = 136,
                   HoleId = 16,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 64,
                   Distance = 108,
                   HoleId = 16,
                   TeeColorId = 4
               },
               //Hole 17
               new Tee
               {
                   Id = 65,
                   Distance = 304,
                   HoleId = 17,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 66,
                   Distance = 276,
                   HoleId = 17,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 67,
                   Distance = 260,
                   HoleId = 17,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 68,
                   Distance = 240,
                   HoleId = 17,
                   TeeColorId = 4
               },
               //Hole 18
               new Tee
               {
                   Id = 69,
                   Distance = 481,
                   HoleId = 18,
                   TeeColorId = 1
               },
               new Tee
               {
                   Id = 70,
                   Distance = 460,
                   HoleId = 18,
                   TeeColorId = 2
               },
               new Tee
               {
                   Id = 71,
                   Distance = 446,
                   HoleId = 18,
                   TeeColorId = 3
               },
               new Tee
               {
                   Id = 72,
                   Distance = 379,
                   HoleId = 18,
                   TeeColorId = 4
               }
           );
        }
    }
}
