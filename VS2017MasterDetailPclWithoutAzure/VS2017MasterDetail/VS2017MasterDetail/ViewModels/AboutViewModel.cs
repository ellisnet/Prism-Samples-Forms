using System;
//using System.Windows.Input; - No longer needed
using Xamarin.Forms;

//PRISM-CONVERSION-NOTE: Additional usings for Prism
using Prism.Commands;
using Prism.Navigation;

using VS2017MasterDetail.Models;
using VS2017MasterDetail.Services;

namespace VS2017MasterDetail.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        //PRISM-CONVERSION-NOTE: Now using Prism dependency injection for the IDataStore<Item> instance 
        //  and for the INavigationService instance - both passed to and stored by the BaseViewModel
        public AboutViewModel(INavigationService navigationService, IDataStore<Item> dataStore)
            : base(navigationService, dataStore)
        {
            Title = "About";

            OpenWebCommand = new DelegateCommand(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        //PRISM-CONVERSION-NOTE: Using Prism's DelegateCommand instead of ICommand for OpenWebCommand

        /// <summary>
        /// Command to open browser to xamarin.com
        /// </summary>
        public DelegateCommand OpenWebCommand { get; }
    }
}
