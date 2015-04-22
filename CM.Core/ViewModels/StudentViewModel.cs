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
       

        private string _hello = "Hello Student View";
        public string Hello
        {
            get { return _hello; }
            set { _hello = value; RaisePropertyChanged(() => Hello); }
        }
        

    }
}
