using MedicineApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace MedicineApp.ViewModels
{
    public class PrescriptionListViewModel
    {
        public ObservableCollection<Prescription> Prescriptions { get; set; }

        public PrescriptionListViewModel()
        {
            Prescriptions = new ObservableCollection<Prescription>();
        }

        public void AddPrescription(Prescription prescription)
        {
            Prescriptions.Add(prescription);
            OnPropertyChanged("Prescriptions");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
