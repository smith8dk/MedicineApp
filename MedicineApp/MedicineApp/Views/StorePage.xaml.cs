using MedicineApp.Models;
using MedicineApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedicineApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StorePage : ContentPage
    {
        public StorePage()
        {
            InitializeComponent();

            var products = new ObservableCollection<Product>
            {
                new Product { Name = "Product 1", Description = "Description for Product 1", Price = 10.99m },
                new Product { Name = "Product 2", Description = "Description for Product 2", Price = 24.99m },
                new Product { Name = "Product 3", Description = "Description for Product 3", Price = 15.49m }
                // Add more products here
            };

            // Set the BindingContext to the view model containing the products
            BindingContext = new CatalogViewModel { Products = products };
        }
    }
}