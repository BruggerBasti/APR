using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using SpruchLib;

namespace SpruchGUI.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string _ausgabe = string.Empty;

        Spruch s = new Spruch();

        public MainViewModel()
        {
            s.AddSpruch("Lorem");
            s.AddSpruch("ipsum");
            s.AddSpruch("dolor");

            this.Ausgabe = s.NextSpruch();
        }

        [RelayCommand]
        void Next()
        {
            this.Ausgabe = s.NextSpruch(); 
        }
    }
}