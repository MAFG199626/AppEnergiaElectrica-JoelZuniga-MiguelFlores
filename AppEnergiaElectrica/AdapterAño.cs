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
    class AdapterAño : BaseAdapter
    {
        public override int Count => lista.Count;
        Activity context;
        List<Global.Año> lista;

        public AdapterAño(Activity context, List<Global.Año> lista)
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

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Anio.ToString();
            
            return view;
        }
    }
}