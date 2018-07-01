using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Com.Beardedhen.Androidbootstrap;
using Demo.Utils;
using Android.Content;
using Demo.Activites;

namespace Demo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);


            FindViewById<BootstrapButton>(Resource.Id.github_btn).SetOnClickListener(new ViewOnClick(v =>
            {
                var intent = new Android.Content.Intent();
                StartActivity(intent);
                intent.SetData(Android.Net.Uri.Parse("https://github.com/Bearded-Hen/Android-Bootstrap"));
                StartActivity(intent);
            }));
            FindViewById<BootstrapButton>(Resource.Id.example_bootstrap_button).SetOnClickListener(new ViewOnClick(v => { StartActivity(new Intent(this, typeof(BootstrapButtonExample))); }));
            FindViewById<BootstrapButton>(Resource.Id.example_fontawesometext).SetOnClickListener(new ViewOnClick(v => { StartActivity(new Intent(this, typeof(AwesomeTextViewExample))); }));
            FindViewById<BootstrapButton>(Resource.Id.example_bootstrap_label).SetOnClickListener(new ViewOnClick(v =>
            {
                //StartActivity(new Intent(this, typeof(BootstrapLabelExample)));
            }));
            FindViewById<BootstrapButton>(Resource.Id.example_bootstrap_progress).SetOnClickListener(new ViewOnClick(v =>
            {
                //StartActivity(new Intent(this, typeof(BootstrapProgressBarExample)));
            }));
            FindViewById<BootstrapButton>(Resource.Id.example_bootstrap_progress_group).SetOnClickListener(new ViewOnClick(v =>
            {
                //StartActivity(new Intent(this, typeof(BootstrapProgressBarGroupExample)));
            }));
            FindViewById<BootstrapButton>(Resource.Id.example_bootstrap_btn_group).SetOnClickListener(new ViewOnClick(v => { StartActivity(new Intent(this, typeof(BootstrapButtonGroupExample))); }));
            FindViewById<BootstrapButton>(Resource.Id.example_bootstrap_cricle_thumbnail).SetOnClickListener(new ViewOnClick(v =>
            {
                //StartActivity(new Intent(this, typeof(BootstrapCircleThumbnailExample)));
            }));
            FindViewById<BootstrapButton>(Resource.Id.example_bootstrap_edit_text).SetOnClickListener(new ViewOnClick(v =>
            {
                //StartActivity(new Intent(this, typeof(BootstrapEditTextExample)));
            }));
            FindViewById<BootstrapButton>(Resource.Id.example_bootstrap_thumbnail).SetOnClickListener(new ViewOnClick(v =>
            {
                //StartActivity(new Intent(this, typeof(BootstrapThumbnailExample)));
            }));
            FindViewById<BootstrapButton>(Resource.Id.example_bootstrap_well).SetOnClickListener(new ViewOnClick(v =>
            {
                //StartActivity(new Intent(this, typeof(BootstrapWellExample)));
            }));
            FindViewById<BootstrapButton>(Resource.Id.example_bootstrap_dropdown).SetOnClickListener(new ViewOnClick(v =>
            {
                //StartActivity(new Intent(this, typeof(BootstrapDropDownExample)));
            }));
            FindViewById<BootstrapButton>(Resource.Id.example_bootstrap_alert).SetOnClickListener(new ViewOnClick(v => { StartActivity(new Intent(this, typeof(BootstrapAlertExample))); }));
            FindViewById<BootstrapButton>(Resource.Id.example_bootstrap_badge).SetOnClickListener(new ViewOnClick(v => { StartActivity(new Intent(this, typeof(BootstrapBadgeExample))); }));

            //Butterknife.ButterKnife.Bind(this);
        }
    }

    public class SampleApplication : Application
    {
        public override void OnCreate()
        {
            base.OnCreate();
            TypefaceProvider.RegisterDefaultIconSets();
        }
    }
}

