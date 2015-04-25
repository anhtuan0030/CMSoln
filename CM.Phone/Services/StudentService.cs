using Parse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public class StudentService: IStudentService
    {
        private const string AppKey = "HBRj11q16Ma3RjHgYbEkvlqCJXf9M6ukw0jJcfsT";
        private const string AppRestKey = "qRht3wqVKvISvnsm20Z2K960dqZfn9cBBa4fxl00";
        private const string DotNetKey = "HwCpVJvemedpvSIIYTve46Yp6QIkRQ9xirYfzHaV";


        public StudentService()
        {
            ParseObject.RegisterSubclass<Students>();
            ParseClient.Initialize(AppKey, DotNetKey);
        }

        public async Task<IStudents> GetByUserName(string userName, string password)
        {
            var query = new ParseQuery<Students>();
            query.WhereEqualTo("Username", userName);
            query.WhereEqualTo("Password", password);

            var result = await query.FirstOrDefaultAsync();

            return result;
        }

        public async Task<IStudents> GetById(int studentId)
        {
            var query = from student in new ParseQuery<Students>()
                        where student.StudentId == studentId
                        select student;

            var result = await query.FirstOrDefaultAsync();

            return result;
        }

        public void Insert(Students student)
        {
            Students objx = student;
            objx.SaveAsync();
        }
    }

    [ParseClassName("Students")]
    public class Students : ParseObject, IStudents
    {
        [ParseFieldName("StudentId")]
        public int StudentId
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

        [ParseFieldName("UserName")]
        public string UserName
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

        [ParseFieldName("DoB")]
        public DateTime DoB
        {
            get { return GetProperty<DateTime>(); }
            set { SetProperty<DateTime>(value); }
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


        int IStudents.GetStudentId()
        {
            return StudentId;
        }

        void IStudents.SetStudentId(int studentId)
        {
            this.StudentId = studentId;
        }
    }
}