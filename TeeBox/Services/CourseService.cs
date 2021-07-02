using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeeBox.Application.Queries;
using TeeBox.Application.Services.Interfaces;
using TeeBox.Domain;
using TeeBox.Domain.DTO;
using TeeBox.Domain.Records;

namespace TeeBox.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly IMediator mediator;

        public CourseService(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IEnumerable<HoleDTO>> GetHoleListAsync(int courseId)
        {
            return await mediator.Send(new GetHoleListQuery(courseId));
        }

        public async Task<IEnumerable<CourseDTO>> GetCourseListAsync()
        {
            return await mediator.Send(new GetCourseListQuery());
        }

        public async Task<HoleDTO> GetHoleAsync(int courseId, int holeNumber)
        {
            return await mediator.Send(new GetHoleByCourseQuery(courseId, holeNumber));
        }
    }
}
