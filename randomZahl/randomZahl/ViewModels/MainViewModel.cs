using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace randomZahl.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        Random rndm = new Random();

        public MainViewModel()
        {
            _rndmZahl = rndm.Next(0, 1000);
        }

        [RelayCommand]
        private void NeuGenerieren()
        {
            _rndmZahl = rndm.Next(0, 1000);
        }

        int _rndmZahl = 0;

        [ObservableProperty]
        int _zahl;

        [ObservableProperty]
        int versuche = 0;

        [RelayCommand]
        private void Check()
        {
            if (_rndmZahl == Zahl)
            {
                App.Current.MainPage.DisplayAlert("Richtig!", "Du hast die richtige Zahl erraten", "OK");
            }
            else if (_rndmZahl < Zahl)
            {
                App.Current.MainPage.DisplayAlert("Darüber!", $"{Zahl} > gesuchte Zahl", "OK");
                Versuche++;
            }
            else if (_rndmZahl > Zahl)
            {
                App.Current.MainPage.DisplayAlert("Darunter!", $"{Zahl} < gesuchte Zahl", "OK");
                Versuche++;
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Fehler!", "Fehler.", "OK");
            }

        }
    }
}

