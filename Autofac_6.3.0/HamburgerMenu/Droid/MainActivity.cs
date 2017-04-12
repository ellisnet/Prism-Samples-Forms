using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Autofac;
using Prism.Autofac.Forms;

namespace HamburgerMenu.Droid
{
    [Activity( Label = "HamburgerMenu.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate( Bundle bundle )
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate( bundle );

            global::Xamarin.Forms.Forms.Init( this, bundle );

            LoadApplication( new App(new AndroidInitializer()) );
            //TODO: The line above seems to execute successfully with version 6.3.0 of Prism.Autofac.Forms,
            // but then the application crashes.
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainer container)
        {

        }
    }
}
