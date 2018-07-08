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
        private readonly int defaultEdge;
        private readonly int defaultTextColor;
        private readonly int activeFill;
        private readonly int activeEdge;
        private readonly int activeTextColor;
        private readonly int disabledFill;
        private readonly int disabledEdge;
        private readonly int disabledTextColor;

        public CustomBootstrapStyle(Context context)
        {
            Color = context.GetColor(Resource.Color.custom_default_fill);
            defaultEdge = context.GetColor(Resource.Color.custom_default_edge);
            defaultTextColor = context.GetColor(Resource.Color.primary_text_default_material_light);
            activeFill = context.GetColor(Resource.Color.custom_active_fill);
            activeEdge = context.GetColor(Resource.Color.custom_active_edge);
            activeTextColor = context.GetColor(Resource.Color.primary_text_default_material_dark);
            disabledFill = context.GetColor(Resource.Color.custom_disabled_fill);
            disabledEdge = context.GetColor(Resource.Color.custom_disabled_edge);
            disabledTextColor = context.GetColor(Resource.Color.bootstrap_gray);
        }

        public int Color { get; }

        public int ActiveEdge(Context p0)
        {
            return activeEdge;
        }

        public int ActiveFill(Context p0)
        {
            return activeFill;
        }

        public int ActiveTextColor(Context p0)
        {
            return activeTextColor;
        }

        public int DefaultEdge(Context p0)
        {
            return defaultEdge;
        }

        public int DefaultFill(Context p0)
        {
            return Color;
        }

        public int DefaultTextColor(Context p0)
        {
            return defaultTextColor;
        }

        public int DisabledEdge(Context p0)
        {
            return disabledEdge;
        }

        public int DisabledFill(Context p0)
        {
            return disabledFill;
        }

        public int DisabledTextColor(Context p0)
        {
            return disabledTextColor;
        }
    }
}