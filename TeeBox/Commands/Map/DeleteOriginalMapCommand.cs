using MediatR;
using TeeBox.Domain.Models;

namespace TeeBox.Application.Commands
{
    public record DeleteOriginalMapCommand(OriginalMap Map) : IRequest<Unit>;
}
