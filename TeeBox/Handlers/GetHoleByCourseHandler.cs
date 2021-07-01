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
using TeeBox.Domain.Records;
using TeeBox.Infrastructure;

namespace TeeBox.Application.Handlers
{
    public class GetHoleByCourseHandler : IRequestHandler<GetHoleByCourseQuery, HoleTeesColors>
    {
        readonly GolfContext _context;

        public GetHoleByCourseHandler(GolfContext context)
        {
            _context = context;
        }

        public async Task<HoleTeesColors> Handle(GetHoleByCourseQuery request, CancellationToken cancellationToken)
        {
            var hole = await _context
                .TeeColors
                .Where(c => c.CourseId == request.CourseId)
                .Join(_context.Tees,
                    color => color.Id,
                    tee => tee.TeeColorId,
                    (color, tee) => tee)
                .Join(_context.Holes,
                    tee => tee.HoleId,
                    hole => hole.Id,
                    (tee, hole) => hole)
                .Where(hole => hole.Number == request.HoleNumber)
                .Distinct()
                .SingleAsync(cancellationToken);

            var tees = await _context
                .Tees
                .Where(tee => tee.HoleId == hole.Id)
                .Join(_context.TeeColors, 
                    tee => tee.TeeColorId,
                    teeColor => teeColor.Id,
                    (tee, teeColor) => new TeeColorTee(tee, teeColor))
                .ToListAsync(cancellationToken);

            return new HoleTeesColors(hole, tees);
        }
    }
}
