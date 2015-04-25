using Cirrious.CrossCore;
using Parse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public class CourseService : ICourseService
    {
        private const string AppKey = "HBRj11q16Ma3RjHgYbEkvlqCJXf9M6ukw0jJcfsT";
        private const string AppRestKey = "qRht3wqVKvISvnsm20Z2K960dqZfn9cBBa4fxl00";
        private const string DotNetKey = "HwCpVJvemedpvSIIYTve46Yp6QIkRQ9xirYfzHaV";


        public CourseService()
        {
            ParseObject.RegisterSubclass<Courses>();
            ParseClient.Initialize(AppKey, DotNetKey);
        }

        public async Task<IEnumerable<ICourses>> GetCourses(int studentId)
        {
            var courseQuery = from c in new ParseQuery<Courses>().Include("Teachers")
                              where c.Get<int>("StudentId") == studentId
                              select c;

            //var userQuery = from t in new ParseQuery<Teachers>().Include("Courses")
            //                join c in courseQuery on t["TeacherId"] equals c["TeacherId"]
            //                select t;

            //IEnumerable<ParseUser> results = await userQuery.FindAsync();

            //var query = new ParseQuery<Courses>();
            //query.WhereEqualTo("StudentId", studentId);

            var result = await courseQuery.FindAsync();

            return result;
        }

        public void RegisterCourses(int teacherId, int studentId, string fullName, string subject)
        {
            Courses objx = new Courses
            {
                TeacherId = teacherId,
                StudentId = studentId,
                Fullname = fullName,
                Subject = subject,
                Status = 1,
                Remark = string.Empty,
                Schedule = "2-4-6 - 18H"
            };
            objx.SaveAsync();
        }

    }

    [ParseClassName("Courses")]
    public class Courses : ParseObject, ICourses
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

        [ParseFieldName("Subject")]
        public string Subject
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("StudentId")]
        public int StudentId
        {
            get { return GetProperty<int>(); }
            set { SetProperty<int>(value); }
        }

        [ParseFieldName("StartDate")]
        public DateTime StartDate
        {
            get { return GetProperty<DateTime>(); }
            set { SetProperty<DateTime>(value); }
        }

        [ParseFieldName("EndDate")]
        public DateTime EndDate
        {
            get { return GetProperty<DateTime>(); }
            set { SetProperty<DateTime>(value); }
        }

        [ParseFieldName("Schedule")]
        public string Schedule
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("Remark")]
        public string Remark
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("Status")]
        public int Status
        {
            get { return GetProperty<int>(); }
            set { SetProperty<int>(value); }
        }

        int ICourses.GetTeacherId()
        {
            return TeacherId;
        }

        void ICourses.SetTeacherId(int teacherId)
        {
            this.TeacherId = teacherId;
        }

        int ICourses.GetStudentId()
        {
            return StudentId;
        }

        void ICourses.SetStudentId(int studentId)
        {
            this.StudentId = studentId;
        }

        //public string Fullname
        //{
        //    get
        //    {
        //        var teacher = GetTeachter();
        //        var subject = teacher.Result.GetFullname();
        //        return subject;
        //    }
        //}

        //public string Subject
        //{
        //    get
        //    {
        //        var teacher = GetTeachter();
        //        var subject = teacher.Result.GetSubject();
        //        return subject;
        //    }
        //}

        //private async Task<ITeachers> GetTeachter()
        //{
        //    ITeacherService srv = Mvx.Resolve<ITeacherService>();
        //    var result = await srv.GetById(this.TeacherId);

        //    return result;
        //}
    }
}
