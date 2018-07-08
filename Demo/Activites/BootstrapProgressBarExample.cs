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
    [Activity(Label = "BootstrapProgressBarExample")]
    public class BootstrapProgressBarExample : BaseActivity
    {

        class ChangeState
        {
            public static ChangeState FIRST { get { return new ChangeState(false, false); } }
            public static ChangeState SECOND { get { return new ChangeState(false, true); } }
            public static ChangeState THIRD { get { return new ChangeState(true, false); } }
            public static ChangeState FOURTH { get { return new ChangeState(true, true); } }

            public readonly bool Animated;
            public readonly bool Striped;

            public ChangeState(bool animated, bool striped)
            {
                this.Animated = animated;
                this.Striped = striped;
            }

            public ChangeState Next()
            {
                if (this.Equals(FIRST))
                {
                    return SECOND;
                }
                else if (this.Equals(SECOND))
                {
                    return THIRD;
                }
                else if (this.Equals(THIRD))
                {
                    return FOURTH;
                }
                else
                {
                    return FIRST;
                }

            }

            public override bool Equals(object obj)
            {
                if (obj is ChangeState)
                {
                    var state = obj as ChangeState;

                    if (state == null || this == null)
                        return false;

                    if (state.Animated == this.Animated && state.Striped == this.Striped)
                        return true;

                    return false;
                }

                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }


        private Random random;
        private ChangeState changeState = ChangeState.FIRST;
        private DefaultBootstrapSize size = DefaultBootstrapSize.Md;

        protected override int GetContentLayoutId()
        {
            return Resource.Layout.example_bootstrap_progress_bar;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var defaultExample = FindViewById<BootstrapProgressBar>(Resource.Id.example_progress_default);
            var animatedExample = FindViewById<BootstrapProgressBar>(Resource.Id.example_progress_animated);
            var stripedExample = FindViewById<BootstrapProgressBar>(Resource.Id.example_progress_striped);
            var stripedAnimExample = FindViewById<BootstrapProgressBar>(Resource.Id.example_progress_striped_animated);
            var changeExample = FindViewById<BootstrapProgressBar>(Resource.Id.example_progress_change);
            var sizeExample = FindViewById<BootstrapProgressBar>(Resource.Id.example_size_change);


            FindViewById<Button>(Resource.Id.example_progress_default_btn).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                defaultExample.Progress = RandomProgress(defaultExample.Progress, 100);
            }));

            FindViewById<Button>(Resource.Id.example_progress_animated_btn).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                animatedExample.Progress = RandomProgress(animatedExample.Progress, 100);
            }));
            FindViewById<Button>(Resource.Id.example_progress_striped_btn).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                stripedExample.Progress = RandomProgress(stripedExample.Progress, 100);
            }));
            FindViewById<Button>(Resource.Id.example_progress_striped_animated_btn).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                stripedAnimExample.Progress = RandomProgress(stripedAnimExample.Progress, 100);
            }));
            FindViewById<Button>(Resource.Id.example_progress_change_type_btn).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                changeState = changeState.Next();
                changeExample.Striped = changeState.Striped;
                changeExample.Animated = changeState.Animated;
            }));
            FindViewById<Button>(Resource.Id.example_progress_change_rounded_btn).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                changeExample.Rounded = !changeExample.Rounded;
            }));
            FindViewById<Button>(Resource.Id.example_progress_change_color_btn).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                changeExample.ChangeBootstrapBrand();
            }));
            FindViewById<Button>(Resource.Id.example_size_change_btn).SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                size = size.ChangeBootstrapSize();
                sizeExample.SetBootstrapSize(size);
            }));

        }

        private int RandomProgress(int currentProgress, int maxProgress)
        {
            if (random == null)
            {
                random = new Random();
            }

            int prog = currentProgress + random.Next(20);

            if (prog > maxProgress)
            {
                prog -= maxProgress;
            }

            return prog;
        }


    }
}