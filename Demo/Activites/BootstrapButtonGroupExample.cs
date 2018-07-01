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
    public class BootstrapButtonGroupExample : BaseActivity
    {
        private DefaultBootstrapSize size = DefaultBootstrapSize.Md;

        protected override int GetContentLayoutId()
        {
            return Resource.Layout.example_bootstrap_button_group;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var orientationChange = FindViewById<BootstrapButtonGroup>(Resource.Id.bbutton_group_orientation_change);
            var sizeChange = FindViewById<BootstrapButtonGroup>(Resource.Id.bbutton_group_size_change);
            var outlineChange = FindViewById<BootstrapButtonGroup>(Resource.Id.bbutton_group_outline_change);
            var roundedChange = FindViewById<BootstrapButtonGroup>(Resource.Id.bbutton_group_rounded_change);
            var brandChange = FindViewById<BootstrapButtonGroup>(Resource.Id.bbutton_group_brand_change);
            var childChange = FindViewById<BootstrapButtonGroup>(Resource.Id.bbutton_group_child_change);

            var checkedText = FindViewById<TextView>(Resource.Id.bbutton_group_checked_text);

            var radioButton1 = FindViewById<BootstrapButton>(Resource.Id.bbutton_group_checked1);
            var radioButton2 = FindViewById<BootstrapButton>(Resource.Id.bbutton_group_checked2);
            var radioButton3 = FindViewById<BootstrapButton>(Resource.Id.bbutton_group_checked3);



            radioButton1.SetOnCheckedChangedListener(new OnCheckedChangedListener((btn, isChecked) =>
            {
                if (isChecked)
                {
                    checkedText.SetText("radio, button 1 checked", TextView.BufferType.Normal);
                }
            }));
            radioButton2.SetOnCheckedChangedListener(new OnCheckedChangedListener((btn, isChecked) =>
            {
                if (isChecked)
                {
                    checkedText.SetText("radio, button 2 checked", TextView.BufferType.Normal);
                }
            }));
            radioButton3.SetOnCheckedChangedListener(new OnCheckedChangedListener((btn, isChecked) =>
            {
                if (isChecked)
                {
                    checkedText.SetText("radio, button 3 checked", TextView.BufferType.Normal);
                }
            }));


            FindViewById<Button>(Resource.Id.bbutton_group_orientation_change_btn).SetOnClickListener(new ViewOnClick(v =>
            {
                bool isHorizontal = orientationChange.Orientation == Orientation.Horizontal;
                var newOrientation = isHorizontal ? Orientation.Vertical : Orientation.Horizontal;
                orientationChange.Orientation = newOrientation;
            }));
            FindViewById<Button>(Resource.Id.bbutton_group_outline_change_btn).SetOnClickListener(new ViewOnClick(v =>
            {
                outlineChange.ShowOutline = !outlineChange.ShowOutline;
            }));
            FindViewById<Button>(Resource.Id.bbutton_group_rounded_change_btn).SetOnClickListener(new ViewOnClick(v =>
            {
                roundedChange.Rounded = !roundedChange.Rounded;
            }));
            FindViewById<Button>(Resource.Id.bbutton_group_child_add_btn).SetOnClickListener(new ViewOnClick(v =>
            {
                int count = childChange.ChildCount;

                BootstrapButton button = new BootstrapButton(this);
                button.SetText((count + 1).ToString(), TextView.BufferType.Normal);

                childChange.AddView(button);
            }));
            FindViewById<Button>(Resource.Id.bbutton_group_child_remove_btn).SetOnClickListener(new ViewOnClick(v =>
            {
                int count = childChange.ChildCount;

                if (count > 0)
                {
                    childChange.RemoveViewAt(count - 1);
                }
            }));
            FindViewById<Button>(Resource.Id.bbutton_group_brand_change_btn).SetOnClickListener(new ViewOnClick(v =>
            {
                var brand = brandChange.BootstrapBrand;

                if (brand == DefaultBootstrapBrand.Primary)
                {
                    brandChange.BootstrapBrand = DefaultBootstrapBrand.Success;
                }
                else if (brand == DefaultBootstrapBrand.Success)
                {
                    brandChange.BootstrapBrand = DefaultBootstrapBrand.Info;
                }
                else if (brand == DefaultBootstrapBrand.Info)
                {
                    brandChange.BootstrapBrand = DefaultBootstrapBrand.Warning;
                }
                else if (brand == DefaultBootstrapBrand.Warning)
                {
                    brandChange.BootstrapBrand = DefaultBootstrapBrand.Danger;
                }
                else if (brand == DefaultBootstrapBrand.Danger)
                {
                    brandChange.BootstrapBrand = DefaultBootstrapBrand.Secondary;
                }
                else if (brand == DefaultBootstrapBrand.Secondary)
                {
                    brandChange.BootstrapBrand = DefaultBootstrapBrand.Regular;
                }
                else if (brand == DefaultBootstrapBrand.Regular)
                {
                    brandChange.BootstrapBrand = DefaultBootstrapBrand.Primary;
                }


            }));
            FindViewById<Button>(Resource.Id.bbutton_group_size_change_btn).SetOnClickListener(new ViewOnClick(v =>
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

                sizeChange.SetBootstrapSize(size);
            }));
        }


        class OnCheckedChangedListener : Java.Lang.Object, BootstrapButton.IOnCheckedChangedListener
        {
            private readonly Action<BootstrapButton, bool> onClick;

            public OnCheckedChangedListener(Action<BootstrapButton, bool> action)
            {
                onClick = action;
            }

            public void OnCheckedChanged(BootstrapButton p0, bool p1)
            {
                onClick?.Invoke(p0, p1);
            }
        }



    }
}