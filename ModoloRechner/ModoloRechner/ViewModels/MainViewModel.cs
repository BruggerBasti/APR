using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ModoloRechner.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        Random rd = new Random();

        public MainViewModel()
        {
            Rndm = rd.Next(0, 1000);
            ausgerechnet = rndm % 2;
        }

        [ObservableProperty]
        int rndm;

        int ausgerechnet;

        [RelayCommand]
        public void NeueZahl()
        {
            Rndm = rd.Next(0, 1000);

            if(ausgerechnet == 1)
            {
                App.Current.MainPage.DisplayAlert("Ungerade", $"Die Zahl {rndm} ist ungerade", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Gerade", $"Die Zahl {rndm} ist Gerade", "OK");
            }
        }
    }
}

