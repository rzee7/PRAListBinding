using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PRAListBinding
{
    public class DataProvider
    {
        public static List<RowItem> GetData()
        {
            return new List<RowItem>() { new RowItem { ImageUrl = "https://s-media-cache-ak0.pinimg.com/736x/73/5f/88/735f880d0b2fa42eb7ef139d6725a0a4.jpg", Title = "Cotton-lace-butterfly" },
            new RowItem { ImageUrl = "https://s-media-cache-ak0.pinimg.com/236x/b1/8b/a3/b18ba3fe2a59d6e07c3fc7e2dd2fbd05.jpg", Title = "County Cakes" },
            new RowItem { ImageUrl = "https://s-media-cache-ak0.pinimg.com/736x/59/5f/11/595f1186d10300242cbfaab4dc8b92f6.jpg", Title = "Hand Made Card"},
            new RowItem { ImageUrl = "http://xamarin.com/content/images/pages/branding/assets/xamagon.png", Title = "Xamarin"}
            };
        }
    }
}