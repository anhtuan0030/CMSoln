using Android.App;
using Android.OS;
using Android.Widget;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Cirrious.MvvmCross.Droid.Views;

namespace CM.Droid.Views
{
    [Activity(Label = "Teachers")]
    public class TeacherView : MvxActivity
    {
        //private MvxListView teacherListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TeacherView);

            //teacherListView = FindViewById<MvxListView>(Resource.Id.listViewTeacher);
            //teacherListView.ItemClick += teacherListView_ItemClick;
            
        }

        //void teacherListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        //{
            
        //}
    }
}