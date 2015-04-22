using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace CM.Droid.Views
{
    [Activity(Label = "View for CourseViewModel")]
    public class CourseView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CourseView);
        }
    }
}