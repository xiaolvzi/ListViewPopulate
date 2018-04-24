using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace ViewImageTest
{
    public class MyLifecycleHandler : Java.Lang.Object,Application.IActivityLifecycleCallbacks
    {

        private static int resumed;
        private static int paused;
        private static int started;
        private static int stopped;
        public void OnActivityCreated(Activity activity, Bundle savedInstanceState)
        {
            Log.Error("lv", "OnActivityCreated");
        }

        public void OnActivityDestroyed(Activity activity)
        {
            Log.Error("lv", "OnActivityDestroyed");
        }

        public void OnActivityPaused(Activity activity)
        {
            paused++;
            Log.Error("lv", paused + "paused");
        }

        public void OnActivityResumed(Activity activity)
        {
            resumed++;
            Log.Error("lv",resumed+ "resumed");
        }

        public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
        {
            Log.Error("lv", "OnActivitySaveInstanceState");
        }

        public void OnActivityStarted(Activity activity)
        {
            started++;
            Log.Error("lv", started + "started");
        }

        public void OnActivityStopped(Activity activity)
        {
            stopped++;
            Log.Error("lv", stopped + "stopped");
        }
    }
}