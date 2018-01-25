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

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using Android.Util;
using Android.Widget;

[assembly: ExportRenderer(typeof(HelloRenderers.HelloView),typeof(HelloRenderers.Droid.HelloViewRenderer))]

namespace HelloRenderers.Droid
{
    public class HelloViewRenderer : ViewRenderer<HelloView, TextView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<HelloView> args)
        {
            base.OnElementChanged(args);

            if (Control == null)
            {
                SetNativeControl(new TextView(Context)
                {
                    Text = "Hello from Android!"
                });

                Control.SetTextSize(ComplexUnitType.Sp, 24);
            }
        }
    }
}