using Android.App;
using Android.OS;
using Android.Widget;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Cirrious.MvvmCross.Droid.Views;

namespace CM.Droid.Views
{
    [Activity(Label = "Hồ sơ Giáo viên")]
    public class TeacherView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            try
            {
                base.OnCreate(bundle);
                SetContentView(Resource.Layout.TeacherView);
            }
            catch (System.Exception ex)
            {
                var excep = ex;
            }
                        
        }
    }
}