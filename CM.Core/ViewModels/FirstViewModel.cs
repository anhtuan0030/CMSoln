using Cirrious.MvvmCross.ViewModels;

namespace CM.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {

        private string _hello = "Hello FirstViewModel";
        public string Hello
        {
            get { return _hello; }
            set { _hello = value; RaisePropertyChanged(() => Hello); }
        }


        MvxCommand _viewStudent;
        public System.Windows.Input.ICommand ViewStudent
        {
            get
            {
                _viewStudent = _viewStudent ?? new MvxCommand(DoViewStudent);
                return _viewStudent;
            }
        }

        private void DoViewStudent()
        {
            //ShowViewModel<StudentViewModel>();   
        }


        MvxCommand _viewTeacher;
        public System.Windows.Input.ICommand ViewTeacher
        {
            get
            {
                _viewTeacher = _viewTeacher ?? new MvxCommand(DoViewTeacher);
                return _viewTeacher;
            }
        }

        private void DoViewTeacher()
        {
            ShowViewModel<ListTeacherViewModel>();
        }


        MvxCommand _viewCourse;
        public System.Windows.Input.ICommand ViewCourse
        {
            get
            {
                _viewCourse = _viewCourse ?? new MvxCommand(DoViewCourse);
                return _viewCourse;
            }
        }

        private void DoViewCourse()
        {
            //ShowViewModel<CourseViewModel>();
        }

    }
}
