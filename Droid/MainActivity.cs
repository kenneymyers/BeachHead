using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace BeachHead.Droid
{
    [Activity(Label = "BeachHead.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        public static IValueCallback UploadMessage; // Used for File Chooser in WebViewRender

		protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }

        internal static int FILECHOOSER_RESULTCODE = 1;

		protected override void OnActivityResult(int requestCode, Result resultCode, Intent intent)
		{
			// Handles the response from the FileChooser
			if (requestCode == FILECHOOSER_RESULTCODE)
			{
				if (null == UploadMessage)
					return;
				Java.Lang.Object result = intent == null || resultCode != Result.Ok
					? null
					: intent.Data;
				UploadMessage.OnReceiveValue(result);
				UploadMessage = null;
			}
		}
    }
}
