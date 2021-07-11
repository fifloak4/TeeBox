using MediatR;

namespace TeeBox.Application.Commands
{
    public record DeleteSvgMapCommand(int MapId) : IRequest<Unit>;
}
