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
        private readonly ICourseService _courseService;

        public TeacherViewModel(ITeacherService teacherService, ICourseService courseService)
        {
            _teacherService = teacherService;
            _courseService = courseService;
        }

        public async void Init(int teacherId)
        {
            var result = await _teacherService.GetById(teacherId);

            Teacher = result;
        }

        private ITeachers _teacher;
        public ITeachers Teacher
        {
            get { return _teacher; }
            set { _teacher = value; RaisePropertyChanged(() => Teacher); }
        }


        MvxCommand _registerCourse;
        public System.Windows.Input.ICommand RegisterCourse
        {
            get
            {
                _registerCourse = _registerCourse ?? new MvxCommand(DoRegisterCourse);
                return _registerCourse;
            }
        }

        private void DoRegisterCourse()
        {
            var teacherId = Teacher.GetTeacherId();
            var studentId = int.Parse(Session.Dictionary["StudentId"].ToString());
            _courseService.RegisterCourses(teacherId, studentId);

            ShowViewModel<CourseViewModel>();
        }


        //private readonly ITeacherService _collectionService;
        //private ITeachers _item;

        //public TeacherViewModel(ITeacherService collectionService)
        //{
        //    _collectionService = collectionService;
        //}

        //public class Nav
        //{
        //    public int Id { get; set; }
        //}

        //public void Init(Nav navigation)
        //{
        //    Item = (ITeachers)_collectionService.GetById(navigation.Id);
        //}

        //public ITeachers Item
        //{
        //    get { return _item; }
        //    set { _item = value; RaisePropertyChanged(() => Item); }
        //}

    }
}
