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

    [Activity(Label = "DetalleActivity")]
    public class DetalleActivity : Activity
    {
        int idA,idM;
        ListView lv_Vista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activityDetalle);

            idA = Intent.GetIntExtra("idAnios", 0);
            idM = Intent.GetIntExtra("idMeses", 0);
            //Global.Año anios = Global.Años.Where(p => p.Id == idA).FirstOrDefault(); //recordar que al usar esto, tambien puedo
            //Global.Mes mes = Global.Meses.Where(p => p.Id == idM).FirstOrDefault(); //extraer varios datos, si usare el Id, hacerlo de forma directa
            // Create your application here

            lv_Vista = FindViewById<ListView>(Resource.Id.listView1);
            lv_Vista.Adapter = new AdapterDetalle(this, Global.DetallesConsumo.Where(p=>p.MesId==idM && p.AñoId==idA).ToList());
            //lv_Vista.Adapter = new AdapterDetalle(this, Global.DetallesConsumo.Where(p => p.MesId == anios.Id && p.AñoId == anios.Id).ToList());
        }
    }
}