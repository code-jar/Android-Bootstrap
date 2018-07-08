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
    [Activity(Label = "BootstrapBadgeExample")]
    public class BootstrapBadgeExample : BaseActivity
    {

        protected override int GetContentLayoutId()
        {
            return Resource.Layout.example_bootstrap_badge;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var xmlBadgeButton = FindViewById<BootstrapButton>(Resource.Id.xml_badge_button);
            var javaBadgeButton = FindViewById<BootstrapButton>(Resource.Id.java_badge_button);
            var lonelyBadge = FindViewById<BootstrapBadge>(Resource.Id.lonely_badge);

            var badgeThird = new BootstrapBadge(this) { BadgeText = "Hi!" };

            javaBadgeButton.SetBadge(badgeThird);


            lonelyBadge.SetOnClickListener(new ViewOnClick(v => { lonelyBadge.BadgeText = new Random().Next().ToString(); }));

            xmlBadgeButton.SetOnClickListener(new ViewOnClick(v => { xmlBadgeButton.BadgeText = new Random().Next().ToString(); }));

            javaBadgeButton.SetOnClickListener(new ViewOnClick(v => { javaBadgeButton.BadgeText = new Random().Next().ToString(); }));

        }


    }
}