using MedicineApp.Services;
using MedicineApp.ViewModels;
using MedicineApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedicineApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            PrescriptionListViewModel viewModel = new PrescriptionListViewModel();
            Resources.Add("PrescriptionListViewModel", viewModel);

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
