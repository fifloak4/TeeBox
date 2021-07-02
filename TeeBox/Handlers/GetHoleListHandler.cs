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
    public class GetHoleListHandler : GolfContextHandler, IRequestHandler<GetHoleListQuery, IEnumerable<HoleDTO>>
    {
        public GetHoleListHandler(GolfContext context, IMapper mapper) : base(context, mapper) { }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IEnumerable<HoleDTO>> Handle(GetHoleListQuery request, CancellationToken cancellationToken)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            /*var tees = context.Tees.Join(context.
                            TeeColors
                            .Where(t => t.CourseId == request.CourseId),
                        tee => tee.TeeColorId,
                        teeColor => teeColor.Id,
                        (tee, teeColor) => mapper.Map<Tee, TeeColor, HoleTeeDTO>(tee, teeColor));

            var list1 = await tees.ToListAsync();
            */
            var tees = context.Tees.Join(context.
                            TeeColors
                            .Where(t => t.CourseId == request.CourseId),
                        tee => tee.TeeColorId,
                        teeColor => teeColor.Id,
                        (tee, teeColor) => mapper.Map<Tee, TeeColor, HoleTeeDTO>(tee, teeColor));

            var list1 = await tees.ToListAsync();

            var holes = context
                .Holes
                .Where(h => h.CourseId == request.CourseId);



            var list2 = await holes.ToListAsync();

            return null;
        }
    }
}
