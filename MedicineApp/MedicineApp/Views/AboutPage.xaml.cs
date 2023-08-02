using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedicineApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            // Your logic to handle the search bar text changed event
        }

        private void OnSettingsClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage());
        }

        private void OnProfileClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void OnHelpButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HelpPage());
        }
        private void OnCatologButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CatalogPage());
        }
        private void OnPerscriptionButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PerscriptionPage());
        }
        private void OnCalenderButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PerscriptionPage());
        }
    }
}