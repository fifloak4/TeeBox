using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TeeBox.Application.Handlers.Interfaces;
using TeeBox.Application.Queries;
using TeeBox.Domain;
using TeeBox.Domain.DTO;
using TeeBox.Infrastructure;

namespace TeeBox.Application.Handlers
{
    public class GetCourseListHandler :
        GolfContextHandler,
        IRequestHandler<GetCourseListQuery, IEnumerable<CourseDTO>>
    {

        public GetCourseListHandler(GolfContext context,
                                    IMapper mapper) : base(context, mapper) { }

        public async Task<IEnumerable<CourseDTO>> Handle
            (GetCourseListQuery request,
            CancellationToken cancellationToken)
        {
            var response = context.
                Courses.Select(c => c);

            return mapper.Map<IEnumerable<Course>, IEnumerable<CourseDTO>>(response);
        }
    }
}
