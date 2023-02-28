using System;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using produktListe2.Models;

namespace produktListe2.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Produkt> _produkte = new ObservableCollection<Produkt>();

        public MainViewModel()
        {
            Produkt ketchup = new Produkt();

            ketchup.Titel = "Ketchup";
            ketchup.Beschreibung = "Krank geil tomatiges Ketchup";
            ketchup.Bild = "ketchup.jpg";

            Produkt mayo = new Produkt()
            {
                Titel = "Mayonese",
                Beschreibung = "Sehr sehr leckere Mayonese",
                Bild = "mayo.jpg"
            };

            Produkt senf = new Produkt()
            {
                Titel = "Senf",
                Beschreibung = "Saftig schmaftig scharfer Senf",
                Bild = "senf.jpg"
            };

            this.Produkte.Add(ketchup);
            this.Produkte.Add(mayo);
            this.Produkte.Add(senf);

            /*
            this.Produkte.Add("Ketchup");
            this.Produkte.Add("Mayonese");
            this.Produkte.Add("Senf");
            */
        }
    }
}

