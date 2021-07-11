using MediatR;
using System.Collections.Generic;
using TeeBox.Domain.DTO;

namespace TeeBox.Application.Queries
{
    public record GetCourseListQuery() : IRequest<IEnumerable<CourseDTO>>;
}
