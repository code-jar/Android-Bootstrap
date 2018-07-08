using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Beardedhen.Androidbootstrap;
using Java.Lang;

namespace Demo.Class
{
    [Application]
    public class CusApplication : Application
    {
        public CusApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        public override void OnCreate()
        {
            base.OnCreate();

            AndroidEnvironment.UnhandledExceptionRaiser += AppUnhandledExceptionRaiser;
            CrashExceptionHandler.Instance.Init(this);

            TypefaceProvider.RegisterDefaultIconSets();
        }

        private void AppUnhandledExceptionRaiser(object sender, RaiseThrowableEventArgs e)
        {

            Task.Run(() =>
            {

                Looper.Prepare();

                Toast.MakeText(this, "AppUnhandledException:" + e.Exception.Message, ToastLength.Long).Show();

                Looper.Loop();

            });

            System.Threading.Thread.Sleep(2000);

            e.Handled = true;
        }

        protected override void Dispose(bool disposing)
        {
            AndroidEnvironment.UnhandledExceptionRaiser -= AppUnhandledExceptionRaiser;

            base.Dispose(disposing);
        }
    }


    public class CrashExceptionHandler : Java.Lang.Object, Java.Lang.Thread.IUncaughtExceptionHandler
    {
        //系统默认的UncaughtException处理类 
        private Thread.IUncaughtExceptionHandler mDefaultHandler;
        //CrashHandler实例
        public static CrashExceptionHandler Instance = new CrashExceptionHandler();
        //程序的Context对象
        private Context mContext;


        private CrashExceptionHandler()
        {
        }

        public void UncaughtException(Thread t, Throwable e)
        {
            if (!HandleException(e) && mDefaultHandler != null)
            {
                mDefaultHandler.UncaughtException(t, e);
            }
            else
            {
                Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
                JavaSystem.Exit(1);
            }
        }

        private bool HandleException(Throwable e)
        {
            if (e == null)
            {
                return false;
            }

            Task.Run(() =>
            {

                Looper.Prepare();

                Toast.MakeText(mContext, "ThreadUncaughtException:" + e.Message, ToastLength.Long).Show();

                Looper.Loop();

            });

            System.Threading.Thread.Sleep(2000);

            return true;
        }

        public void Init(Context ctx)
        {
            this.mContext = ctx;
            mDefaultHandler = Thread.DefaultUncaughtExceptionHandler;

            Thread.DefaultUncaughtExceptionHandler = this;
        }
    }
}