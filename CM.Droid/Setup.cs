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
            // Mvx.RegisterType(typeof(ITeacherService), typeof(TeacherService));
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
        private const string AppKey = "HBRj11q16Ma3RjHgYbEkvlqCJXf9M6ukw0jJcfsT";
        private const string AppRestKey = "qRht3wqVKvISvnsm20Z2K960dqZfn9cBBa4fxl00";
        private const string DotNetKey = "HwCpVJvemedpvSIIYTve46Yp6QIkRQ9xirYfzHaV";
        public override void Initialize()
        {

            //ParseObject.RegisterSubclass<Teachers1>();
           // ParseClient.Initialize(AppKey, DotNetKey);
         
            base.Initialize();

   //CreatableTypes()
   //             .EndingWith("Service")
   //             .AsInterfaces()
   //             .RegisterAsLazySingleton();

            Mvx.RegisterType(typeof(ITeacherService), typeof(TeacherService));

            //var result = Mvx.Resolve<ITeacherService>();

            //RegisterAppStart<FirstViewModel>();
            //RegisterAppStart<ListTeacherViewModel>();
        }

    }
}