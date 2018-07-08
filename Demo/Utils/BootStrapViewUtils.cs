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
using Com.Beardedhen.Androidbootstrap.Api.Defaults;
using Com.Beardedhen.Androidbootstrap.Api.View;

namespace Demo.Utils
{
    public static class BootStrapViewUtils
    {
        public static void ChangeBootstrapBrand(this IBootstrapBrandView view)
        {
            if (view == null)
            {
                return;
            }

            var brand = view.BootstrapBrand;

            if (brand == DefaultBootstrapBrand.Primary)
            {
                view.BootstrapBrand = DefaultBootstrapBrand.Success;
            }
            else if (brand == DefaultBootstrapBrand.Success)
            {
                view.BootstrapBrand = DefaultBootstrapBrand.Warning;
            }
            else if (brand == DefaultBootstrapBrand.Warning)
            {
                view.BootstrapBrand = DefaultBootstrapBrand.Danger;
            }
            else if (brand == DefaultBootstrapBrand.Danger)
            {
                view.BootstrapBrand = DefaultBootstrapBrand.Info;
            }
            else if (brand == DefaultBootstrapBrand.Info)
            {
                view.BootstrapBrand = DefaultBootstrapBrand.Secondary;
            }
            else if (brand == DefaultBootstrapBrand.Secondary)
            {
                view.BootstrapBrand = DefaultBootstrapBrand.Regular;
            }
            else if (brand == DefaultBootstrapBrand.Regular)
            {
                view.BootstrapBrand = DefaultBootstrapBrand.Primary;
            }
            else
            {
                view.BootstrapBrand = DefaultBootstrapBrand.Primary;
            }
        }

        public static DefaultBootstrapSize ChangeBootstrapSize(this DefaultBootstrapSize size)
        {
            if (size == null)
            {
                throw new ArgumentNullException(nameof(size));
            }

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

            return size;
        }

        public static void ChangeBootstrapHeading(this IBootstrapHeadingView view)
        {
            if (view == null)
            {
                return;
            }

            if (view.BootstrapHeading == DefaultBootstrapHeading.H1)
            {
                view.BootstrapHeading = DefaultBootstrapHeading.H2;
            }
            else if (view.BootstrapHeading == DefaultBootstrapHeading.H2)
            {
                view.BootstrapHeading = DefaultBootstrapHeading.H3;
            }
            else if (view.BootstrapHeading == DefaultBootstrapHeading.H3)
            {
                view.BootstrapHeading = DefaultBootstrapHeading.H4;
            }
            else if (view.BootstrapHeading == DefaultBootstrapHeading.H4)
            {
                view.BootstrapHeading = DefaultBootstrapHeading.H5;
            }
            else if (view.BootstrapHeading == DefaultBootstrapHeading.H5)
            {
                view.BootstrapHeading = DefaultBootstrapHeading.H6;
            }
            else if (view.BootstrapHeading == DefaultBootstrapHeading.H6)
            {
                view.BootstrapHeading = DefaultBootstrapHeading.H1;
            }
            else
            {
                view.BootstrapHeading = DefaultBootstrapHeading.H1;
            }

        }
    }
}