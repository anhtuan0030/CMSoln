using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public interface IStudentService
    {
        Task<IStudent> GetByUserName(string userName, string password);

        Task<IStudent> GetById(int studentId);
    }
}
