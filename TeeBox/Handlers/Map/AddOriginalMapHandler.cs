using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TeeBox.Application.Commands;
using TeeBox.Application.Handlers.Interfaces;
using TeeBox.Domain.Models;
using TeeBox.Infrastructure;

namespace TeeBox.Application.Handlers
{
    public class AddOriginalMapHandler : GolfContextHandler, IRequestHandler<AddOriginalMapCommand, Unit>
    {

        public AddOriginalMapHandler(GolfContext context, IMapper mapper) : base(context, mapper) { }


        public async Task<Unit> Handle(AddOriginalMapCommand request, CancellationToken cancellationToken)
        {
            if(request.OriginalFile.Exists)
            {
                var latestMap =  await context
                    .OriginalMaps
                    .Where(m => 
                    m.HoleId == request.HoleId && 
                    m.NextId == null)
                    .SingleOrDefaultAsync(cancellationToken);

                var newMap = context.Add(new OriginalMap()
                {
                    File = request.OriginalFile.Name,
                    HoleId = request.HoleId,
                    NextId = null,
                    PreviousId = latestMap?.Id
                });

                if(latestMap != null)
                    latestMap.NextId = newMap.Entity.Id;

                await context.SaveChangesAsync(cancellationToken);
            }
            return new Unit();
        }
    }
}
