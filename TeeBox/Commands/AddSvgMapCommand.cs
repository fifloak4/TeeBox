using MediatR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeeBox.Application.Commands
{
    public record AddSvgMapCommand(FileInfo SvgFile, int OriginalId) : IRequest<Unit>;
}
