//using VS2017MasterDetail.Helpers; - No longer needed
using VS2017MasterDetail.Models;
using VS2017MasterDetail.Services;

using Xamarin.Forms;

//PRISM-CONVERSION-NOTE: Additional usings for Prism
using Prism.Mvvm;
using Prism.Navigation;

namespace VS2017MasterDetail.ViewModels
{
    //PRISM-CONVERSION-NOTE: Inheriting from Prism BindableBase instead of ObservableObject. In Prism
    //  view models typically inherit from BindableBase - or a sub-class of BindableBase
    public class BaseViewModel : BindableBase
    {
        /// <summary>
        /// Get the azure service instance
        /// </summary>
        /// 
        private IDataStore<Item> _dataStore;
        public IDataStore<Item> DataStore => _dataStore;

        //PRISM-CONVERSION-NOTE: The IDataStore<Item> instance (above) is now provided via dependency
        //  injection, instead of retrieved from the DependencyService.
        //public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }
        /// <summary>
        /// Private backing field to hold the title
        /// </summary>
        string title = string.Empty;
        /// <summary>
        /// Public property to set and get the title of the item
        /// </summary>
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        //PRISM-CONVERSION-NOTE: New constructor for receiving and storing Prism INavigationService instance
        //  and IDataStore<Item> instance
        public BaseViewModel(INavigationService navigationService, IDataStore<Item> dataStore)
        {
            NavigationService = navigationService;
            _dataStore = dataStore;
        }

        protected INavigationService NavigationService;
    }

    //PRISM-CONVERSION-NOTE: This special class will allow us to have IntelliSense while we are
    //  editing our XAML view files in Visual Studio with ReSharper.  I.e. it is for design-time only, 
    //  and does nothing at compile-time or run-time.
    //  For more info, check these pages -
    //  https://github.com/PrismLibrary/Prism/issues/986
    //  https://gist.github.com/nuitsjp/7478bfc7eba0f2a25b866fa2e7e9221d
    //  https://blog.nuits.jp/enable-intellisense-for-viewmodel-members-with-prism-for-xamarin-forms-2f274e7c6fb6
    public static class DesignTimeViewModelLocator
    {
        public static AboutViewModel AboutPage => null;
        public static ItemDetailViewModel ItemDetailPage => null;
        public static ItemsViewModel ItemsPage => null;
        public static NewItemViewModel NewItemPage => null;
    }
}
