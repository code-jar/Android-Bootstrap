using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Butterknife;

namespace Demo.Activites
{
    public class BaseActivity : AppCompatActivity
    {
        protected virtual int GetContentLayoutId() => throw new NotImplementedException();


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_base);

            var scrollView = FindViewById<ScrollView>(Resource.Id.scrollView);

            if (scrollView != null)
            {
                scrollView.AddView(LayoutInflater.From(this).Inflate(GetContentLayoutId(), scrollView, false));
            }

            //ButterKnife.Bind(this);
        }
    }
}