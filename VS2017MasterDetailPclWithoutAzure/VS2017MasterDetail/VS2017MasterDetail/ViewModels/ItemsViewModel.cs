using System;
using System.Diagnostics;
using System.Threading.Tasks;

using VS2017MasterDetail.Helpers;
using VS2017MasterDetail.Models;
//using VS2017MasterDetail.Views; - no longer needed

using Xamarin.Forms;

//PRISM-CONVERSION-NOTE: Additional usings for Prism
using Prism.Commands;
using Prism.Navigation;
using VS2017MasterDetail.Services;

namespace VS2017MasterDetail.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Item> Items { get; set; }

        //PRISM-CONVERSION-NOTE: We will be identifying which item was selected from the list using this
        //  SelectedItem property. When an item is selected (unless it is null) we will navigate to the
        //  ItemDetailPage, providing the selected item to the new page via the NavigationParameters collection.
        private Item _selectedItem;
        public Item SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                SetProperty(ref _selectedItem, value);
                if (value != null)
                {
                    Task.Run(async () => {
                        //When the user returns to the Items list, the most recently visited item
                        //  will no longer be selected.
                        await Task.Delay(500);
                        this.SelectedItem = null;
                    });
                    NavigationService.NavigateAsync("ItemDetailPage", new NavigationParameters { {"item", value} });
                }
            }
        }

        //PRISM-CONVERSION-NOTE: Changed the LoadItemsCommand to be a Prism DelegateCommand and added an 
        //  AddItemCommand to be bound to the view's Add Item toolbar button.
        public DelegateCommand LoadItemsCommand { get; set; }
        public DelegateCommand AddItemCommand { get; set; }

        //PRISM-CONVERSION-NOTE: Now using Prism dependency injection for the IDataStore<Item> instance 
        //  and for the INavigationService instance - both passed to and stored by the BaseViewModel
        public ItemsViewModel(INavigationService navigationService, IDataStore<Item> dataStore)
            : base(navigationService, dataStore)
        {
            Title = "Browse";
            Items = new ObservableRangeCollection<Item>();
            LoadItemsCommand = new DelegateCommand(async () => await ExecuteLoadItemsCommand());

            //PRISM-CONVERSION-NOTE: Three more changes in this constructor -
            //  1. The object that will send the "AddItem" message will now be the NewItemViewModel instead of the 
            //       NewItemPage, so our MessagingCenter.Subscribe<> Type parameter needed to be changed.
            MessagingCenter.Subscribe<NewItemViewModel, Item>(this, "AddItem", async (obj, item) =>
            {
                var _item = item as Item;
                Items.Add(_item);
                await DataStore.AddItemAsync(_item);
            });

            //  2. Implement our new AddItemCommand for navigating to the NewItemPage when user taps "Add Item"
            AddItemCommand = new DelegateCommand(async () => await NavigationService.NavigateAsync("NewItemPage"));

            //  3. Call our LoadItemsCommand to perform the initial load of items
            LoadItemsCommand.Execute();
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                Items.ReplaceRange(items);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessagingCenter.Send(new MessagingCenterAlert
                {
                    Title = "Error",
                    Message = "Unable to load items.",
                    Cancel = "OK"
                }, "message");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}