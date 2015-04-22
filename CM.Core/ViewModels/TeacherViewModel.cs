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

        public TeacherViewModel(ITeacherService teacherService)
        {
            _teacherService = teacherService;
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
