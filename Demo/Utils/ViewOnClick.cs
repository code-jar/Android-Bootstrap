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

namespace Demo.Utils
{
    public class ViewOnClick : Java.Lang.Object, View.IOnClickListener
    {
        private readonly Action<View> onClick;

        public ViewOnClick(Action<View> action)
        {
            onClick = action;
        }

        public void OnClick(View v)
        {
            onClick?.Invoke(v);
        }
    }
}