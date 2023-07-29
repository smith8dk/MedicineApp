using MedicineApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MedicineApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}