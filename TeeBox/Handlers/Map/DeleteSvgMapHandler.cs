using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TeeBox.Application.Commands;
using TeeBox.Application.Handlers.Interfaces;
using TeeBox.Infrastructure;

namespace TeeBox.Application.Handlers
{
    public class DeleteSvgMapHandler : GolfContextHandler, IRequestHandler<DeleteSvgMapCommand, Unit>
    {

        public DeleteSvgMapHandler(GolfContext context, IMapper mapper) : base(context, mapper) { }


        public async Task<Unit> Handle(DeleteSvgMapCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
