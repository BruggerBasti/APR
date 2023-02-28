using System;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace produktListe.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> _produkte = new ObservableCollection<string>();

        public MainViewModel()
        {
            this.Produkte.Add("Ketchup");
            this.Produkte.Add("Mayonese");
            this.Produkte.Add("Senf");
        }
    }
}

