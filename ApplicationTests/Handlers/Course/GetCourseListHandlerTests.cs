using NUnit.Framework;
using TeeBox.Application.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeeBox.Domain;
using Moq;
using Microsoft.EntityFrameworkCore;
using TeeBox.Infrastructure;
using AutoMapper;
using System.Threading;
using TeeBox.Domain.DTO;

namespace TeeBox.Application.Handlers.Tests
{
    [TestFixture()]
    public class GetCourseListHandlerTests
    {
        public IMapper Mapper { get; set; }

        [SetUp()]
        public void SetUp() 
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.AddProfile<MappingProfile>();
            });

            Mapper = config.CreateMapper();
        }

        [Test()]
        public async Task HandleTestAsync()
        {
            var options = new DbContextOptionsBuilder<GolfContext>()
                .UseInMemoryDatabase(databaseName: "Golf Test")
                .Options;

            using (var context = new GolfContext(options))
            {
                context.Courses.Add(new Course { Id = 1, Name = "ABCD Course" });
                context.Courses.Add(new Course { Id = 2, Name = "EFGH Course" });
                context.SaveChanges();
            }

            using (var context = new GolfContext(options))
            {
                var cts = new CancellationTokenSource();
                cts.CancelAfter(TimeSpan.FromSeconds(1));

                GetCourseListHandler handler = new(context, Mapper);

                List<CourseDTO> courses = 
                    (await handler.Handle(new Queries.GetCourseListQuery(), cts.Token))
                    .ToList();

                Assert.AreEqual(2, courses.Count);

                Assert.AreEqual("ABCD Course", courses[0].Name);
                Assert.AreEqual("EFGH Course", courses[1].Name);
            }
        }


    }
}