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
    [Activity(Label = "BootstrapCircleThumbnailExample")]
    public class BootstrapCircleThumbnailExample : BaseActivity
    {
        private readonly float BASELINE_SIZE = 300;
        private int resId = Resource.Drawable.ladybird;
        private DefaultBootstrapSize size = DefaultBootstrapSize.Md;

        protected override int GetContentLayoutId()
        {
            return Resource.Layout.example_bootstrap_circle_thumbnail;
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var imageChange = FindViewById<BootstrapCircleThumbnail>(Resource.Id.bcircle_image_change_example);
            var themeChange = FindViewById<BootstrapCircleThumbnail>(Resource.Id.bcircle_theme_change_example);
            var borderChange = FindViewById<BootstrapCircleThumbnail>(Resource.Id.bcircle_border_change_example);
            var sizeChange = FindViewById<BootstrapCircleThumbnail>(Resource.Id.bcircle_size_change_example);
            var setBitmapExample = FindViewById<BootstrapCircleThumbnail>(Resource.Id.bcircle_set_image_bitmap_example);
            var setDrawableExample = FindViewById<BootstrapCircleThumbnail>(Resource.Id.bcircle_set_image_drawable_example);
            var setResourceExample = FindViewById<BootstrapCircleThumbnail>(Resource.Id.bcircle_set_image_resource_example);

            var bm = BitmapFactory.DecodeResource(Resources, Resource.Drawable.small_daffodils);
            setBitmapExample.SetImageBitmap(bm);

            setDrawableExample.SetImageDrawable(Com.Beardedhen.Androidbootstrap.Utils.DrawableUtils.ResolveDrawable(Resource.Drawable.ladybird, this));
            setResourceExample.SetImageResource(Resource.Drawable.caterpillar);

            sizeChange.LayoutParameters = GetLayoutParams(size.ScaleFactor());


            themeChange.SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                themeChange.ChangeBootstrapBrand();
            }));
            imageChange.SetOnClickListener(new Utils.ViewOnClick(v =>
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
            borderChange.SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                borderChange.BorderDisplayed = !borderChange.BorderDisplayed;
            }));
            sizeChange.SetOnClickListener(new Utils.ViewOnClick(v =>
            {
                size = size.ChangeBootstrapSize();
                sizeChange.SetBootstrapSize(size);
                sizeChange.LayoutParameters = GetLayoutParams(size.ScaleFactor());

            }));

        }
        private LinearLayout.LayoutParams GetLayoutParams(float factor)
        {
            float size = BASELINE_SIZE * factor;
            return new LinearLayout.LayoutParams((int)size, (int)size);
        }

    }
}