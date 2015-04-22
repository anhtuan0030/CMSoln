using Parse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public class TeacherService: ITeacherService
    {
        private const string AppKey = "HBRj11q16Ma3RjHgYbEkvlqCJXf9M6ukw0jJcfsT";
        private const string AppRestKey = "qRht3wqVKvISvnsm20Z2K960dqZfn9cBBa4fxl00";
        private const string DotNetKey = "HwCpVJvemedpvSIIYTve46Yp6QIkRQ9xirYfzHaV";


        public TeacherService()
        {
            ParseObject.RegisterSubclass<Teachers>();
            ParseClient.Initialize(AppKey, DotNetKey);
        }

        public async Task<IEnumerable<ITeachers>> GetTeachers()
        {
            var query = new ParseQuery<Teachers>();

            var result = await query.FindAsync();

            return result;
        }

        public async Task<ITeachers> GetById(int teacherId)
        {
            var query = from teacher in new ParseQuery<Teachers>()
                        where teacher.TeacherId == teacherId
                        select teacher;

            var result = await query.FirstOrDefaultAsync();

            //var query = from teacher in ParseObject.GetQuery("Teachers")
            //            where teacher.Get<int>("TeacherId") == teacherId
            //            select teacher;
            //var result = (ITeachers)await query.FirstAsync();

            return result;
        }

    }

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

        int ITeachers.GetTeacherId()
        {
            return TeacherId;
        }

        void ITeachers.SetTeacherId(int TeacherId)
        {
            this.TeacherId = TeacherId;
        }
    }
}
