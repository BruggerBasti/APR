using System;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace klassenListe.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> _students = new ObservableCollection<string>();

        [ObservableProperty]
        string _student = string.Empty;

        public MainViewModel()
        {
            this.Students.Add("Max Muster");
            this.Students.Add("Manfred Tester");
            this.Students.Add("Anita Maier");
        }

        [RelayCommand]
        void SelectStudent()
        {
            Random r = new Random();

            int i = r.Next(0, _students.Count);


        }
    }
}

