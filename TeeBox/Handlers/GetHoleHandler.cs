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
    public class GetHoleHandler : IRequestHandler<GetHoleQuery, Hole>
    {
        readonly GolfContext _context;

        public GetHoleHandler(GolfContext context)
        {
            _context = context;
        }

        public async Task<Hole> Handle(GetHoleQuery request, CancellationToken cancellationToken)
        {
            var response = await _context.
                Holes.
                Where(h => h.Id == request.HoleId).
                SingleAsync(cancellationToken);

            return response;
        }
    }
}
