using VS2017MasterDetail.Models;

//PRISM-CONVERSION-NOTE: Additional usings for Prism
using Prism.Navigation;
using VS2017MasterDetail.Services;

namespace VS2017MasterDetail.ViewModels
{
    //PRISM-CONVERSION-NOTE: The viewmodel now implements INavigationAware with OnNavigatingTo(), OnNavigatedTo() 
    //  and OnNavigatedFrom() methods. The item (to show detail for) is being provided via a navigation parameter
    //  instead of as a constructor parameter - see below.
    public class ItemDetailViewModel : BaseViewModel, INavigationAware
    {
        //PRISM-CONVERSION-NOTE: Updated Item to be a notification-generating property -
        //  was previously: public Item Item { get; set; }
        private Item _item;
        public Item Item
        {
            get { return _item; }
            set { SetProperty(ref _item, value); }
        }

        //PRISM-CONVERSION-NOTE: New constructor with Prism dependency injection for the IDataStore<Item> instance 
        //  and for the INavigationService instance - both passed to and stored by the BaseViewModel
        public ItemDetailViewModel(INavigationService navigationService, IDataStore<Item> dataStore)
            : base(navigationService, dataStore)
        {
        }

        //PRISM-CONVERSION-NOTE: This is the old constructor that allows the Item to be viewed to be passed in
        //  via a parameter; in Prism we usually pass these objects as NavigationParameters members, and look for
        //  them in the OnNavigatedTo() method (below) -

        //public ItemDetailViewModel(Item item = null)
        //{
        //    Title = item.Text;
        //    Item = item;
        //}

        int quantity = 1;
        public int Quantity
        {
            get { return quantity; }
            set { SetProperty(ref quantity, value); }
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            //Called before the implementor has been navigated to - but not called when using 
            // device hardware or software back buttons.
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            // Called when the implementer has been navigated to.

            //PRISM-CONVERSION-NOTE: Now getting our item as a NavigationParameters member, instead of via 
            //  constructor injection.
            if (parameters?["item"] is Item item)
            {
                Title = item.Text;
                Item = item;
            }
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            // Called when the implementer has been navigated away from.
        }
    }
}