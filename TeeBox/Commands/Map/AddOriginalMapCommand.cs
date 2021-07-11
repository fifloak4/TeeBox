using MediatR;
using System.IO;

namespace TeeBox.Application.Commands
{
    public record AddOriginalMapCommand(FileInfo OriginalFile, int HoleId) : IRequest<Unit>;
}
