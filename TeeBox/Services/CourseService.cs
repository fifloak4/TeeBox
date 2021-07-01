using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeeBox.Application.Queries;
using TeeBox.Application.Services.Interfaces;
using TeeBox.Domain;
using TeeBox.Domain.Records;

namespace TeeBox.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly IMediator _mediator;

        public CourseService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IEnumerable<Hole>> GetHoleListAsync(int courseId)
        {
            return await _mediator.Send(new GetHoleListQuery(courseId));
        }

        public async Task<IEnumerable<Course>> GetCourseListAsync()
        {
            return await _mediator.Send(new GetCourseListQuery());
        }

        public async Task<HoleTeesColors> GetHoleAsync(int courseId, int holeNumber)
        {
            return await _mediator.Send(new GetHoleByCourseQuery(courseId, holeNumber));
        }

        public async Task<Hole> GetHoleAsync(int holeId)
        {
            return await _mediator.Send(new GetHoleQuery(holeId));
        }
    }
}
