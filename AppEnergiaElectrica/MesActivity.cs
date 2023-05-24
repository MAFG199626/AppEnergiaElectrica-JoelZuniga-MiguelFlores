using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppEnergiaElectrica
{
    [Activity(Label = "AñosActivity")]
    public class MesActivity : Activity
    {
        ListView lv_Vista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activityMes);

            lv_Vista = FindViewById<ListView>(Resource.Id.listView1);
            lv_Vista.Adapter = new AdapterMeses(this, Global.Meses);
            lv_Vista.ItemClick += Lv_Vista_ItemClick;     
        }

        private void Lv_Vista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(DetalleActivity));
            Global.Mes meses = Global.Meses[e.Position];


            i.PutExtra("idMeses", meses.Id);
            i.PutExtra("idAnios", Intent.GetIntExtra("idAnios", 0));
            StartActivity(i);
        }
    }
}