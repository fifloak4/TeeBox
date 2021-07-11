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
    public class GetHoleByCourseHandler : GolfContextHandler, IRequestHandler<GetHoleByCourseQuery, HoleDTO>
    {
        public GetHoleByCourseHandler(GolfContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<HoleDTO> Handle(GetHoleByCourseQuery request, CancellationToken cancellationToken)
        {

            var tee = context.Tees.Where(t => t.HoleId == request.HoleNumber).Join(context.
                            TeeColors
                            .Where(t => t.CourseId == request.CourseId),
                        tee => tee.TeeColorId,
                        teeColor => teeColor.Id,
                        (tee, teeColor) => mapper.Map<Tee, TeeColor, HoleTeeDTO>(tee, teeColor));

            var hole = await context
                .Holes
                .Where(h => h.CourseId == request.CourseId && h.Number == request.HoleNumber)
                .SingleOrDefaultAsync(cancellationToken);

            var result = mapper.MergeInto<HoleDTO>(hole, tee);

            return result;
        }
    }
}
