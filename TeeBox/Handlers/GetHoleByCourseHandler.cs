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
using TeeBox.Domain.Records;
using TeeBox.Infrastructure;

namespace TeeBox.Application.Handlers
{
    public class GetHoleByCourseHandler : GolfContextHandler, IRequestHandler<GetHoleByCourseQuery, HoleDTO>
    {
        public GetHoleByCourseHandler(GolfContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<HoleDTO> Handle(GetHoleByCourseQuery request, CancellationToken cancellationToken)
        {
            var hole = await context
                .Holes
                .Where(h => h.CourseId == request.CourseId && h.Id == request.HoleNumber)
                .GroupJoin(context
                    .Tees
                    .Join(context.TeeColors,
                        tee => tee.TeeColorId,
                        teeColor => teeColor.Id,
                        (tee, teeColor) => 
                            mapper.Map<Tee, TeeColor, HoleTeeDTO>(tee, teeColor)),
                    hole => hole.Id,
                    tee => tee.HoleId,
                    (hole, tees) => mapper.MergeInto<HoleDTO>(hole, tees))
                .SingleOrDefaultAsync(cancellationToken);

            var result = hole;

            return result;
        }
    }
}
