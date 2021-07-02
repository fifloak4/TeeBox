using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TeeBox.Application.Commands;
using TeeBox.Application.Handlers.Interfaces;
using TeeBox.Infrastructure;

namespace TeeBox.Application.Handlers
{
    public class DeleteOriginalMapHandler : GolfContextHandler, IRequestHandler<DeleteOriginalMapCommand, Unit>
    {

        public DeleteOriginalMapHandler(GolfContext context, IMapper mapper) : base(context, mapper) { }


        public async Task<Unit> Handle(DeleteOriginalMapCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
