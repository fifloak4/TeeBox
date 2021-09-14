using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
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
            if (request.OriginalFile.Exists)
            {
                await context.AddAsync(new OriginalMap()
                {
                    File = request.OriginalFile.Name,
                    HoleId = request.HoleId,
                }, cancellationToken);

                await context.SaveChangesAsync(cancellationToken);
            }
            else
                throw new ArgumentException($"Original SVG file: {request.OriginalFile.FullName} doesn't exist.");

            return new Unit();
        }
    }
}
