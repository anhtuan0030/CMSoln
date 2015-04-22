using Cirrious.MvvmCross.ViewModels;
using CM.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.ViewModels
{
    public class TeacherViewModel : MvxViewModel
    {
        private readonly ITeacherService _teacherService;
        private ITeachers _teacher;

        public TeacherViewModel(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public class Nav
        {
            public int Id { get; set; }
        }

        public void Init(Nav navigation)
        {
            _teacher = _teacherService.GetById(navigation.Id);
        }

    }
}
