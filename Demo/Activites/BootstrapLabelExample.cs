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
    [Activity(Label = "BootstrapLabelExample")]
    class BootstrapLabelExample : BaseActivity
    {
        protected override int GetContentLayoutId()
        {
            return Resource.Layout.example_bootstrap_label;
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            FindViewById<BootstrapLabel>(Resource.Id.example_blabel_change_color).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                BootstrapLabel view = v as BootstrapLabel;
                view?.ChangeBootstrapBrand();
            }));
            FindViewById<BootstrapLabel>(Resource.Id.example_blabel_change_heading).SetOnClickListener(new Utils.ViewOnClick(v =>
            {

                var lblChangeHeading = v as BootstrapLabel;

                lblChangeHeading?.ChangeBootstrapHeading();
            }));
            FindViewById<BootstrapLabel>(Resource.Id.example_blabel_change_rounded).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                var lblChangeRounded = v as BootstrapLabel;
                lblChangeRounded.Rounded = !lblChangeRounded.Rounded;
            }));


        }

    }
}