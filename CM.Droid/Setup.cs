using Android.Content;
using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using CM.Core.Services;

namespace CM.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            CreatableTypes()
               .EndingWith("Service")
               .AsInterfaces()
               .RegisterAsLazySingleton();
            return new Core.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
}

    public class App : Core.App
    {
        public override void Initialize()
        {         
            base.Initialize();

            Mvx.RegisterType(typeof(ITeacherService), typeof(TeacherService));
            Mvx.RegisterType(typeof(IStudentService), typeof(StudentService));
            Mvx.RegisterType(typeof(ICourseService), typeof(CourseService));

            //var result = Mvx.Resolve<ITeacherService>();
        }

    }
}