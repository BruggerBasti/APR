using System;

using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

using WeatherApp.Models;
using System.Collections.ObjectModel;

namespace WeatherApp.ViewModels
{
	public partial class MainViewModel : ObservableObject
	{
		[ObservableProperty]
		ObservableCollection<Weather> _wetter = new ObservableCollection<Weather>();

		public MainViewModel()
		{
			Weather w1 = new Weather();
			w1.Titel = "";
			w1.Beschreibung = "";
			w1.Bild = "";
			w1.Datum = DateTime.Today;

            Weather sonnig = new Weather();
			sonnig.Titel = "Sonnig";
			sonnig.Beschreibung = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
			sonnig.Bild = "sonnig.jpg";
			sonnig.Datum = DateTime.Today;

			this.Wetter.Add(sonnig);
        }
	}
}

