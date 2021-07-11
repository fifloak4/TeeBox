using MediatR;
using System.IO;

namespace TeeBox.Application.Commands
{
    public record AddSvgMapCommand(FileInfo SvgFile, int OriginalId, int HoleId) : IRequest<Unit>;
}
