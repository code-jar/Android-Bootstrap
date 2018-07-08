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
using Demo.Utils;

namespace Demo.Activites
{
    [Activity(Label = "BootstrapEditTextExample")]
    public class BootstrapEditTextExample : BaseActivity
    {
        private DefaultBootstrapSize size = DefaultBootstrapSize.Md;


        protected override int GetContentLayoutId()
        {
            return Resource.Layout.example_bootstrap_edit_text_view;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var changeEnabled = FindViewById<BootstrapEditText>(Resource.Id.bedit_text_change_enabled);
            var changeRound = FindViewById<BootstrapEditText>(Resource.Id.bedit_text_change_round);
            var changeTheme = FindViewById<BootstrapEditText>(Resource.Id.bedit_text_change_theme);
            var sizeExample = FindViewById<BootstrapEditText>(Resource.Id.bedit_text_change_size);

            FindViewById<Button>(Resource.Id.bedit_text_change_enabled_btn).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                changeEnabled.Enabled = !changeEnabled.Enabled;
            }));
            FindViewById<Button>(Resource.Id.bedit_text_change_round_btn).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                changeRound.Rounded = !changeRound.Rounded;
            }));
            FindViewById<Button>(Resource.Id.bedit_text_change_theme_btn).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                changeTheme.ChangeBootstrapBrand();
            }));
            FindViewById<Button>(Resource.Id.bedit_text_change_size_btn).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                size = size.ChangeBootstrapSize();

                sizeExample.SetBootstrapSize(size);
            }));


        }



    }
}