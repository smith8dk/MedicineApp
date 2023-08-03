using MedicineApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static MedicineApp.Models.Perscription;

namespace MedicineApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PerscriptionPage : ContentPage
    {
        public PerscriptionPage()
        {
            InitializeComponent();
        }
        private void OnSavePrescriptionClicked(object sender, EventArgs e)
        {
            // Get the prescription details from the binding context
            Prescription prescription = (Prescription)BindingContext;

            // Display the prescription details in an alert
            DisplayAlert("Prescription Saved",
                         $"Name: {prescription.Name}\nInstructions: {prescription.Instructions}\nDescription: {prescription.Description}",
                         "OK");
        }
    }
}