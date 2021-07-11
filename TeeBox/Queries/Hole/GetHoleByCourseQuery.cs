using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeeBox.Domain;
using TeeBox.Domain.DTO;
using TeeBox.Domain.Records;

namespace TeeBox.Application.Queries
{
    public record GetHoleByCourseQuery(int CourseId, int HoleNumber) : IRequest<HoleDTO>;
}
