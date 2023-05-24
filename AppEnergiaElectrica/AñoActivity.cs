using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace AppEnergiaElectrica
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class AñoActivity : AppCompatActivity
    {
        ListView lv_Vista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activityAnio);
            lv_Vista = FindViewById<ListView>(Resource.Id.listView1);
            lv_Vista.Adapter = new AdapterAño(this, Global.Años);
            lv_Vista.ItemClick += Lv_Vista_ItemClick;
        }
        private void Lv_Vista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(MesActivity));
            Global.Año anios = Global.Años[e.Position];
            i.PutExtra("idAnios", anios.Id);
            StartActivity(i);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}