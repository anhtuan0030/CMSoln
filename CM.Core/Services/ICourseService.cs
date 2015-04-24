using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public interface ICourseService
    {
        Task<IEnumerable<ICourses>> GetCourses(int studentId);
        void RegisterCourses(int teacherId, int studentId);
    }
}
