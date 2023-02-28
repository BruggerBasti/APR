using System;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

using klassenListe3.Models;

namespace klassenListe3.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Schueler> _students = new ObservableCollection<Schueler>();

        int a = 0;

        [ObservableProperty]
        string _student = string.Empty;

        public MainViewModel()
        {
            Schueler s1 = new Schueler()
            {
                Vorname = "Sebastian",
                Nachname = "Entleitner",
                Anzeigename = "Sebastian Entleitner",
                Geburtsjahr = 2006,
                Bild = "sebastian.jpg",
            };

            Schueler s2 = new Schueler()
            {
                Vorname = "Pirmin",
                Nachname = "Höller",
                Anzeigename = "Pirmin Höller",
                Geburtsjahr = 2006,
                Bild = "pirmin.jpg",
            };

            Schueler s3 = new Schueler()
            {
                Vorname = "Yusuf",
                Nachname = "Bastürk",
                Anzeigename = "Yusuf Bastürk",
                Geburtsjahr = 2006,
                Bild = "yusuf.jpg",
            };

            s1.Geburtsjahr = DateTime.Now.Year - s1.Geburtsjahr;
            s2.Geburtsjahr = DateTime.Now.Year - s2.Geburtsjahr;
            s3.Geburtsjahr = DateTime.Now.Year - s3.Geburtsjahr;

            this.Students.Add(s1);
            this.Students.Add(s2);
            this.Students.Add(s3);

            // int i = r.Next(0, _students.Count);
            // this.Student = this.Students[a];
            a++;
        }

        [RelayCommand]
        void SelectStudent()
        {
            // int i = r.Next(0, _students.Count);
            // this.Student = this.Students[a];
            a++;
        }
    }
}