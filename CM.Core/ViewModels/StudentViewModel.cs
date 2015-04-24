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
        private readonly IStudentService _studentService;

        public StudentViewModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public async void Init()
        {
            int studentId = int.Parse(Session.Dictionary["StudentId"].ToString());
            var result = await _studentService.GetById(studentId);
            Student = result;
        }

        private IStudents _student;
        public IStudents Student
        {
            get { return _student; }
            set { _student = value; RaisePropertyChanged(() => Student); }
        }
    }
}
