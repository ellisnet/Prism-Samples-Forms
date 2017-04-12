using Autofac;
using Xamarin.Forms;
using HamburgerMenu.Services;
using HamburgerMenu.Views;
using Prism.Autofac;
using Prism.Autofac.Forms;
using Prism.Logging;
using Prism.Navigation;

namespace HamburgerMenu
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        public new static App Current
        {
            get { return Application.Current as App; }
        }

        public new ILoggerFacade Logger
        {
            get { return base.Logger; }
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync( "Navigation/Login" );
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>( "Navigation" );
            Container.RegisterTypeForNavigation<MainPage>( "Index" );
            Container.RegisterTypeForNavigation<LoginPage>( "Login" );
            Container.RegisterTypeForNavigation<ViewA>();
            Container.RegisterTypeForNavigation<ViewB>();
            Container.RegisterTypeForNavigation<ViewC>();

            var builder = new ContainerBuilder();
            builder.RegisterType<AuthenticationService>().As<IAuthenticationService>().SingleInstance();
            builder.Update(Container);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
