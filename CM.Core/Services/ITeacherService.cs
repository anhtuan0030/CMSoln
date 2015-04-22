using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public interface ITeacherService
    {
        Task<IEnumerable<ITeachers>> GetTeachers();
        Task<ITeachers> GetById(int teacherId);
    }
}
