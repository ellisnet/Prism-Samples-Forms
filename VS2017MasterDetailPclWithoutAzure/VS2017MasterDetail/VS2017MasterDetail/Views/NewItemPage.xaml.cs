//using System; - no longer needed
//using VS2017MasterDetail.Models; - no longer needed

using Xamarin.Forms;

namespace VS2017MasterDetail.Views
{
    public partial class NewItemPage : ContentPage
    {
        public NewItemPage()
        {
            InitializeComponent();

            //PRISM-CONVERSION-NOTE: This code has been moved to the NewItemViewModel class
            //  and BindingContext setting is handled by Prism.
            //Item = new Item
            //{
            //    Text = "Item name",
            //    Description = "This is a nice description"
            //};

            //BindingContext = this;
        }

        //PRISM-CONVERSION-NOTE: The following logic has been moved to the new NewItemViewModel class -
        //public Item Item { get; set; }
        //async void Save_Clicked(object sender, EventArgs e)
        //{
        //    MessagingCenter.Send(this, "AddItem", Item);
        //    await Navigation.PopToRootAsync();
        //}
    }
}