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

namespace PreloadDesignScreen
{
    [Activity(Label = "Preload_smart_scan_setup")]
    public class Preload_smart_scan_setup : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Preload_smart_scan_setup);
            // Create your application here
        }
    }
}