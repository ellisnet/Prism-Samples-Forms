//using System; - no longer needed

//using VS2017MasterDetail.Models; - no longer needed
//using VS2017MasterDetail.ViewModels; - no longer needed

using Xamarin.Forms;

namespace VS2017MasterDetail.Views
{
    public partial class ItemsPage : ContentPage
    {
        //ItemsViewModel viewModel; - no longer needed

        public ItemsPage()
        {
            InitializeComponent();

            //PRISM-CONVERSION-NOTE: Prism sets the BindingContext for us - 
            //BindingContext = viewModel = new ItemsViewModel();
        }

        //PRISM-CONVERSION-NOTE: The following logic has been moved to the ItemsViewModel class -
        //async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        //{
        //    var item = args.SelectedItem as Item;
        //    if (item == null)
        //        return;

        //    await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

        //    // Manually deselect item
        //    ItemsListView.SelectedItem = null;
        //}

        //async void AddItem_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new NewItemPage());
        //}

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    if (viewModel.Items.Count == 0)
        //        viewModel.LoadItemsCommand.Execute(null);
        //}
    }
}
