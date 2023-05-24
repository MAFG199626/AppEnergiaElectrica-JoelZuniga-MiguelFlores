﻿using Android.App;
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
    class AdapterDetalle : BaseAdapter
    {
        public override int Count => lista.Count;
        Activity context;
        List<Global.DetalleConsumo> lista;

        public AdapterDetalle(Activity context, List<Global.DetalleConsumo> lista)
        {
            this.context = context;
            this.lista = lista;
        }

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = lista[position];
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleExpandableListItem1, null);
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = $"Residencia: {item.Residencia} \n\nComercial: {item.Comercial} \n\nIndustrial: {item.Industrial} \n\nIrrigación: {item.Irrigacion} \n\nBombeo: {item.Bombeo} \n\nPromedioNacional: {item.PromedioNacional}";
            return view;
        }
    }
}


