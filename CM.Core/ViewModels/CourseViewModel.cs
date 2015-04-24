using Cirrious.MvvmCross.ViewModels;
using CM.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.ViewModels
{
    public class CourseViewModel : MvxViewModel
    {
        private readonly ICourseService _courseService;

        public CourseViewModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public async void Init()
        {
            var studentId = int.Parse(Session.Dictionary["StudentId"].ToString());
            var result = await _courseService.GetCourses(studentId);

            ListData = result.ToList();
        }

        private List<ICourses> _course;
        public List<ICourses> ListData
        {
            get { return _course; }
            set { _course = value; RaisePropertyChanged(() => ListData); }
        }

        
    }
}
