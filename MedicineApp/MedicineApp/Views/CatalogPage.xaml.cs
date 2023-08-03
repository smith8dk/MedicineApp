using MedicineApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedicineApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatalogPage : ContentPage
    {
        public CatalogPage(PrescriptionListViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;      
        }
        private async void OnAddClicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new PrescriptionPage()); ;
        }
    }
}