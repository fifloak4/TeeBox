using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeeBox.Domain;
using TeeBox.Domain.DTO;

namespace TeeBox.Application.Queries
{
    public record GetCourseListQuery() : IRequest<IEnumerable<CourseDTO>>;
}
