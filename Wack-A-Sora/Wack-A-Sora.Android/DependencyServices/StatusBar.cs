using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wack_A_Sora.Droid.DependencyServices;
using Xamarin.Forms;


[assembly:Dependency(typeof(StatusBar))]
namespace Wack_A_Sora.Droid.DependencyServices
{
    internal class StatusBar : IStatusBar
    {
        private WindowManagerFlags _originalFlags;
        public void HideStatusBar()
        {
            var activity = (Activity)Forms.Context;
            var attributes = activity.Window.Attributes;
            _originalFlags = attributes.Flags;
            attributes.Flags = Android.Views.WindowManagerFlags.Fullscreen;
            activity.Window.Attributes = attributes;

        }
        public void ShowStatusBar()
        {
            var activity = (Activity)Forms.Context;
            var attributes = activity.Window.Attributes;
            attributes.Flags = _originalFlags;
            activity.Window.Attributes = attributes;
        }
    }
}