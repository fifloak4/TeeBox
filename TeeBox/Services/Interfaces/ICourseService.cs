using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeeBox.Domain;
using TeeBox.Domain.DTO;
using TeeBox.Domain.Records;

namespace TeeBox.Application.Services.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseDTO>> GetCourseListAsync();
        Task<HoleDTO> GetHoleAsync(int courseId, int holeNumber);
        Task<IEnumerable<HoleDTO>> GetHoleListAsync(int courseId);
    }
}
