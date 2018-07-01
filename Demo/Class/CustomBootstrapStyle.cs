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
using Com.Beardedhen.Androidbootstrap.Api.Attributes;

namespace Demo.Class
{
    public class CustomBootstrapStyle : Java.Lang.Object, IBootstrapBrand
    {
        public CustomBootstrapStyle(Context context)
        {

        }

        public int Color => throw new NotImplementedException();

        public int ActiveEdge(Context p0)
        {
            throw new NotImplementedException();
        }

        public int ActiveFill(Context p0)
        {
            throw new NotImplementedException();
        }

        public int ActiveTextColor(Context p0)
        {
            throw new NotImplementedException();
        }

        public int DefaultEdge(Context p0)
        {
            throw new NotImplementedException();
        }

        public int DefaultFill(Context p0)
        {
            throw new NotImplementedException();
        }

        public int DefaultTextColor(Context p0)
        {
            throw new NotImplementedException();
        }

        public int DisabledEdge(Context p0)
        {
            throw new NotImplementedException();
        }

        public int DisabledFill(Context p0)
        {
            throw new NotImplementedException();
        }

        public int DisabledTextColor(Context p0)
        {
            throw new NotImplementedException();
        }
    }
}