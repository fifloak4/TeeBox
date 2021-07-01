using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TeeBox.Application.Queries;
using TeeBox.Domain;
using TeeBox.Infrastructure;

namespace TeeBox.Application.Handlers
{
    public class GetCourseListHandler : IRequestHandler<GetCourseListQuery, IEnumerable<Course>>
    {
        readonly GolfContext _context;

        public GetCourseListHandler(GolfContext context)
        {
            _context = context;
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IEnumerable<Course>> Handle(GetCourseListQuery request, CancellationToken cancellationToken)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            var response = _context.
                Courses.Select(c => c);
            return response;
        }
    }
}
