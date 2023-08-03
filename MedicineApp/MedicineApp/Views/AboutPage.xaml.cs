using MedicineApp.ViewModels;
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
            // Get the PrescriptionListViewModel from App's resources (App.xaml.cs)
            if (Application.Current.Resources.TryGetValue("PrescriptionListViewModel", out var viewModelObj) && viewModelObj is PrescriptionListViewModel viewModel)
            {
                // Pass the PrescriptionListViewModel instance to the CatalogPage constructor
                await Shell.Current.Navigation.PushAsync(new CatalogPage(viewModel));
            }
        }
        private async void OnPrescriptionButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new PrescriptionPage());
        }
        private async void OnStoreButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new StorePage());
        }
    }
}