using MediatR;
using TeeBox.Domain.Models;

namespace TeeBox.Application.Queries
{
    public record GetCurrentSvgMapQuery(int HoleId) : IRequest<SvgMap>;
}
