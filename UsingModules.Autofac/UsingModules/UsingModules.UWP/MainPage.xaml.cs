using Windows.UI.Xaml;
using Prism.Autofac.Forms;

namespace UsingModules.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new UsingModules.App(new UwpInitializer()));
        }
    }

    public class UwpInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IAutofacContainer container)
        {

        }
    }
}
