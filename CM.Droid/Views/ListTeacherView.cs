using Android.App;
using Android.OS;
using Android.Widget;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Cirrious.MvvmCross.Droid.Views;

namespace CM.Droid.Views
{
    [Activity(Label = "Danh s�ch Gi�o vi�n")]
    public class ListTeacherView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ListTeacherView);
        }

        public override bool OnCreateOptionsMenu(Android.Views.IMenu menu)
        {
            var inflater = MenuInflater;
            //inflater.Inflate(Android.Resource.Menu)
            return true;
        }
    }
}