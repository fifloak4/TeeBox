using System.Collections.Generic;
using System.Threading.Tasks;
using TeeBox.Domain.DTO;

namespace TeeBox.Application.Services.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseDTO>> GetCourseListAsync();
        Task<HoleDTO> GetHoleAsync(int courseId, int holeNumber);
        Task<IEnumerable<HoleDTO>> GetHoleListAsync(int courseId);
    }
}
