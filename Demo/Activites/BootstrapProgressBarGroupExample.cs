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

namespace Demo.Activites
{
    [Activity(Label = "BootstrapProgressBarGroupExample")]
    public class BootstrapProgressBarGroupExample : BaseActivity
    {
        bool rounded = false;

        protected override int GetContentLayoutId()
        {
            return Resource.Layout.example_bootstrap_progress_bar_group;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var groupAdd = FindViewById<BootstrapProgressBarGroup>(Resource.Id.example_progress_bar_group_add_group);
            var groupRound = FindViewById<BootstrapProgressBarGroup>(Resource.Id.example_progress_bar_group_round_group);
            var bootstrapProgressBar1 = FindViewById<BootstrapProgressBar>(Resource.Id.example_progress_bar_group_progress_1);
            var bootstrapProgressBar2 = FindViewById<BootstrapProgressBar>(Resource.Id.example_progress_bar_group_progress_2);


            FindViewById<Button>(Resource.Id.example_progress_bar_group_add).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                Random rand = new Random();
                BootstrapProgressBar bar = new BootstrapProgressBar(this)
                {
                    Progress = 10
                };
                int brand = 5;
                while (brand == 5)
                {
                    brand = rand.Next(7);
                }

                bar.BootstrapBrand = DefaultBootstrapBrand.FromAttributeValue(brand);

                if (groupAdd.CumulativeProgress + 10 <= 100)
                {
                    groupAdd.AddView(bar);
                }
                else
                {
                    groupAdd.RemoveViews(2, groupAdd.ChildCount - 3);
                }
            }));
            FindViewById<Button>(Resource.Id.example_progress_bar_group_round).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                groupRound.Rounded = !rounded;
            }));
            FindViewById<Button>(Resource.Id.example_progress_bar_group_progress).SetOnClickListener(new Utils.ViewOnClick(v =>
            {

                Random rand = new Random();
                int progress = rand.Next(30) + 10;
                switch (rand.Next(2))
                {
                    case 0:
                        bootstrapProgressBar1.Progress = progress;
                        break;
                    case 1:
                        bootstrapProgressBar2.Progress = progress;
                        break;
                }
            }));
        }


    }
}