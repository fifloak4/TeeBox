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
    public class GetHoleListHandler : IRequestHandler<GetHoleListQuery, IEnumerable<Hole>>
    {
        readonly GolfContext _context;

        public GetHoleListHandler(GolfContext context)
        {
            _context = context;
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IEnumerable<Hole>> Handle(GetHoleListQuery request, CancellationToken cancellationToken)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            var response = _context
                .TeeColors
                .Where(c => c.CourseId == request.CourseId)
                .Join(_context.Tees,
                    course => course.Id,
                    tee => tee.TeeColorId,
                    (course, tee) => tee)
                .Join(_context.Holes,
                    tee => tee.HoleId,
                    hole => hole.Id,
                    (tee, hole) => hole)
                 .Distinct()
                 .Select(h => h);

            return response;
        }
    }
}
