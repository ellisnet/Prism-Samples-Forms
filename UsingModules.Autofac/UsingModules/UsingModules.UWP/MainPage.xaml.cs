using Windows.UI.Xaml;
using Autofac;
using Prism.Autofac.Forms;

namespace UsingModules.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            Prism.Autofac.PrismApplication.ContainerType = AutofacContainerType.Immutable;
            LoadApplication(new UsingModules.App(new UwpInitializer()));
        }
    }

    public class UwpInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainer container)
        {

        }
    }
}
