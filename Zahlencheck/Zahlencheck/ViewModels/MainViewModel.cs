using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Zahlencheck.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        string _ausgabe = "";
        public string Ausgabe { get { return _ausgabe; } set { SetProperty(ref _ausgabe, value); } }

        [ObservableProperty]
        int _zahl;

        [RelayCommand]
        private void Check()
        {
            if(Zahl % 2 == 0)
            {
                this.Ausgabe = "Gerade";
            }
            else
            {
                this.Ausgabe = "Ungerade";
            }
        }
    }
}

