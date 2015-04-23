using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using CM.Core.Services;

namespace CM.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            // Mvx.RegisterType(typeof(ITeacherService), typeof(TeacherService));

            //var result =  Mvx.Resolve<ITeacherService>();

            //RegisterAppStart<ViewModels.ListTeacherViewModel>();
            RegisterAppStart<ViewModels.CourseViewModel>();
        }
    }
}