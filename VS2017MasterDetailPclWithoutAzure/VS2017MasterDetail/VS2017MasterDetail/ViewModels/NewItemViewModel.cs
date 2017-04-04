using Xamarin.Forms;

using Prism.Commands;
using Prism.Navigation;

using VS2017MasterDetail.Models;
using VS2017MasterDetail.Services;

//PRISM-CONVERSION-NOTE: This new NewItemViewModel class was created, so that logic could be removed from the 
//  NewItemPage.xaml.cs code-behind file. When using Prism, our XAML page code-behind files should be as empty
//  as possible.

namespace VS2017MasterDetail.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        public Item Item { get; set; }

        public DelegateCommand SaveItemCommand { get; set; }

        public NewItemViewModel(INavigationService navigationService, IDataStore<Item> dataStore)
            : base(navigationService, dataStore)
        {
            Item = new Item
            {
                Text = "Item name",
                Description = "This is a nice description"
            };

            SaveItemCommand = new DelegateCommand(async () => {
                MessagingCenter.Send(this, "AddItem", Item);
                await NavigationService.GoBackAsync();
            });
        }
    }
}
