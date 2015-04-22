using Cirrious.MvvmCross.ViewModels;
using CM.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.ViewModels
{
    public class StudentViewModel : MvxViewModel
    {
        private readonly IStudentService _teacherService;

        public StudentViewModel(IStudentService teacherService)
        {
            _teacherService = teacherService;
        }

        public async void Init(int teacherId)
        {
            var result = await _teacherService.GetById(teacherId);

            Teacher = result;
        }

        private IStudent _teacher;
        public IStudent Teacher
        {
            get { return _teacher; }
            set { _teacher = value; RaisePropertyChanged(() => Teacher); }
        }
    }
}
