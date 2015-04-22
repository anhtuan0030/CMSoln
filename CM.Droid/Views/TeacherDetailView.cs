using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace CM.Droid.Views
{
    [Activity(Label = "TeacherDetail")]
    public class TeacherDetailView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TeacherDetailView);
        }
    }
}