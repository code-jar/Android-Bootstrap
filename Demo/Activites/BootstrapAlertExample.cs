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
using Com.Beardedhen.Androidbootstrap;
using Demo.Utils;

namespace Demo.Activites
{
    public class BootstrapAlertExample : BaseActivity
    {

        public static readonly string TAG = "BootstrapAlertExample";

        protected override int GetContentLayoutId()
        {
            return Resource.Layout.example_bootstrap_alert;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var interactive_button = FindViewById<Button>(Resource.Id.interactive_button);

            var alert = FindViewById<BootstrapAlert>(Resource.Id.dynamic_alert);

            interactive_button.SetOnClickListener(new ViewOnClick(v =>
            {
                if (ViewStates.Gone == alert.Visibility)
                {
                    alert.Show(true);
                }
                else
                {
                    alert.Dismiss(true);
                }
            }));

            alert.SetVisibilityChangeListener(new VisibilityChangeListener());

        }


        class VisibilityChangeListener : Java.Lang.Object, BootstrapAlert.IVisibilityChangeListener
        {
            public void OnAlertAppearCompletion(BootstrapAlert p0)
            {
                // Finished appearing alert!
            }

            public void OnAlertAppearStarted(BootstrapAlert p0)
            {
                // Started appearing alert!
            }

            public void OnAlertDismissCompletion(BootstrapAlert p0)
            {
                // Finished dismissing alert!
            }

            public void OnAlertDismissStarted(BootstrapAlert p0)
            {
                // Started dismissing alert!
            }
        }

    }
}