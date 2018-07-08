using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Beardedhen.Androidbootstrap;
using Com.Beardedhen.Androidbootstrap.Api.Defaults;
using Demo.Utils;

namespace Demo.Activites
{
    [Activity(Label = "BootstrapThumbnailExample")]
    public class BootstrapThumbnailExample : BaseActivity
    {

        private int resId = Resource.Drawable.ladybird;
        private DefaultBootstrapSize size = DefaultBootstrapSize.Md;

        protected override int GetContentLayoutId()
        {
            return Resource.Layout.example_bootstrap_thumbnail;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var imageChange = FindViewById<BootstrapThumbnail>(Resource.Id.bthumb_image_change_example);
            var themeChange = FindViewById<BootstrapThumbnail>(Resource.Id.bthumb_theme_change_example);
            var borderChange = FindViewById<BootstrapThumbnail>(Resource.Id.bthumb_border_change_example);
            var roundedChange = FindViewById<BootstrapThumbnail>(Resource.Id.bthumb_rounded_change_example);
            var sizeChange = FindViewById<BootstrapThumbnail>(Resource.Id.bthumb_size_change_example);
            var setBitmapExample = FindViewById<BootstrapThumbnail>(Resource.Id.bthumb_set_image_bitmap_example);
            var setDrawableExample = FindViewById<BootstrapThumbnail>(Resource.Id.bthumb_set_image_drawable_example);
            var setResourceExample = FindViewById<BootstrapThumbnail>(Resource.Id.bthumb_set_image_resource_example);

            var bm = BitmapFactory.DecodeResource(Resources, Resource.Drawable.small_daffodils);
            setBitmapExample.SetImageBitmap(bm);

            setDrawableExample.SetImageDrawable(Com.Beardedhen.Androidbootstrap.Utils.DrawableUtils.ResolveDrawable(Resource.Drawable.ladybird, this));

            setResourceExample.SetImageResource(Resource.Drawable.caterpillar);
            sizeChange.LayoutParameters = (GetLayoutParams(size.ScaleFactor()));

            imageChange.SetOnClickListener(new ViewOnClick(v =>
            {
                switch (resId)
                {
                    case Resource.Drawable.ladybird:
                        resId = Resource.Drawable.caterpillar;
                        break;
                    case Resource.Drawable.caterpillar:
                        resId = 0;
                        break;
                    case 0:
                        resId = Resource.Drawable.ladybird;
                        break;
                }
                imageChange.SetImageResource(resId);
            }));
            themeChange.SetOnClickListener(new ViewOnClick(v =>
            {
                themeChange.ChangeBootstrapBrand();
            }));
            roundedChange.SetOnClickListener(new ViewOnClick(v =>
            {
                roundedChange.Rounded = !roundedChange.Rounded;
            }));
            borderChange.SetOnClickListener(new ViewOnClick(v =>
            {
                borderChange.BorderDisplayed = !borderChange.BorderDisplayed;
            }));
            sizeChange.SetOnClickListener(new ViewOnClick(v =>
            {
                size = size.ChangeBootstrapSize();
                sizeChange.SetBootstrapSize(size);
                sizeChange.LayoutParameters = GetLayoutParams(size.ScaleFactor());
            }));
        }

        private LinearLayout.LayoutParams GetLayoutParams(float factor)
        {
            float baselineSize = 300;
            float size = baselineSize * factor;
            return new LinearLayout.LayoutParams((int)size, (int)size);
        }

    }
}