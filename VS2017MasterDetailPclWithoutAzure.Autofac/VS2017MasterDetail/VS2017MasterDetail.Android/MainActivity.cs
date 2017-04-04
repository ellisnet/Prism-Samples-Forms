using Android.App;
using Android.Content.PM;
using Android.OS;

//PRISM-CONVERSION-NOTE: The Prism.Autofac.Forms NuGet package (and all dependencies) were added
//  to this project, in order to use Prism for Xamarin.Forms functionality.
//Usings needed for Prism -
using Autofac;
using Prism.Autofac.Forms;

namespace VS2017MasterDetail.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            //PRISM-CONVERSION-NOTE: This line is temporarily needed for setting Prism to create 
            //  an immutable Autofac container
            Prism.Autofac.PrismApplication.ContainerType = AutofacContainerType.Immutable;

            //PRISM-CONVERSION-NOTE: Now initializing our App instance with a new platform-specific
            //  initializer that is declared below.
            LoadApplication(new App(new AndroidInitializer()));
        }
    }

    //PRISM-CONVERSION-NOTE: Platform-specific application initializer for any custom type registrations.
    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainer container)
        {
            //In the future, if we have any Android-specific navigation or dependency registrations that need to
            //  be made during application initialization, we can do that here - e.g.:
            //container.RegisterType<AndroidCustomService>().As<IPlatformCustomService>();
        }
    }
}