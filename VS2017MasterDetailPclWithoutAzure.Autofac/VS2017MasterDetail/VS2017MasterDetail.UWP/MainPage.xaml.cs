
//PRISM-CONVERSION-NOTE: The Prism.Autofac.Forms NuGet package (and all dependencies) were added
//  to this project, in order to use Prism for Xamarin.Forms functionality.
//Usings needed for Prism -
using Autofac;
using Prism.Autofac.Forms;

namespace VS2017MasterDetail.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            //PRISM-CONVERSION-NOTE: This line is temporarily needed for setting Prism to create 
            //  an immutable Autofac container
            Prism.Autofac.PrismApplication.ContainerType = AutofacContainerType.Immutable;

            //PRISM-CONVERSION-NOTE: Now initializing our App instance with a new platform-specific
            //  initializer that is declared below.
            LoadApplication(new VS2017MasterDetail.App(new UwpInitializer()));
        }
    }

    //PRISM-CONVERSION-NOTE: Platform-specific application initializer for any custom type registrations.
    public class UwpInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainer container)
        {
            //In the future, if we have any UWP-specific navigation or dependency registrations that need to
            //  be made during application initialization, we can do that here - e.g.:
            //container.RegisterType<UwpCustomService>().As<IPlatformCustomService>();
        }
    }
}