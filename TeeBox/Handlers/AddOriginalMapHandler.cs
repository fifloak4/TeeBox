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
    public class AddOriginalMapHandler : GolfContextHandler, IRequestHandler<AddOriginalMapCommand, Unit>
    {

        public AddOriginalMapHandler(GolfContext context, IMapper mapper) : base(context, mapper) { }


        public async Task<Unit> Handle(AddOriginalMapCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException(); 
        }
    }
}
