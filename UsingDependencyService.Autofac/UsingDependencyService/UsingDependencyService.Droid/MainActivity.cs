using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Autofac;
using Prism.Autofac.Forms;
using UsingDependencyService.Droid.Services;
using UsingDependencyService.Services;

namespace UsingDependencyService.Droid
{
    [Activity(Label = "UsingDependencyService", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            Prism.Autofac.PrismApplication.ContainerType = AutofacContainerType.Immutable;
            LoadApplication(new App(new AndroidInitializer()));
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainer container)
        {
            //One option would be to register the ITextToSpeech implementation here - this does not
            // use or require the Xamarin.Forms DependencyService.
            // But since the platform-specific implementation of ITextToSpeech *is* registered with
            // the DependencyService, the Autofac registration is being done in the portable library.
            //(container as IAutofacContainer)?.RegisterType<TextToSpeech_Android>().As<ITextToSpeech>();
        }
    }
}
