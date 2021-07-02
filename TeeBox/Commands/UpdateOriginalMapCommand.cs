using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeeBox.Domain.Models;

namespace TeeBox.Application.Commands
{
    public record UpdateOriginalMapCommand(OriginalMap Map) : IRequest<Unit>;
}
