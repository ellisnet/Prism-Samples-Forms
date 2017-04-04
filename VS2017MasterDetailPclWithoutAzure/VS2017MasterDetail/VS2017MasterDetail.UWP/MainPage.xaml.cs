
//PRISM-CONVERSION-NOTE: The Prism.Unity.Forms NuGet package (and all dependencies) were added
//  to this project, in order to use Prism for Xamarin.Forms functionality.
//Usings needed for Prism -
using Prism.Unity;
using Microsoft.Practices.Unity;

namespace VS2017MasterDetail.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            //PRISM-CONVERSION-NOTE: Now initializing our App instance with a new platform-specific
            //  initializer that is declared below.
            LoadApplication(new VS2017MasterDetail.App(new UwpInitializer()));
        }
    }

    //PRISM-CONVERSION-NOTE: Platform-specific application initializer for any custom type registrations.
    public class UwpInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {
            //In the future, if we have any UWP-specific navigation or dependency registrations that need to
            //  be made during application initialization, we can do that here - e.g.:
            //container.RegisterType<IPlatformCustomService, UwpCustomService>();
        }
    }
}