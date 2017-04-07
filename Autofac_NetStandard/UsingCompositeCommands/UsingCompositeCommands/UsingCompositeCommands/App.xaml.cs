using UsingCompositeCommands.ViewModels;
using UsingCompositeCommands.Views;

using Prism.Autofac;
using Prism.Autofac.Forms;

namespace UsingCompositeCommands
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<Xamarin.Forms.NavigationPage>();
            Container.RegisterTypeForNavigation<TabA, TabViewModel>();
            Container.RegisterTypeForNavigation<TabB, TabViewModel>();
            Container.RegisterTypeForNavigation<TabC, TabViewModel>();

            Container.RegisterType<ApplicationCommands>().As<IApplicationCommands>().SingleInstance();
        }
    }
}
