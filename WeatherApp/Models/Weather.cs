using System;
namespace WeatherApp.Models
{
    public class Weather
    {
        DateTime _datum;    

        public DateTime Datum
        {
            get => _datum;
            set
            {
                _datum = value;
            }
        }

        public string Titel { get; set; }

        public string Beschreibung { get; set; }

        public string Bild { get; set; }
    }
}

