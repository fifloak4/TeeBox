using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TeeBox.Application.Commands;
using TeeBox.Application.Handlers.Interfaces;
using TeeBox.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TeeBox.Domain.Models;

namespace TeeBox.Application.Handlers
{
    public class AddSvgMapHandler : GolfContextHandler, IRequestHandler<AddSvgMapCommand, Unit>
    {

        public AddSvgMapHandler(GolfContext context, IMapper mapper) : base(context, mapper) { }


        public async Task<Unit> Handle(AddSvgMapCommand request, CancellationToken cancellationToken)
        {
            if (request.SvgFile.Exists)
            {
                await context
                .OriginalMaps
                .Where(m => m.Id == request.OriginalId)
                .SingleAsync(cancellationToken);

                await context.AddAsync(new SvgMap()
                {
                    File = request.SvgFile.Name,
                    HoleId = request.HoleId,
                    OriginalId = request.OriginalId
                }, cancellationToken);

                await context.SaveChangesAsync(cancellationToken);
            }
            else
                throw new ArgumentException($"SVG File: {request.SvgFile.FullName} doesn't exist.");

            return new Unit();
        }
    }
}
