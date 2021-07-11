using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
    public class GetHoleListHandler : GolfContextHandler, IRequestHandler<GetHoleListQuery, IEnumerable<HoleDTO>>
    {
        public GetHoleListHandler(GolfContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<IEnumerable<HoleDTO>> Handle(GetHoleListQuery request, CancellationToken cancellationToken)
        {
            var tees = (await context.Tees.Join(context.
                            TeeColors
                            .Where(t => t.CourseId == request.CourseId),
                        tee => tee.TeeColorId,
                        teeColor => teeColor.Id,
                        (tee, teeColor) => mapper.Map<Tee, TeeColor, HoleTeeDTO>(tee, teeColor))
                        .ToListAsync()) //Just EF Core things...
                        .GroupBy(t => t.HoleId)
                        .ToDictionary(a => a.Key, a => a.ToList());

            var holes = context
                        .Holes
                        .Where(h => h.CourseId == request.CourseId);

            var result = new List<HoleDTO>();

            foreach (var hole in holes)
                result.Add(mapper.MergeInto<HoleDTO>(hole, tees[hole.Number]));

            return result;
        }
    }
}
