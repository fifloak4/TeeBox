using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeeBox.Domain;
using TeeBox.Domain.Records;

namespace TeeBox.Application.Services.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetCourseListAsync();
        Task<HoleTeesColors> GetHoleAsync(int courseId, int holeNumber);
        Task<Hole> GetHoleAsync(int holeId);
        Task<IEnumerable<Hole>> GetHoleListAsync(int courseId);
    }
}
