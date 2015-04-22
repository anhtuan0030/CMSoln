using Parse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    [ParseClassName("Teachers")]
    public class Teachers : ParseObject, ITeachers
    {
        [ParseFieldName("TeacherId")]
        public int TeacherId
        {
            get { return GetProperty<int>(); }
            set { SetProperty<int>(value); }
        }

        [ParseFieldName("Fullname")]
        public string Fullname
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("Username")]
        public string Username
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("Password")]
        public string Password
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("Subject")]
        public string Subject
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("Description")]
        public string Description
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("Email")]
        public string Email
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("PhoneNumber")]
        public string PhoneNumber
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("ImagePath")]
        public string ImagePath
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        //int ITeachers.GetTeacherId()
        //{
        //    return TeacherId;
        //}

        //void ITeachers.SetTeacherId(int TeacherId)
        //{
        //    this.TeacherId = TeacherId;
        //}
    }

}