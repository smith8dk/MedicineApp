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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {

            if (FullName_Entry.Text != "" && FullName_Entry.Text != null)
            {
                EntryValue.Text = "Username = " + FullName_Entry.Text + " Password = " + Password_Entry.Text;
            }
            else
            {
                EntryValue.Text = "";
            }

        }

        void FullName_Entry_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {

            if (FullName_Entry.Text != "" && FullName_Entry.Text != null)
            {
                EntryValue.Text = "Username = " + FullName_Entry.Text + " Password = " + Password_Entry.Text;
            }
            else
            {
                EntryValue.Text = "";
            }
        }
    }
}