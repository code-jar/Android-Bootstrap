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

            //Butterknife.ButterKnife.Bind(this, exampleCorners);


            // create a custom bootstrap size
            exampleCustomStyle.SetBootstrapSize(DefaultBootstrapSize.ValueOf("3.0f"));

            // create a Bootstrap Theme with holo colors
            exampleCustomStyle.BootstrapBrand = new CustomBootstrapStyle(this);


            exampleCorners.SetOnClickListener(new ViewOnClick(v => { exampleCorners.Rounded = !exampleCorners.Rounded; }));
            exampleOutline.SetOnClickListener(new ViewOnClick(v => { exampleOutline.ShowOutline = !exampleOutline.ShowOutline; }));
            exampleSize.SetOnClickListener(new ViewOnClick(v =>
            {
                if (size == DefaultBootstrapSize.Xs)
                {
                    size = DefaultBootstrapSize.Sm;
                }
                else if (size == DefaultBootstrapSize.Sm)
                {
                    size = DefaultBootstrapSize.Md;
                }
                else if (size == DefaultBootstrapSize.Md)
                {
                    size = DefaultBootstrapSize.Lg;
                }
                else if (size == DefaultBootstrapSize.Lg)
                {
                    size = DefaultBootstrapSize.Xl;
                }
                else if (size == DefaultBootstrapSize.Xl)
                {
                    size = DefaultBootstrapSize.Xs;
                }

                exampleSize.SetBootstrapSize(size);
            }));
            exampleTheme.SetOnClickListener(new ViewOnClick(v =>
            {
                var brand = exampleTheme.BootstrapBrand;

                if (brand == DefaultBootstrapBrand.Primary)
                {
                    exampleTheme.BootstrapBrand = DefaultBootstrapBrand.Success;
                }
                else if (brand == DefaultBootstrapBrand.Success)
                {
                    exampleTheme.BootstrapBrand = DefaultBootstrapBrand.Warning;
                }
                else if (brand == DefaultBootstrapBrand.Warning)
                {
                    exampleTheme.BootstrapBrand = DefaultBootstrapBrand.Danger;
                }
                else if (brand == DefaultBootstrapBrand.Danger)
                {
                    exampleTheme.BootstrapBrand = DefaultBootstrapBrand.Info;
                }
                else if (brand == DefaultBootstrapBrand.Info)
                {
                    exampleTheme.BootstrapBrand = DefaultBootstrapBrand.Secondary;
                }
                else if (brand == DefaultBootstrapBrand.Secondary)
                {
                    exampleTheme.BootstrapBrand = DefaultBootstrapBrand.Regular;
                }
                else if (brand == DefaultBootstrapBrand.Regular)
                {
                    exampleTheme.BootstrapBrand = DefaultBootstrapBrand.Primary;
                }

            }));

        }

    }
}