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
            
        }

        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(SettingsPage)}");
        }

        private async void OnProfileClick(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new LoginPage());
        }

        private async void OnHelpButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(HelpPage)}");
        }
        private async void OnCatologButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new CatalogPage());
        }
        private async void OnPerscriptionButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new PerscriptionPage());
        }
        private async void OnCalenderButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new CalendarPage());
        }
    }
}