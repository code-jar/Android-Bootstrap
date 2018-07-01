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
    public class AwesomeTextViewExample : BaseActivity
    {
        private AwesomeTextView exampleChange;
        private AwesomeTextView exampleFlash;
        private AwesomeTextView exampleRotate;
        private AwesomeTextView exampleMultiChange;
        private AwesomeTextView exampleBuilder;
        private AwesomeTextView mixAndMatch;

        private bool android = true;
        private bool wikipedia = true;

        protected override int GetContentLayoutId()
        {
            return Resource.Layout.example_awesome_text_view;
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetupFontAwesomeText();

            exampleChange = FindViewById<AwesomeTextView>(Resource.Id.example_fa_text_change);
            exampleChange.SetOnClickListener(new ViewOnClick(v =>
            {
                android = !android;
                exampleChange.SetFontAwesomeIcon(android ? Com.Beardedhen.Androidbootstrap.Font.FontAwesome.FaAndroid : Com.Beardedhen.Androidbootstrap.Font.FontAwesome.FaApple);
            }));
            exampleFlash = FindViewById<AwesomeTextView>(Resource.Id.example_fa_text_flash);
            exampleRotate = FindViewById<AwesomeTextView>(Resource.Id.example_fa_text_rotate);
            exampleMultiChange = FindViewById<AwesomeTextView>(Resource.Id.example_fa_text_multi_change);
            exampleMultiChange.SetOnClickListener(new ViewOnClick(v =>
            {
                wikipedia = !wikipedia;
                string text = wikipedia ? "{fa_image} is in the {fa_cloud}" : "{fa_bank} are on {fa_globe}";
                exampleMultiChange.SetMarkdownText(text);
            }));
            exampleBuilder = FindViewById<AwesomeTextView>(Resource.Id.example_fa_text_builder);
            mixAndMatch = FindViewById<AwesomeTextView>(Resource.Id.example_mix_and_match);
        }


        private void SetupFontAwesomeText()
        {
            exampleFlash.StartFlashing(true, AwesomeTextView.AnimationSpeed.Fast);
            exampleRotate.StartRotate(true, AwesomeTextView.AnimationSpeed.Slow);

            var text = new BootstrapText.Builder(this)
                .AddText("I ")
                .AddFontAwesomeIcon(Com.Beardedhen.Androidbootstrap.Font.FontAwesome.FaHeart)
                .AddText(" going on ")
                .AddFontAwesomeIcon(Com.Beardedhen.Androidbootstrap.Font.FontAwesome.FaTwitter)
                .Build();

            exampleBuilder.BootstrapText = text;

            mixAndMatch.BootstrapText = new BootstrapText.Builder(this)
                    .AddFontAwesomeIcon(Com.Beardedhen.Androidbootstrap.Font.FontAwesome.FaAnchor)
                    .AddTypicon(Com.Beardedhen.Androidbootstrap.Font.Typicon.TyCode)
                    .AddMaterialIcon(Com.Beardedhen.Androidbootstrap.Font.MaterialIcons.MdPhoto)
                    .Build();

        }

    }
}