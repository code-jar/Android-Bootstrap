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
using Com.Beardedhen.Androidbootstrap.Api.Defaults;
using Demo.Class;
using Demo.Utils;

namespace Demo.Activites
{
    [Activity(Label = "BootstrapButtonExample")]
    public class BootstrapButtonExample : BaseActivity
    {
        private DefaultBootstrapSize size = DefaultBootstrapSize.Lg;

        protected override int GetContentLayoutId()
        {
            return Resource.Layout.example_bootstrap_button;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var exampleCorners = FindViewById<BootstrapButton>(Resource.Id.bbutton_example_corners);
            var exampleOutline = FindViewById<BootstrapButton>(Resource.Id.bbutton_example_outline);
            var exampleSize = FindViewById<BootstrapButton>(Resource.Id.bbutton_example_size);
            var exampleTheme = FindViewById<BootstrapButton>(Resource.Id.bbutton_example_theme);
            var exampleCustomStyle = FindViewById<BootstrapButton>(Resource.Id.example_bbutton_custom_style);


            // create a custom bootstrap size
            exampleCustomStyle.SetBootstrapSize(DefaultBootstrapSize.Sm);

            // create a Bootstrap Theme with holo colors
            exampleCustomStyle.BootstrapBrand = new CustomBootstrapStyle(this);


            exampleCorners.SetOnClickListener(new ViewOnClick(v => { exampleCorners.Rounded = !exampleCorners.Rounded; }));
            exampleOutline.SetOnClickListener(new ViewOnClick(v => { exampleOutline.ShowOutline = !exampleOutline.ShowOutline; }));
            exampleSize.SetOnClickListener(new ViewOnClick(v =>
            {
                size = size.ChangeBootstrapSize();
                exampleSize.SetBootstrapSize(size);
            }));
            exampleTheme.SetOnClickListener(new ViewOnClick(v =>
            {
                exampleTheme.ChangeBootstrapBrand();
            }));

        }

    }
}