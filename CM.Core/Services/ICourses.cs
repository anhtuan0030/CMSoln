using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public interface ICourses
    {
        int GetStudentId();
        void SetStudentId(int studentId);
        int GetTeacherId();
        void SetTeacherId(int teacherId);
    }
}