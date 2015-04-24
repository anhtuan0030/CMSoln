using Cirrious.MvvmCross.ViewModels;
using CM.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private readonly IStudentService _studentService;

        public LoginViewModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void Init()
        {
            //Checked if already login -> go to account info else show login from
            //Session.Dictionary.Add("StudentId", 1);
            //ShowViewModel<StudentViewModel>(new { studentId = Session.Dictionary["StudentId"] });
        }


        private string _userName;
        public string Username
        {
            get { return _userName; }
            set { _userName = value; RaisePropertyChanged("Username"); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; RaisePropertyChanged("Password"); }
        }

        private string _message = string.Empty;
        public string Message
        {
            get { return _message; }
            set { _message = value; RaisePropertyChanged(() => Message); }
        }


        MvxCommand _loginCommand;
        public System.Windows.Input.ICommand LoginCommand
        {
            get
            {
                _loginCommand = _loginCommand ?? new MvxCommand(DoLoginCommand);
                return _loginCommand;
            }
        }

        private async void DoLoginCommand()
        {
            var result = await _studentService.GetByUserName(Username, Password);
            if (result != null)
            {
                Session.Dictionary["CurrentUser"] = _userName;
                Session.Dictionary["StudentId"] = result.GetStudentId();
                ShowViewModel<ListTeacherViewModel>();
            }
            else
            {
                Message = "Đăng nhập không thành công!";
                ShowViewModel<LoginViewModel>();
            }
        }
    }
}
