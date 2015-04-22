using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public interface ITeachers 
    {
        int GetTeacherId();
        void SetTeacherId(int teacherId);
    }
}