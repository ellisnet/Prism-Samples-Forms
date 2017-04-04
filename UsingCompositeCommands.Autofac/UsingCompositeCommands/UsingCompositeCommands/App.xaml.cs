using UsingCompositeCommands.ViewModels;
using UsingCompositeCommands.Views;

using Autofac;
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

            //var builder = new ContainerBuilder();
            //builder.RegisterType<ApplicationCommands>().As<IApplicationCommands>().SingleInstance();
            //builder.Update(Container);
            (Container as IAutofacContainer)?.RegisterType<ApplicationCommands>().As<IApplicationCommands>().SingleInstance();
        }
    }
}
