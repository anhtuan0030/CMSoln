using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsPhone.Platform;
using CM.Core.Services;
using Microsoft.Phone.Controls;

namespace CM.Phone
{
    public class Setup : MvxPhoneSetup
    {
        public Setup(PhoneApplicationFrame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        public class App : Core.App
        {
            public override void Initialize()
            {
                base.Initialize();

                Mvx.RegisterType(typeof(ITeacherService), typeof(TeacherService));
                Mvx.RegisterType(typeof(IStudentService), typeof(StudentService));

                //var result = Mvx.Resolve<ITeacherService>();
            }

        }
    }
}