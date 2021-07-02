using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeeBox.Domain.Models;

namespace TeeBox.Application.Queries
{
    public record GetCurrentSvgMapQuery(int HoleId) : IRequest<SvgMap>;
}
