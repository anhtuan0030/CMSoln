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
            ShowViewModel<StudentViewModel>(new { studentId = 1 });
        }


        private string _userName;
        public string UserName
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


        MvxCommand _loginCommand;
        public System.Windows.Input.ICommand LoginCommand
        {
            get
            {
                _loginCommand = _loginCommand ?? new MvxCommand(DoLoginCommand);
                return _loginCommand;
            }
        }

        private void DoLoginCommand()
        {
            
        }

        
    }
}
