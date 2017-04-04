using VS2017MasterDetail.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//PRISM-CONVERSION-NOTE: Additional usings required for Prism -
using Prism.Unity;
using Microsoft.Practices.Unity;
using VS2017MasterDetail.Models;
using VS2017MasterDetail.Services;
using VS2017MasterDetail.ViewModels;

//PRISM-CONVERSION-NOTE: The Prism.Unity.Forms NuGet package (and all dependencies) were added
//  to this project, in order to use Prism for Xamarin.Forms functionality.

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace VS2017MasterDetail
{
    //PRISM-CONVERSION-NOTE: Previously, the App class inherited from (Xamarin.Forms.)Application -
    //  now inheriting from PrismApplication
    public partial class App : PrismApplication
    {
        //PRISM-CONVERSION-NOTE: The old App class constructor (commented out below) was replaced with
        //  this new constructor.  The InitializeComponent() and SetMainPage() method calls were moved to
        //  the OnInitialized() override below.

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            SetMainPage();
        }

        //public App()
        //{
        //    InitializeComponent();

        //    SetMainPage();
        //}

        //PRISM-CONVERSION-NOTE: Added logic for registering pages for navigation and dependency injection
        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<AboutPage, AboutViewModel>();
            Container.RegisterTypeForNavigation<ItemDetailPage, ItemDetailViewModel>();
            Container.RegisterTypeForNavigation<ItemsPage, ItemsViewModel>();
            Container.RegisterTypeForNavigation<NewItemPage, NewItemViewModel>();

            Container.RegisterType<IDataStore<Item>, MockDataStore>();
        }

        public static void SetMainPage()
        {
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse",
                        Icon = Device.OnPlatform("tab_feed.png",null,null)
                    },
                    new NavigationPage(new AboutPage())
                    {
                        Title = "About",
                        Icon = Device.OnPlatform("tab_about.png",null,null)
                    },
                }
            };
        }
    }
}
