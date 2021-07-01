using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeeBox.Domain;

namespace TeeBox.Application.Queries
{
    public record GetHoleQuery(int HoleId) : IRequest<Hole>;


}
