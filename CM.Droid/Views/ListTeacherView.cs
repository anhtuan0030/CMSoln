using Android.App;
using Android.OS;
using Android.Widget;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Cirrious.MvvmCross.Droid.Views;

namespace CM.Droid.Views
{
    [Activity(Label = "Danh sách Giáo viên")]
    public class ListTeacherView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ListTeacherView);            
        }
    }
}