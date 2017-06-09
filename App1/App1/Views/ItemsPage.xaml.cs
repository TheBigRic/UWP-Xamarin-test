using System;
using Xamarin.Forms;

namespace App1.Views
{
    public partial class ItemsPage : ContentPage
    {

        public ItemsPage()
        {
            InitializeComponent();
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await this.DisplayAlert("Button clicked", "You clicked the button!","Ok");
        }
    }
}
