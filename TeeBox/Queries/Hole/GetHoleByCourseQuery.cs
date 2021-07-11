using MediatR;
using TeeBox.Domain.DTO;

namespace TeeBox.Application.Queries
{
    public record GetHoleByCourseQuery(int CourseId, int HoleNumber) : IRequest<HoleDTO>;
}
