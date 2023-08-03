using MedicineApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MedicineApp.Models;

namespace MedicineApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrescriptionPage : ContentPage
    {
        public PrescriptionPage()
        {
            InitializeComponent();

            BindingContext = new Models.Prescription
            {
                Name = "",
                Instructions = "",
                Description = ""
            };
        }
        private async void OnSavePrescriptionClicked(object sender, EventArgs e)
        {
            Models.Prescription prescription = (Models.Prescription)BindingContext;

            await DisplayAlert("Prescription Saved",
                         $"Name: {prescription.Name}\nInstructions: {prescription.Instructions}\nDescription: {prescription.Description}",
                         "OK");

            PrescriptionListViewModel viewModel = (PrescriptionListViewModel)Application.Current.Resources["PrescriptionListViewModel"];

            viewModel.AddPrescription(prescription);

            await Navigation.PushAsync(new CatalogPage(viewModel));
        }
    }
}