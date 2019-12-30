using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Opdracht3.ViewModels
{
    public class NewPlaceViewModel : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public DateTime VisitDate {
            get {
                return DateTime.Now.ToUniversalTime();
            }
        }
        public double Latitude { get; }
        public double Longitude { get; }
        public string ImagePath { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
