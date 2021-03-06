﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public interface IStudentService
    {
        Task<IStudents> GetByUserName(string userName, string password);

        Task<IStudents> GetById(int studentId);
    }
}
