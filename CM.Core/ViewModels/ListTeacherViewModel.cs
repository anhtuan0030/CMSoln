using Cirrious.MvvmCross.ViewModels;
using CM.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.ViewModels
{
    public class ListTeacherViewModel : MvxViewModel
    {
        private string _hello = "Hello ListTeacherViewModel";
        public string Hello
        {
            get { return _hello; }
            set { _hello = value; RaisePropertyChanged(() => Hello); }
        }

        private readonly ITeacherService _teacherService;

        public ListTeacherViewModel(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
       
        public async void Init()
        {
            var result = await _teacherService.GetTeachers();

            ListData = result.ToList();
        }

        private List<ITeachers> _listData;
        public List<ITeachers> ListData
        {
            get { return _listData; }
            set { _listData = value; RaisePropertyChanged(() => ListData); }
        }


        MvxCommand _viewDetailTeacher;
        public System.Windows.Input.ICommand ViewDetailTeacher
        {
            get
            {
                _viewDetailTeacher = _viewDetailTeacher ?? new MvxCommand(DoViewDetailTeacher);
                return _viewDetailTeacher;
            }
        }

        private void DoViewDetailTeacher()
        {
            //TeacherViewModel t = _teacherService.SelectTeacherByKey(1);
            ShowViewModel<TeacherViewModel>();
        }
        
    }
}
