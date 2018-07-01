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

namespace Com.Beardedhen.Androidbootstrap
{
    public partial class BootstrapButtonGroup
    {
        static IntPtr id_setOrientation_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.beardedhen.androidbootstrap']/class[@name='BootstrapButtonGroup']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("setOrientation", "(I)V", "GetSetOrientation_IHandler")]
        public unsafe void SetOrientation(int p0)
        {
            if (id_setOrientation_I == IntPtr.Zero)
                id_setOrientation_I = JNIEnv.GetMethodID(class_ref, "setOrientation", "(I)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setOrientation_I, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setOrientation", "(I)V"), __args);
            }
            finally
            {
            }
        }
    }
}