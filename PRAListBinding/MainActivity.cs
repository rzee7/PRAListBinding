using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using PRAAdapterLess;
using Squareup.Picasso;

namespace PRAListBinding
{
    [Activity(Label = "vDoers", MainLauncher = true, Icon = "@drawable/pra")]
    public class MainActivity : Activity, IDataRowView<RowItem>
    {

        #region On Create Method

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            #region Initializing Views
            //Register this activity
            PRAService.Register<IDataRowView<RowItem>>(this);

            var listView = FindViewById<ListView>(Resource.Id.praListView);
            listView.Adapter = new PRAAdapter<RowItem>(this, DataProvider.GetData());

            #endregion
        }

        #endregion

        #region Get View For List View

        public View GetDataRowView(int position, View convertView, ViewGroup parent, RowItem item)
        {
            View view = convertView;
            if (view == null)
                view = LayoutInflater.Inflate(Resource.Layout.ListItem, parent, false);
            view.FindViewById<TextView>(Resource.Id.titleView).Text = item.Title;
            var imageView = view.FindViewById<ImageView>(Resource.Id.imageView);
            Picasso.With(view.Context).Load(item.ImageUrl).Into(imageView);
            return view;
        }

        #endregion
    }
}

