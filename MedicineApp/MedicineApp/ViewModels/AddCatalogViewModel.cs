using MedicineApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MedicineApp.ViewModels
{
     public class CatalogViewModel
     {
         public ObservableCollection<Product> Products { get; set; }
     }
}
