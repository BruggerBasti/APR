using System;
namespace klassenListe4.Models
{
    public class Schueler
    {
        public string Vorname { get; set; } = string.Empty;

        public string Nachname { get; set; } = string.Empty;

        public string Anzeigename => $"{Vorname} {Nachname}";

        public int Geburtsjahr { get; set; }

        public string Bild { get; set; } = string.Empty;
    }
}

