using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IEnumerable<CourseDTO>> Handle
            (GetCourseListQuery request, 
            CancellationToken cancellationToken)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            var response = context.
                Courses.Select(c => c);

            return mapper.Map<IEnumerable<Course>, IEnumerable<CourseDTO>>(response);
        }
    }
}
